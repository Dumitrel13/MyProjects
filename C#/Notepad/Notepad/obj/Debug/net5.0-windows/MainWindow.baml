   M S B A M L   `   `   `  ����B  >Notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NotepadNotepad  5   	   7 clr-namespace:Notepad.ViewModelsNotepad.ViewModels  5   	       Notepad.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Notepad     5   	   7
viewmodels clr-namespace:Notepad.ViewModels     5   	     � Title$  Notepad��5	   	   $	��450��6   $	��800��6&    � DataContext 5
      &    Notepad.ViewModels.MainViewModel  5   
   .��5      ]� $��1q�6   .+�5   
   o� $	��Top=�6   @�5      m� 5      $
��File��6    6)   �� *File+.@�5      m� $	��New��6    m� Command 6,   �� *
NewCommand+m� 5      $
��Open��6    6-   �� *OpenCommand+m� 5      $
��Save��6    6-   �� *SaveCommand+m� 5      $��
Save as...��6    63   �� *SaveAsCommand+m� 5      $��View Directories��6    69   �� *ViewCommand+m� 5      $
��Exit��6    6-   �� *ExitCommand+5      m� 5      $��Format��6    6+   �� *Editor+.@�5      m� $��Format��6    6/   �� *FormatCommand+5      m� 5      $��Search��6    6+   �� *Search+.@�5      m� $
��Find��6    6-   �� *FindCommand+m� 5       $��
Replace...��6    63   �� *ReplaceCommand+m� 5!      $��Replace all...��6    67   �� *ReplaceAllCommand+5"      m� 5$      $
��Help��6    6)   �� *Help+.@�5%      m� $��About��6    6.   �� *HelpCommand+5&      5*      ]� 5,   
   .+�5-      �� $��Bottom=�6    5.      �� *File.Document+��5/      �� *
FilePath+�� 51      -   5         ��Name$ txtArea��51      $	��Top=�6'   " �� VerticalScrollBarVisibility$ Visible=�52       �� AcceptsReturn$
 True��59       �� 
AcceptsTab$
 True��5:       53      �� *Editor+��54      �� *Format.Family+��55      �� *Format.Size+��56      �� *Format.Style+��57      �� *Format.Weight+ �� TextWrapping 58      �� *Format.Wrap+��5;      �� *Document.Text+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�5=      5>      5?      