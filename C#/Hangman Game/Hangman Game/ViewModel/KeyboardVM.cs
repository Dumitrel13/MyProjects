using Hangman_Game.Models;
using System.Windows.Input;
using Hangman_Game.Utilities;
using System.Windows;
using System.Text;

namespace Hangman_Game.ViewModel
{
    public class KeyboardVM : ObservableObject
    {
        public KeyboardVM(GameVM gameVM)
        {
            _game = gameVM;
            _Keyboard = new KeyboardModel();
            ACommand = new RelayCommand(AFunction);
            BCommand = new RelayCommand(BFunction);
            CCommand = new RelayCommand(CFunction);
            DCommand = new RelayCommand(DFunction);
            ECommand = new RelayCommand(EFunction);
            FCommand = new RelayCommand(FFunction);
            GCommand = new RelayCommand(GFunction);
            HCommand = new RelayCommand(HFunction);
            ICommand = new RelayCommand(IFunction);
            JCommand = new RelayCommand(JFunction);
            KCommand = new RelayCommand(KFunction);
            LCommand = new RelayCommand(LFunction);
            MCommand = new RelayCommand(MFunction);
            NCommand = new RelayCommand(NFunction);
            OCommand = new RelayCommand(OFunction);
            PCommand = new RelayCommand(PFunction);
            RCommand = new RelayCommand(RFunction);
            QCommand = new RelayCommand(QFunction);
            SCommand = new RelayCommand(SFunction);
            TCommand = new RelayCommand(TFunction);
            WCommand = new RelayCommand(WFunction);
            XCommand = new RelayCommand(XFunction);
            YCommand = new RelayCommand(YFunction);
            ZCommand = new RelayCommand(ZFunction);
            UCommand = new RelayCommand(UFunction);
            VCommand = new RelayCommand(VFunction);
            EmptyCommand = new RelayCommand(EmptyFunction);
        }

        private KeyboardModel _Keyboard;

        private GameVM _game;
        
        public KeyboardModel Keyboard
        {
            get
            {
                return _Keyboard;
            }
        }       

        #region ICommands
        public ICommand ACommand { get; }
        public ICommand BCommand { get; }
        public ICommand CCommand { get; }
        public ICommand DCommand { get; }
        public ICommand ECommand { get; }
        public ICommand FCommand { get; }
        public ICommand GCommand { get; }
        public ICommand HCommand { get; }
        public ICommand ICommand { get; }
        public ICommand JCommand { get; }
        public ICommand KCommand { get; }
        public ICommand LCommand { get; }
        public ICommand MCommand { get; }
        public ICommand NCommand { get; }
        public ICommand OCommand { get; }
        public ICommand PCommand { get; }
        public ICommand RCommand { get; }
        public ICommand QCommand { get; }
        public ICommand SCommand { get; }
        public ICommand TCommand { get; }
        public ICommand WCommand { get; }
        public ICommand XCommand { get; }
        public ICommand YCommand { get; }
        public ICommand ZCommand { get; }
        public ICommand UCommand { get; }
        public ICommand VCommand { get; }
        public ICommand EmptyCommand { get; }
        #endregion

        public void DisableKeyboard()
        {
            Keyboard.AButton.IsEnabled = false;
            Keyboard.BButton.IsEnabled = false;
            Keyboard.CButton.IsEnabled = false;
            Keyboard.DButton.IsEnabled = false;
            Keyboard.EButton.IsEnabled = false;
            Keyboard.FButton.IsEnabled = false;
            Keyboard.GButton.IsEnabled = false;
            Keyboard.HButton.IsEnabled = false;
            Keyboard.IButton.IsEnabled = false;
            Keyboard.JButton.IsEnabled = false;
            Keyboard.KButton.IsEnabled = false;
            Keyboard.LButton.IsEnabled = false;
            Keyboard.MButton.IsEnabled = false;
            Keyboard.NButton.IsEnabled = false;
            Keyboard.OButton.IsEnabled = false;
            Keyboard.PButton.IsEnabled = false;
            Keyboard.RButton.IsEnabled = false;
            Keyboard.QButton.IsEnabled = false;
            Keyboard.SButton.IsEnabled = false;
            Keyboard.TButton.IsEnabled = false;
            Keyboard.WButton.IsEnabled = false;
            Keyboard.XButton.IsEnabled = false;
            Keyboard.YButton.IsEnabled = false;
            Keyboard.ZButton.IsEnabled = false;
            Keyboard.UButton.IsEnabled = false;
            Keyboard.VButton.IsEnabled = false;
        }
        public void EnableKeyboard()
        {
            Keyboard.AButton.IsEnabled = true;
            Keyboard.BButton.IsEnabled = true;
            Keyboard.CButton.IsEnabled = true;
            Keyboard.DButton.IsEnabled = true;
            Keyboard.EButton.IsEnabled = true;
            Keyboard.FButton.IsEnabled = true;
            Keyboard.GButton.IsEnabled = true;
            Keyboard.HButton.IsEnabled = true;
            Keyboard.IButton.IsEnabled = true;
            Keyboard.JButton.IsEnabled = true;
            Keyboard.KButton.IsEnabled = true;
            Keyboard.LButton.IsEnabled = true;
            Keyboard.MButton.IsEnabled = true;
            Keyboard.NButton.IsEnabled = true;
            Keyboard.OButton.IsEnabled = true;
            Keyboard.PButton.IsEnabled = true;
            Keyboard.RButton.IsEnabled = true;
            Keyboard.QButton.IsEnabled = true;
            Keyboard.SButton.IsEnabled = true;
            Keyboard.TButton.IsEnabled = true;
            Keyboard.WButton.IsEnabled = true;
            Keyboard.XButton.IsEnabled = true;
            Keyboard.YButton.IsEnabled = true;
            Keyboard.ZButton.IsEnabled = true;
            Keyboard.UButton.IsEnabled = true;
            Keyboard.VButton.IsEnabled = true;
        }
        public void AFunction()
        {
            _game.ReplaceLetter('A');
            Keyboard.AButton.IsEnabled = false;
        }
        public void BFunction()
        {
            _game.ReplaceLetter('B');
            Keyboard.BButton.IsEnabled = false;
        }
        public void CFunction()
        {
            _game.ReplaceLetter('C');
            Keyboard.CButton.IsEnabled = false;
        }
        public void DFunction()
        {
            _game.ReplaceLetter('D');
            Keyboard.DButton.IsEnabled = false;
        }
        public void EFunction()
        {
            _game.ReplaceLetter('E');
            Keyboard.EButton.IsEnabled = false;
        }
        public void FFunction()
        {
            _game.ReplaceLetter('F');
            Keyboard.FButton.IsEnabled = false;
        }
        public void GFunction()
        {
            _game.ReplaceLetter('G');
            Keyboard.GButton.IsEnabled = false;
        }
        public void HFunction()
        {
            _game.ReplaceLetter('H');
            Keyboard.HButton.IsEnabled = false;
        }
        public void IFunction()
        {
            _game.ReplaceLetter('I');
            Keyboard.IButton.IsEnabled = false;
        }
        public void JFunction()
        {
            _game.ReplaceLetter('J');
            Keyboard.JButton.IsEnabled = false;
        }
        public void KFunction()
        {
            _game.ReplaceLetter('K');
            Keyboard.KButton.IsEnabled = false;
        }
        public void LFunction()
        {
            _game.ReplaceLetter('L');
            Keyboard.LButton.IsEnabled = false;
        }
        public void MFunction()
        {
            _game.ReplaceLetter('M');
            Keyboard.MButton.IsEnabled = false;
        }
        public void NFunction()
        {
            _game.ReplaceLetter('N');
            Keyboard.NButton.IsEnabled = false;
        }
        public void OFunction()
        {
            _game.ReplaceLetter('O');
            Keyboard.OButton.IsEnabled = false;
        }
        public void PFunction()
        {
            _game.ReplaceLetter('P');
            Keyboard.PButton.IsEnabled = false;
        }
        public void RFunction()
        {
            _game.ReplaceLetter('R');
            Keyboard.RButton.IsEnabled = false;
        }
        public void QFunction()
        {
            _game.ReplaceLetter('Q');
            Keyboard.QButton.IsEnabled = false;
        }
        public void SFunction()
        {
            _game.ReplaceLetter('S');
            Keyboard.SButton.IsEnabled = false;
        }
        public void TFunction()
        {
            _game.ReplaceLetter('T');
            Keyboard.TButton.IsEnabled = false;
        }
        public void WFunction()
        {
            _game.ReplaceLetter('W');
            Keyboard.WButton.IsEnabled = false;
        }
        public void XFunction()
        {
            _game.ReplaceLetter('X');
            Keyboard.XButton.IsEnabled = false;
        }
        public void YFunction()
        {
            _game.ReplaceLetter('Y');
            Keyboard.YButton.IsEnabled = false;
        }
        public void ZFunction()
        {
            _game.ReplaceLetter('Z');
            Keyboard.ZButton.IsEnabled = false;
        }
        public void UFunction()
        {
            _game.ReplaceLetter('U');
            Keyboard.UButton.IsEnabled = false;
        }
        public void VFunction()
        {
            _game.ReplaceLetter('V');
            Keyboard.VButton.IsEnabled = false;
        }
        public void EmptyFunction()
        {
            _game.ReplaceLetter(' ');
        }
    }
}
