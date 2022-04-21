using GalaSoft.MvvmLight.Command;
using Hangman_Game.Models;
using Hangman_Game.Utilities;
using Hangman_Game.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Hangman_Game.ViewModel
{
    public partial class GameVM : ObservableObject
    {
        #region Private Declarations
        
        private LoginScreen _login = (LoginScreen)System.Windows.Application.Current.MainWindow;
        private GameModel _game;
        private ObservableCollection<CategoryModel> _categories;
        private Uri _imageSource;
        private int _mistakes;
        private int _level;
        private bool _visible;
        DispatcherTimer _dispatcherTimer = new DispatcherTimer();
        private int _delay = 40;
        private DateTime _deadline;
        private string _timerContent;
        private bool _savedGame = false;
        private int _gamesPlayed;
        private int _gamesWon;
        private Uri _avatarSource;
        #endregion

        public GameVM()
        {
            Categories = new ObservableCollection<CategoryModel>()
            {
                new CategoryModel("Movies"),
                new CategoryModel("Cars"),
                new CategoryModel("States"),
                new CategoryModel("Mountains"),
                new CategoryModel("Rivers")
            };
            NewGameCommand = new Utilities.RelayCommand(NewGame);
            SaveGameCommand = new Utilities.RelayCommand(SaveGame);
            LoadGameCommand = new Utilities.RelayCommand(LoadGame);
            DeleteAccountCommand = new Utilities.RelayCommand(DeleteAccount);
            ExitCommand = new Utilities.RelayCommand(Exit);
            AboutCommand = new Utilities.RelayCommand(About);
            NextLevelCommand = new Utilities.RelayCommand(NextLevel);
            StatisticsCommand = new Utilities.RelayCommand(DisplayStatistics);
            KeyboardVM = new KeyboardVM(this);
            Game = new GameModel();
            KeyboardVM.DisableKeyboard();
            GenerateCategories();
            XMLHandler.GetGames(_login.txtUsername.Text, ref _gamesPlayed, ref _gamesWon);
            _dispatcherTimer.Tick += new EventHandler(DispatcherTimerTick);

        }

        #region Public Declarations
        public string TimerContent
        {
            get => _timerContent;
            set => OnPropertyChanged(ref _timerContent, value);
        }
        public bool Visible
        {
            get => _visible;
            set => OnPropertyChanged(ref _visible, value);
        }
        public int Level
        {
            get => _level;
            set => OnPropertyChanged(ref _level, value);
        }
        public int Mistakes
        {
            get => _mistakes;
            set => OnPropertyChanged(ref _mistakes, value);
        }
        public Uri ImageSource
        {
            get => _imageSource;
            set => OnPropertyChanged(ref _imageSource, value);
        }
        public Uri AvatarSource
        {
            get => _avatarSource;
            set => OnPropertyChanged(ref _avatarSource, value);
        }
        public KeyboardVM KeyboardVM { get; set; }
        public ICommand NewGameCommand { get; }
        public ICommand SaveGameCommand { get; }
        public ICommand LoadGameCommand { get; }
        public ICommand DeleteAccountCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand AboutCommand { get; }
        public ICommand StatisticsCommand { get; }
        public ICommand NextLevelCommand { get; }
        public ObservableCollection<CategoryModel> Categories
        {
            get => _categories;
            set => OnPropertyChanged(ref _categories, value);
        }
        public GameModel Game
        {
            get => _game;
            set => OnPropertyChanged(ref _game, value);
        }
        #endregion

        #region Functions
        public void GenerateGame()
        {
            XDocument document = XDocument.Load("user.xml");
            var selectUser = from x in document.Descendants("User").Where
                             (x => (string)x.Element("Username") == _login.txtUsername.Text)
                             select new
                             {
                                 XMLid = x.Attribute("id").Value,
                                 XMLuser = x.Element("Username").Value,
                                 XMLpassword = x.Element("Password").Value,
                                 XMLavatar = x.Element("Avatar").Value
                             };

            var user = selectUser.First();

            StringBuilder temporary = new StringBuilder();
            temporary.Append(" _ ");

            for (int i = 1; i < Game.Word.Length; i++)
            {
                temporary.Append("_ ");
            }

            Game = new GameModel(user.XMLuser, user.XMLavatar, Convert.ToInt32(user.XMLid), 0, 0,
                "", 0, new StringBuilder(temporary.ToString()), Game.Word);
            AvatarSource = new Uri(@"../Images/" + Game.Avatar, UriKind.Relative);
        }
        public void ReplaceLetter(char letter)
        {
            StringBuilder temporary = new StringBuilder(Game.CurrentWordState.ToString());
            bool correctLetter = false;

            for (int i = 0; i < Game.Word.Length; i++)
            {
                if (Game.Word[i].ToString().ToLower() == letter.ToString().ToLower())
                {
                    Game.CurrentWordState[(2 * i) + 1] = letter;
                    correctLetter = true;
                }
            }

            if (correctLetter == false && letter != ' ')
            {
                Mistakes++;
                ImageSource = new Uri(@"../gameimages/" + Mistakes + ".jpg", UriKind.Relative);
            }
            if (Mistakes == 10)
            {
                MessageBox.Show("You Lost!");
                KeyboardVM.DisableKeyboard();
                StopTimer();
                foreach (var category in Categories)
                {
                    category.IsChecked = false;
                }
                Game.Word = null;
                _gamesPlayed++;
                XMLHandler.UpdateStatistics("Statistics.xml", Game.Name, _gamesPlayed, _gamesWon);
            }
            Game.CurrentWordState = new StringBuilder(Game.CurrentWordState.ToString());
            if (VerifyWord() && Level == 2)
            {
                MessageBox.Show("You Won the game Congratulations!");
                KeyboardVM.DisableKeyboard();
                foreach (var category in Categories)
                {
                    category.IsChecked = false;
                }
                StopTimer();
                _gamesWon++;
                XMLHandler.UpdateStatistics("Statistics.xml", Game.Name, _gamesPlayed, _gamesWon);
            }
            else if (VerifyWord())
            {
                MessageBox.Show("You Won this level!");
                Visible = true;
                Game.Word = null;
                KeyboardVM.DisableKeyboard();
                StopTimer();
            }

        }
        public bool VerifyWord()
        {
            for (int i = 0; i < Game.CurrentWordState.Length; i++)
            {
                if (Game.CurrentWordState[i] == '_')
                {
                    return false;
                }
            }
            return true;
        }
        public void GenerateCategories()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Categories.xml");

            XmlNodeList nodeList = doc.GetElementsByTagName("Movie");
            List<string> temporary = new List<string>();

            foreach (XmlNode node in nodeList)
            {
                temporary.Add(node["Name"].InnerText);
            }
            Categories[0].Words = temporary.ToList();

            XmlNodeList nodeList1 = doc.GetElementsByTagName("Car");
            temporary.Clear();

            foreach (XmlNode node in nodeList1)
            {
                temporary.Add(node["Name"].InnerText);
            }
            Categories[1].Words = temporary.ToList();

            XmlNodeList nodeList2 = doc.GetElementsByTagName("State");
            temporary.Clear();

            foreach (XmlNode node in nodeList2)
            {
                temporary.Add(node["Name"].InnerText);
            }
            Categories[2].Words = temporary.ToList();

            XmlNodeList nodeList3 = doc.GetElementsByTagName("Mountain");
            temporary.Clear();

            foreach (XmlNode node in nodeList3)
            {
                temporary.Add(node["Name"].InnerText);
            }
            Categories[3].Words = temporary.ToList();

            XmlNodeList nodeList4 = doc.GetElementsByTagName("River");
            temporary.Clear();

            foreach (XmlNode node in nodeList4)
            {
                temporary.Add(node["Name"].InnerText);
            }
            Categories[4].Words = temporary.ToList();
        }
        public void ChooseWord()
        {
            Random rnd = new Random();
            int pos;
            List<string> words = new List<string>();

            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].IsChecked)
                {
                    pos = rnd.Next(0, Categories[i].Words.Count);
                    words.Add(Categories[i].Words[pos]);
                }
            }
            if (words.Count == 0)
            {
                MessageBox.Show("Choose a category first!");
            }
            else if (words.Count > 1)
            {
                pos = rnd.Next(0, words.Count);
                Game.Word = words[pos];
            }
            else
            {
                Game.Word = words[0];
            }
        }
        public void NewGame()
        {
            Visible = false;
            Mistakes = 0;
            ChooseWord();
            if (Game.Word != null)
            {
                _delay = 40;
                Level = 1;
                GenerateGame();
                KeyboardVM.EnableKeyboard();
                KeyboardVM.EmptyFunction();
                ImageSource = new Uri(@"../gameimages/" + "0.jpg", UriKind.Relative);
                StartTimer();
            }
        }
        public void NextLevel()
        {
            _delay = 40;
            Mistakes = 0;
            ChooseWord();
            if (Game.Word != null)
            {
                Level++;
                GenerateGame();
                KeyboardVM.EnableKeyboard();
                KeyboardVM.EmptyFunction();
                ImageSource = new Uri(@"../gameimages/" + "0.jpg", UriKind.Relative);
                Visible = false;
                StartTimer();
            }

        }
        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            int secondsRemaining = (_deadline - DateTime.Now).Seconds;
            if (secondsRemaining == 0)
            {
                _dispatcherTimer.Stop();
                _dispatcherTimer.IsEnabled = false;
                MessageBox.Show("Time has expired! You lost!");
                KeyboardVM.DisableKeyboard();
                foreach (var category in Categories)
                {
                    category.IsChecked = false;
                }
                _delay = 40;
                Game.Word = null;
            }
            else
            {
                TimerContent = secondsRemaining.ToString();
            }
        }
        public void StartTimer()
        {
            _deadline = DateTime.Now.AddSeconds(_delay);
            _dispatcherTimer.Start();
        }
        public void StopTimer()
        {
            _dispatcherTimer.Stop();
            _delay = (_deadline - DateTime.Now).Seconds;
            _deadline = DateTime.Now.AddSeconds(_delay);
        }
        public void SaveGame()
        {
            if (Game.Word == null)
            {
                MessageBox.Show("You need to start a game first!");
            }
            else
            {
                _savedGame = true;
                StopTimer();
                Game.Time = _delay;
                Game.Mistakes = Mistakes;
                string cat = "";
                foreach (var category in Categories)
                {
                    if (category.IsChecked)
                    {
                        cat += category.Name;
                        cat += " ";
                    }
                }
                Game.Category = cat;
                Game.Level = Level;

                XMLHandler.SaveGame("SavedGames.xml", Game.Name, Game.Avatar, Game.ID, Game.Time, Game.Mistakes, Game.Category,
                    Game.Level, Game.Word, Game.CurrentWordState.ToString());
                StartTimer();
            }
        }
        public void LoadGame()
        {
            Game = XMLHandler.LoadGame("SavedGames.xml", _login.txtUsername.Text);
            if (Game.Word != null)
            {
                Level = Game.Level;
                Mistakes = Game.Mistakes;
                _delay = Game.Time;
                ImageSource = new Uri(@"../gameimages/" + Mistakes + ".jpg", UriKind.Relative);
                AvatarSource = new Uri(@"../images/" + Game.Avatar, UriKind.Relative);
                KeyboardVM.EnableKeyboard();
                StartTimer();
                string[] categ = Game.Category.Split(' ');
                foreach (var category in Categories)
                {
                    if (categ.Contains(category.Name))
                    {
                        category.IsChecked = true;
                    }
                }
            }
        }
        public void Exit()
        {
            if (_savedGame == true)
            {
                System.Environment.Exit(0);
            }
            else
            {
                if (MessageBox.Show("You forgot to save! Exit anyway?", "Exit", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    System.Environment.Exit(0);
                }
            }
        }
        public void DeleteAccount()
        {
            if (MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {

                XMLHandler.DeleteAccount(_login.txtUsername.Text);
                System.Environment.Exit(0);

            }
        }
        public void About()
        {
            About about = new About();
            about.Show();
        }
        public void DisplayStatistics()
        {
            MessageBox.Show(XMLHandler.GetStatistics());
        }
        

        #endregion
    }
}
