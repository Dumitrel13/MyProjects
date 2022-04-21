using Notepad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class SearchViewModel
    {
        public ICommand FindCommand { get; }
        public ICommand ReplaceCommand { get; }
        public ICommand ReplaceAllCommand { get; }

        //public DocumentModel Document { get; set; }
        public SearchViewModel(DocumentModel document)
        {
            //Document = document;
            FindCommand = new RelayCommand(FindText);
            ReplaceCommand = new RelayCommand(ReplaceText);
            ReplaceAllCommand = new RelayCommand(ReplaceAllText);
        }

        public void FindText()
        {
            var findWindow = new FindWindow();

            findWindow.ShowDialog();
        }

        public void ReplaceText()
        {
            var findWindow = new FindWindow();

            findWindow.ShowDialog();
        }

        public void ReplaceAllText()
        {
            var findWindow = new FindWindow();

            findWindow.ShowDialog();
        }
    }
}
