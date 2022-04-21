using Notepad.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for ViewDirectories.xaml
    /// </summary>
    public partial class ViewDirectories : Window
    {
        private ViewDirUtilities viewDirUtilities = new ViewDirUtilities();
        public ViewDirectories()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem()
                {
                    Header = drive,
                    Tag = drive

                };

                item.Items.Add(null);

                item.Expanded += Folder_Expanded;

                treeView1.Items.Add(item);

            }
        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;

            if (item.Items.Count != 1 && item.Items[0] != null)
                return;

            item.Items.Clear();

            var fullPath = (string)item.Tag;

            #region Get Directories
            var directories = new List<string>();
            try
            {
                var dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                    directories.AddRange(dirs);
            }
            catch { }

            directories.ForEach(directoryPath =>
            {
                var subItem = new TreeViewItem()
                {
                    Header = ViewDirUtilities.GetFileFolderName(directoryPath),
                    Tag = directoryPath
                };

                subItem.Items.Add(null);

                subItem.Expanded += Folder_Expanded;

                item.Items.Add(subItem);
            });
            #endregion

            #region Get Files
            var files = new List<string>();
            try
            {
                var fs = Directory.GetFiles(fullPath);

                if (fs.Length > 0)
                    files.AddRange(fs);
            }
            catch { }

            files.ForEach(filePath =>
            {
                var subItem = new TreeViewItem()
                {
                    Header = ViewDirUtilities.GetFileFolderName(filePath),
                    Tag = filePath
                };

                item.Items.Add(subItem);
            });
            #endregion
        }

        void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("merge");
            try
            {
                // Look for a file extension.
                if (e.Node.Text.Contains("."))
                    System.Diagnostics.Process.Start(@"c:\" + e.Node.Text);
            }
            // If the file is not found, handle the exception and inform the user.
            catch (System.ComponentModel.Win32Exception)
            {
                System.Windows.MessageBox.Show("File not found.");
            }
        }


    }
}
