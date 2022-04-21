using Hangman_Game.Utilities;
using System.Text;

namespace Hangman_Game.Models
{
    public class GameModel : ObservableObject
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => OnPropertyChanged(ref _name, value);
        }

        private string _avatar;

        public string Avatar
        {
            get => _avatar;
            set => OnPropertyChanged(ref _avatar, value);
        }

        private int _id;

        public int ID
        {
            get => _id;
            set => OnPropertyChanged(ref _id, value);
        }

        private int _time;
        
        public int Time
        {
            get => _time;
            set => OnPropertyChanged(ref _time, value);
        }

        private int _mistakes;

        public int Mistakes
        {
            get => _mistakes;
            set => OnPropertyChanged(ref _mistakes, value);
        }

        private string _category;

        public string Category
        {
            get => _category;
            set => OnPropertyChanged(ref _category, value);
        }

        private int _level;

        public int Level
        {
            get => _level;
            set => OnPropertyChanged(ref _level, value);
        }

        private StringBuilder _currentWordState;

        public StringBuilder CurrentWordState
        {
            get => _currentWordState;
            set => OnPropertyChanged(ref _currentWordState, value);
        }

        private string _word;

        public string Word
        {
            get => _word;
            set => OnPropertyChanged(ref _word, value);
        }

        public GameModel(string name, string avatar, int id, int time, int mistakes, string category,
            int level, StringBuilder wordState, string word)
        {
            Name = name;
            Avatar = avatar;
            ID = id;
            Time = time;
            Mistakes = mistakes;
            Category = category;
            Level = level;
            CurrentWordState = wordState;
            Word = word;
        }

        public GameModel() { }

    }
}
