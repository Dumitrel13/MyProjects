using Microsoft.Win32;
using Notepad.Model;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class FileViewModel
    {
        private MainWindow hWin => (MainWindow)Application.Current.MainWindow;
        public DocumentModel Document { get; private set; }
        public ICommand NewCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand ViewCommand { get; }
        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);
            ExitCommand = new RelayCommand(Exit);
            ViewCommand = new RelayCommand(ViewDirectories);
        }

        public void NewFile()
        {
            //Document.FileName = string.Empty;
            //Document.FilePath = string.Empty;
            //Document.Text = string.Empty;

            var mainWindow = new MainWindow();
            mainWindow.Title = "File";
            mainWindow.Show();
        }

        private void SaveFile()
        {
            string message = "Fisierul nu a fost salvat!";
            string title = "Warning";

            if (Document.FilePath == null)
            {
                MessageBox.Show(message, title);
            }
            else
            {
                File.WriteAllText(Document.FilePath, Document.Text);
            }
        }

        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName);
            }
            //numele fis deschis
            string ret = openFileDialog.FileName;
            int poz = 0;
            for (int i = 0; i < ret.Length; i++)
            {
                if(ret[i] == '\\')
                {
                    poz = i; 
                }
            }
            StringBuilder stringBuilder = new StringBuilder(ret);
            stringBuilder.Remove(0, poz + 1);
            hWin.Title = stringBuilder.ToString();
        }

        private void ViewDirectories()
        {
            var viewDirectories = new ViewDirectories();

            viewDirectories.Show();
        }
        private void Exit()
        {
            if (Document.FilePath == null)
            {
                if (MessageBox.Show("Documentul nu este salvat! Doriti sa iesiti?", "Exit", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {

                    System.Environment.Exit(0);

                }
            }
            else
            {
                File.WriteAllText(Document.FilePath, Document.Text);
                System.Environment.Exit(0);
            }
                
        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }
    }
}
