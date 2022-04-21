using Notepad.Utilities;
using Notepad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notepad
{

    public partial class FindWindow : Window
    {
        private SearchUtilities searchUtilities = new SearchUtilities();
        
        public FindWindow()
        {
            InitializeComponent();
        }

        private void btnFindNext_Click(object sender, RoutedEventArgs e)
        {
            searchUtilities.FindAndSelect(txtFind.Text, chkMatchCase.IsEnabled);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            searchUtilities.ReplaceText(txtFind.Text, txtReplace.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            searchUtilities.ReplaceAllText(txtFind.Text, txtReplace.Text);
        }
    }
}
