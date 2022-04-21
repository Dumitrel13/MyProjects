using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notepad.Utilities
{
    class SearchUtilities
    {
        private MainWindow hWin => (MainWindow)Application.Current.MainWindow;

        public bool FindAndSelect(string TextToFind, bool MatchCase)
        {
            var mode = MatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

            int position = hWin.txtArea.Text.IndexOf(TextToFind, mode);

            if (position == -1)
                return false;

            hWin.txtArea.SelectionStart = position;
            hWin.txtArea.SelectionLength = TextToFind.Length;

            return true;
        }

        public bool ReplaceText(string TextToFind, string NewText)
        {
            //var mode = MatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

            int position = hWin.txtArea.Text.IndexOf(TextToFind);

            if (position == -1)
                return false;

            hWin.txtArea.SelectionStart = position;
            hWin.txtArea.SelectionLength = TextToFind.Length;

            StringBuilder ret = new StringBuilder(hWin.txtArea.Text);
            ret.Remove(hWin.txtArea.SelectionStart, hWin.txtArea.SelectionLength);
            ret.Insert(hWin.txtArea.SelectionStart, NewText);
            
            hWin.txtArea.Text = ret.ToString();
            return true;
        }
        public bool ReplaceAllText(string TextToReplace, string NewText)
        {
   

            int position = hWin.txtArea.Text.IndexOf(TextToReplace);

            if (position == -1)
                return false;

            

            string ret = hWin.txtArea.Text.Replace(TextToReplace, NewText);
            hWin.txtArea.Text = ret;
            
            return true;
        }
    }
}
