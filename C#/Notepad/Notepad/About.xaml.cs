using Notepad.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notepad
{
    public partial class About : Window
    {
        private HiperlinkUtilities hiperlinkUtilities = new HiperlinkUtilities();
        public About()
        {
            InitializeComponent();
        }
        
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            hiperlinkUtilities.OpenUrl(e.Uri.AbsoluteUri);

            //e.Handled = true;
        }
    }
}
