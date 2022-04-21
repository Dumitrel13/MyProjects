using Hangman_Game.Models;
using Hangman_Game.Utilities;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Hangman_Game
{
    public partial class RegisterScreen : Window
    {
        private int index = 0;
        private int numberOfImages = 4;
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            index--;

            if (index < 1)
            {
                index = numberOfImages;
            }

            picHolder.Source = new BitmapImage(new Uri(@"../images/" + index + ".png",
                UriKind.Relative));
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            index++;

            if (index > numberOfImages)
            {
                index = 0;
            }

            picHolder.Source = new BitmapImage(new Uri(@"../images/" + index + ".png",
                UriKind.Relative));
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                    if (XMLHandler.Register("user.xml", txtUsername.Text, txtPassword.Text, picHolder.Source.ToString().Remove(0, 53)))
                        this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
