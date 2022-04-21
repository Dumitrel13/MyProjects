using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Notepad.Model
{
    public class FormatModel : ObservableObject
    {
        private FontStyle _style;
        
        public FontStyle Style
        {
            get { return _style; }
            set { OnPropertyChanged(ref _style, value); }
        }

        public FontWeight _weight;

        public FontWeight Weight
        {
            get { return _weight; }
            set { OnPropertyChanged(ref _weight, value); }
        }

        public FontFamily _family;

        public FontFamily Family
        {
            get { return _family; }
            set { OnPropertyChanged(ref _family, value); }
        }

        public TextWrapping _wrap;

        public TextWrapping Wrap
        {
            get { return _wrap; }
            set
            {
                OnPropertyChanged(ref _wrap, value);
                isWraped = value == TextWrapping.Wrap ? true : false;
            }
        }

        private bool _isWraped;

        public bool isWraped
        {
            get { return _isWraped; }
            set { OnPropertyChanged(ref _isWraped, value); }
            
        }

        private double _size;

        public double Size
        {
            get { return _size; }
            set { OnPropertyChanged(ref _size, value); }
        }
    }
}
