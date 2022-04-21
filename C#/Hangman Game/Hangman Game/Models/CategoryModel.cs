using Hangman_Game.Utilities;
using System.Collections.Generic;

namespace Hangman_Game.Models
{
    public class CategoryModel : ObservableObject
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                OnPropertyChanged(ref _name, value);
            }
        }

        private List<string> _words;

        public List<string> Words
        {
            get => _words;
            set => OnPropertyChanged(ref _words, value);
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                OnPropertyChanged(ref _isChecked, value);
            }
        }

        public CategoryModel()
        {
            Name = "";
            IsChecked = false;
        }

        public CategoryModel(string name)
        {
            Name = name;
            Words = new List<string>();
            IsChecked = false;
        }
    }
}
