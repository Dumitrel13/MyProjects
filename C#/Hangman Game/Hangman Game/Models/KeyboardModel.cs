using Hangman_Game.Utilities;

namespace Hangman_Game.Models
{
    public class KeyboardModel : ObservableObject
    {
        #region ButtonModels
        private ButtonModel _aButton;
        private ButtonModel _bButton;
        private ButtonModel _cButton;
        private ButtonModel _dButton;
        private ButtonModel _eButton;
        private ButtonModel _fButton;
        private ButtonModel _gButton;
        private ButtonModel _hButton;
        private ButtonModel _iButton;
        private ButtonModel _jButton;
        private ButtonModel _kButton;
        private ButtonModel _lButton;
        private ButtonModel _mButton;
        private ButtonModel _nButton;
        private ButtonModel _oButton;
        private ButtonModel _pButton;
        private ButtonModel _rButton;
        private ButtonModel _qButton;
        private ButtonModel _sButton;
        private ButtonModel _tButton;
        private ButtonModel _wButton;
        private ButtonModel _xButton;
        private ButtonModel _yButton;
        private ButtonModel _zButton;
        private ButtonModel _uButton;
        private ButtonModel _vButton;
        private ButtonModel _emptyButton;
        #endregion

        public KeyboardModel()
        {
            _aButton = new ButtonModel();
            _bButton = new ButtonModel();
            _cButton = new ButtonModel();
            _dButton = new ButtonModel();
            _eButton = new ButtonModel();
            _fButton = new ButtonModel();
            _gButton = new ButtonModel();
            _hButton = new ButtonModel();
            _iButton = new ButtonModel();
            _jButton = new ButtonModel();
            _kButton = new ButtonModel();
            _lButton = new ButtonModel();
            _mButton = new ButtonModel();
            _nButton = new ButtonModel();
            _oButton = new ButtonModel();
            _pButton = new ButtonModel();
            _rButton = new ButtonModel();
            _qButton = new ButtonModel();
            _sButton = new ButtonModel();
            _tButton = new ButtonModel();
            _wButton = new ButtonModel();
            _xButton = new ButtonModel();
            _yButton = new ButtonModel();
            _zButton = new ButtonModel();
            _uButton = new ButtonModel();
            _vButton = new ButtonModel();
            _emptyButton = new ButtonModel();
        }
        public ButtonModel AButton
        {
            get
            {
                return _aButton;
            }
            set
            {
                OnPropertyChanged(ref _aButton, value);
            }
        }
        public ButtonModel BButton
        {
            get
            {
                return _bButton;
            }
            set
            {
                OnPropertyChanged(ref _bButton, value);
            }
        }
        public ButtonModel CButton
        {
            get
            {
                return _cButton;
            }
            set
            {
                OnPropertyChanged(ref _cButton, value);
            }
        }
        public ButtonModel DButton
        {
            get
            {
                return _dButton;
            }
            set
            {
                OnPropertyChanged(ref _dButton, value);
            }
        }
        public ButtonModel EButton
        {
            get
            {
                return _eButton;
            }
            set
            {
                OnPropertyChanged(ref _eButton, value);
            }
        }
        public ButtonModel FButton
        {
            get
            {
                return _fButton;
            }
            set
            {
                OnPropertyChanged(ref _fButton, value);
            }
        }
        public ButtonModel GButton
        {
            get
            {
                return _gButton;
            }
            set
            {
                OnPropertyChanged(ref _gButton, value);
            }
        }
        public ButtonModel HButton
        {
            get
            {
                return _hButton;
            }
            set
            {
                OnPropertyChanged(ref _hButton, value);
            }
        }
        public ButtonModel IButton
        {
            get
            {
                return _iButton;
            }
            set
            {
                OnPropertyChanged(ref _iButton, value);
            }
        }
        public ButtonModel JButton
        {
            get
            {
                return _jButton;
            }
            set
            {
                OnPropertyChanged(ref _jButton, value);
            }
        }
        public ButtonModel KButton
        {
            get
            {
                return _kButton;
            }
            set
            {
                OnPropertyChanged(ref _kButton, value);
            }
        }
        public ButtonModel LButton
        {
            get
            {
                return _lButton;
            }
            set
            {
                OnPropertyChanged(ref _lButton, value);
            }
        }
        public ButtonModel MButton
        {
            get
            {
                return _mButton;
            }
            set
            {
                OnPropertyChanged(ref _mButton, value);
            }
        }
        public ButtonModel NButton
        {
            get
            {
                return _nButton;
            }
            set
            {
                OnPropertyChanged(ref _nButton, value);
            }
        }
        public ButtonModel OButton
        {
            get
            {
                return _oButton;
            }
            set
            {
                OnPropertyChanged(ref _oButton, value);
            }
        }
        public ButtonModel PButton
        {
            get
            {
                return _pButton;
            }
            set
            {
                OnPropertyChanged(ref _pButton, value);
            }
        }
        public ButtonModel RButton
        {
            get
            {
                return _rButton;
            }
            set
            {
                OnPropertyChanged(ref _rButton, value);
            }
        }
        public ButtonModel QButton
        {
            get
            {
                return _qButton;
            }
            set
            {
                OnPropertyChanged(ref _qButton, value);
            }
        }
        public ButtonModel SButton
        {
            get
            {
                return _sButton;
            }
            set
            {
                OnPropertyChanged(ref _sButton, value);
            }
        }
        public ButtonModel TButton
        {
            get
            {
                return _tButton;
            }
            set
            {
                OnPropertyChanged(ref _tButton, value);
            }
        }
        public ButtonModel WButton
        {
            get
            {
                return _wButton;
            }
            set
            {
                OnPropertyChanged(ref _wButton, value);
            }
        }
        public ButtonModel XButton
        {
            get
            {
                return _xButton;
            }
            set
            {
                OnPropertyChanged(ref _xButton, value);
            }
        }
        public ButtonModel YButton
        {
            get
            {
                return _yButton;
            }
            set
            {
                OnPropertyChanged(ref _yButton, value);
            }
        }
        public ButtonModel ZButton
        {
            get
            {
                return _zButton;
            }
            set
            {
                OnPropertyChanged(ref _zButton, value);
            }
        }
        public ButtonModel UButton
        {
            get
            {
                return _uButton;
            }
            set
            {
                OnPropertyChanged(ref _uButton, value);
            }
        }
        public ButtonModel VButton
        {
            get
            {
                return _vButton;
            }
            set
            {
                OnPropertyChanged(ref _vButton, value);
            }
        }
        public ButtonModel EmptyButton
        {
            get
            {
                return _emptyButton;
            }
            set
            {
                OnPropertyChanged(ref _emptyButton, value);
            }
        }

    }
}
