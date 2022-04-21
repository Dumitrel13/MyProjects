using Hangman_Game.Utilities;
using Hangman_Game.ViewModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;

namespace Hangman_Game
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();

        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            XMLHandler xml = new XMLHandler();
            if (XMLHandler.Login(txtUsername.Text, txtPassword.Password) == true)
            {
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();

            registerScreen.Show();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSubmit_Click(null, null);
            }
        }
    }
}
