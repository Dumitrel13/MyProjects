using Hangman_Game.Models;
using Hangman_Game.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Hangman_Game.Utilities
{
    public class XMLHandler
    {
        public XMLHandler() { }
        public static void SaveGame(string filename, string username, string avatar, int id, int time, int mistakes,
            string category, int level, string word, string currentWordState)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(filename);
            XmlNodeList nodeList = doc.SelectNodes("Games/Game");
            foreach (XmlNode node in nodeList)
            {
                if (node["Username"].InnerText == username)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
            doc.Save(filename);

            XmlNode root = doc.SelectSingleNode("Games");
            XmlElement game = doc.CreateElement("Game");
            root.AppendChild(game);

            XmlElement name = doc.CreateElement("Username");
            name.InnerText = username;
            game.AppendChild(name);

            XmlElement avat = doc.CreateElement("Avatar");
            avat.InnerText = avatar;
            game.AppendChild(avat);

            XmlElement gameId = doc.CreateElement("ID");
            gameId.InnerText = id.ToString();
            game.AppendChild(gameId);

            XmlElement timeLeft = doc.CreateElement("Time");
            timeLeft.InnerText = time.ToString();
            game.AppendChild(timeLeft);

            XmlElement mistakesMade = doc.CreateElement("Mistakes");
            mistakesMade.InnerText = mistakes.ToString();
            game.AppendChild(mistakesMade);

            XmlElement currentCategory = doc.CreateElement("Categories");
            currentCategory.InnerText = category.ToString();
            game.AppendChild(currentCategory);

            XmlElement currentLevel = doc.CreateElement("Level");
            currentLevel.InnerText = level.ToString();
            game.AppendChild(currentLevel);

            XmlElement currentWord = doc.CreateElement("Word");
            currentWord.InnerText = word;
            game.AppendChild(currentWord);

            XmlElement currentState = doc.CreateElement("CurrentWordState");
            currentState.InnerText = currentWordState;
            game.AppendChild(currentState);

            doc.Save(filename);
            MessageBox.Show("The game was saved!");
        }
        public static GameModel LoadGame(string filename, string username)
        {
            GameModel game = new GameModel();
            XDocument doc = XDocument.Load(filename);

            var selectGame = from x in doc.Descendants("Game").Where
                             (x => (string)x.Element("Username") == username)
                             select new
                             {
                                 XMLusername = x.Element("Username").Value,
                                 XMLavatar = x.Element("Avatar").Value,
                                 XMLid = x.Element("ID").Value,
                                 XMLtime = x.Element("Time").Value,
                                 XMLmistakes = x.Element("Mistakes").Value,
                                 XMLcategory = x.Element("Categories").Value,
                                 XMLlevel = x.Element("Level").Value,
                                 XMLword = x.Element("Word").Value,
                                 XMLstate = x.Element("CurrentWordState").Value
                             };

            if (selectGame.Count().Equals(0))
            {
                MessageBox.Show("No saved games for this user!");
            }
            else
            {
                var thisGame = selectGame.First();

                game = new GameModel(thisGame.XMLusername, thisGame.XMLavatar, Convert.ToInt32(thisGame.XMLid),
                    Convert.ToInt32(thisGame.XMLtime), Convert.ToInt32(thisGame.XMLmistakes), thisGame.XMLcategory,
                    Convert.ToInt32(thisGame.XMLlevel), new StringBuilder(thisGame.XMLstate), thisGame.XMLword);
            }

            return game;
        }
        public static bool Register(string filename, string username, string password, string avatar)
        {
            XmlDocument doc = new XmlDocument();


            doc.Load("user.xml");
            XmlNodeList nodeList = doc.SelectNodes("UserModel/Users/User");


            foreach (XmlNode node in nodeList)
            {
                if (node["Username"].InnerText == username)
                {

                    MessageBox.Show("This username already exists!");
                    return false;
                }
            }

            doc.Load(filename);
            XmlNode root = doc.SelectSingleNode("UserModel/Users");
            XmlElement user = doc.CreateElement("User");
            root.AppendChild(user);

            XmlAttribute id = doc.CreateAttribute("id");
            id.Value = doc.SelectNodes("UserModel/Users/User").Count.ToString();
            user.Attributes.Append(id);

            XmlElement name = doc.CreateElement("Username");
            name.InnerText = username;
            user.AppendChild(name);

            XmlElement pass = doc.CreateElement("Password");
            pass.InnerText = password;
            user.AppendChild(pass);

            XmlElement avt = doc.CreateElement("Avatar");
            avt.InnerText = avatar;
            user.AppendChild(avt);

            doc.Save(filename);
            MessageBox.Show("Registration complete!");
            return true;

            return false;
        }
        public static void DeleteAccount(string username)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("user.xml");
            XmlNodeList nodeList = doc.SelectNodes("UserModel/Users/User");
            foreach (XmlNode node in nodeList)
            {
                if (node["Username"].InnerText == username)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
            doc.Save("user.xml");

            doc.Load("SavedGames.xml");
            XmlNodeList nodeList1 = doc.SelectNodes("Games/Game");
            foreach (XmlNode node in nodeList1)
            {
                if (node["Username"].InnerText == username)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
            doc.Save("SavedGames.xml");

            doc.Load("Statistics.xml");
            XmlNodeList nodeList2 = doc.SelectNodes("Statistics/Statistic");
            foreach(XmlNode node in nodeList2)
            {
                if (node["Username"].InnerText == username)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
            doc.Save("Statistics.xml");
        }
        public static bool Login(string username, string password)
        {

            XDocument document = XDocument.Load("user.xml");
            var selectUser = from x in document.Descendants("User").Where
                             (x => (string)x.Element("Username") == username)
                             select new
                             {
                                 XMLid = x.Attribute("id").Value,
                                 XMLuser = x.Element("Username").Value,
                                 XMLpassword = x.Element("Password").Value,
                                 XMLavatar = x.Element("Avatar").Value
                             };

            if (selectUser.Count().Equals(0))
            {
                MessageBox.Show("Username or Password is incorrect!");
            }
            else
            {
                var user = selectUser.First();

                if (username == user.XMLuser)
                {
                    if (password == user.XMLpassword)
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect!");
                        return false;
                    }
                }
            }
            return false;
        }
        public static void UpdateStatistics(string filename, string username, int gamesPlayed, int gamesWon)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(filename);

            XmlNodeList nodeList = doc.SelectNodes("Statistics/Statistic");
            foreach (XmlNode node in nodeList)
            {
                if (node["Username"].InnerText == username)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
            doc.Save(filename);

            XmlNode root = doc.SelectSingleNode("Statistics");
            XmlElement statistic = doc.CreateElement("Statistic");
            root.AppendChild(statistic);

            XmlNode name = doc.CreateElement("Username");
            name.InnerText = username;
            statistic.AppendChild(name);

            XmlNode gmsPlayed = doc.CreateElement("GamesPlayed");
            gmsPlayed.InnerText = gamesPlayed.ToString();
            statistic.AppendChild(gmsPlayed);

            XmlNode gmsWon = doc.CreateElement("GamesWon");
            gmsWon.InnerText = gamesWon.ToString();
            statistic.AppendChild(gmsWon);

            doc.Save(filename);
        }
        public static void GetGames(string username, ref int gamesPlayed, ref int gamesWon)
        {
            XDocument document = XDocument.Load("Statistics.xml");
            var selectUser = from x in document.Descendants("Statistic").Where
                             (x => (string)x.Element("Username") == username)
                             select new
                             {
                                 XMLgamesPlayed = x.Element("GamesPlayed").Value,
                                 XMLgamesWon = x.Element("GamesWon").Value
                             };
            if (selectUser.Count().Equals(0))
            {
                gamesPlayed = 0;
                gamesWon = 0;
            }
            else
            {
                var first = selectUser.First();
                gamesPlayed = Convert.ToInt32(first.XMLgamesPlayed);
                gamesWon = Convert.ToInt32(first.XMLgamesWon);
            }
        }
        public static string GetStatistics()
        {
            XmlDocument doc = new XmlDocument();
            StringBuilder temporary = new StringBuilder();

            doc.Load("Statistics.xml");

            XmlNodeList nodeList = doc.SelectNodes("Statistics/Statistic");
            foreach (XmlNode node in nodeList)
            {
                string ret = "Username: " + node["Username"].InnerText + " Games Played: " + node["GamesPlayed"].InnerText
                    + " Games Won: " + node["GamesWon"].InnerText;
                temporary.AppendLine(ret);
            }

            return temporary.ToString();
        }

    }
}
