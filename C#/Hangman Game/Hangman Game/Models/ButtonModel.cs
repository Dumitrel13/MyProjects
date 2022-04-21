using Hangman_Game.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class ButtonModel : ObservableObject
    {
        private char _text;

        public char Text
        {
            get
            {
                return _text;
            }
            set
            {
                OnPropertyChanged(ref _text, value);
            }
        }

        private bool _isEnabled;

        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {  
                OnPropertyChanged(ref _isEnabled, value);
            }
        }
        
        public ButtonModel()
        {
            Text = ' ';
            IsEnabled = true;
        }

        
    }
}
