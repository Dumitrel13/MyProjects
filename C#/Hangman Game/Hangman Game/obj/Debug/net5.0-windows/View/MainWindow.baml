   M S B A M L   `   `   `  ����G  CHangman Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Hangman_GameHangman_Game  5   	   ?$clr-namespace:Hangman_Game.ViewModelHangman_Game.ViewModel  5   	   9!clr-namespace:Hangman_Game.ModelsHangman_Game.Models  5   	       Hangman_Game.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Hangman_Game     5   	   ;
viewmodels$clr-namespace:Hangman_Game.ViewModel     5   	   4models!clr-namespace:Hangman_Game.Models     5   	     � Title$  Hangman Game��5
   	   $	��450��6   $	��800��6+   ���#2F4454 � DataContext 5      #   Hangman_Game.ViewModel.GameVM  5   
   .��5      � $��2,0,-2,0q�6   .+�5   
   �� $��A��6   ���#FFCB9A$
��Left=�6�   $��230,333,0,0q�6�   $	��Top=�6�   $��30��6�   $��29��6�    J� RenderTransformOrigin$ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.ACommand+{�6E   �� *'%KeyboardVM.Keyboard.AButton.IsEnabled+6�   �� 5   
   $��Z��6   ���#FFCB9A$
��Left=�6�   $��245,372,0,0q�6�   $	��Top=�6�   $��31��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.ZCommand+{�6E   �� *'%KeyboardVM.Keyboard.ZButton.IsEnabled+6�   �� 5   
   $��Q��6   ���#FFCB9A$
��Left=�6�   $��214,290,0,0q�6�   $	��Top=�6�   $��31��6�   $��28��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.QCommand+{�6E   �� *'%KeyboardVM.Keyboard.QButton.IsEnabled+6�   �� 5   
   $��W��6   ���#FFCB9A$
��Left=�6�   $��260,290,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.WCommand+{�6E   �� *'%KeyboardVM.Keyboard.WButton.IsEnabled+6�   �� 5   
   $��S��6   ���#FFCB9A$
��Left=�6�   $��276,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.SCommand+{�6E   �� *'%KeyboardVM.Keyboard.SButton.IsEnabled+6�   �� 5   
   $��X��6   ���#FFCB9A$
��Left=�6�   $��292,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.XCommand+{�6E   �� *'%KeyboardVM.Keyboard.XButton.IsEnabled+6�   �� 5   
   $��E��6   ���#FFCB9A$
��Left=�6�   $��308,290,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.ECommand+{�6E   �� *'%KeyboardVM.Keyboard.EButton.IsEnabled+6�   �� 5   
   $��D��6   ���#FFCB9A$
��Left=�6�   $��324,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.DCommand+{�6E   �� *'%KeyboardVM.Keyboard.DButton.IsEnabled+6�   �� 5   
   $��C��6   ���#FFCB9A$
��Left=�6�   $��340,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.CCommand+{�6E   �� *'%KeyboardVM.Keyboard.CButton.IsEnabled+6�   �� 5   
   $��R��6   ���#FFCB9A$
��Left=�6�   $��356,290,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.RCommand+{�6E   �� *'%KeyboardVM.Keyboard.RButton.IsEnabled+6�   �� 5   
   $��V��6   ���#FFCB9A$
��Left=�6�   $��389,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.VCommand+{�6E   �� *'%KeyboardVM.Keyboard.VButton.IsEnabled+6�   �� 5   
   $��F��6   ���#FFCB9A$
��Left=�6�   $��368,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.FCommand+{�6E   �� *'%KeyboardVM.Keyboard.FButton.IsEnabled+6�   �� 5   
   $��T��6   ���#FFCB9A$
��Left=�6�   $��400,289,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.TCommand+{�6E   �� *'%KeyboardVM.Keyboard.TButton.IsEnabled+6�   �� 5   
   $��G��6   ���#FFCB9A$
��Left=�6�   $��416,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.GCommand+{�6E   �� *'%KeyboardVM.Keyboard.GButton.IsEnabled+6�   �� 5   
   $��B��6   ���#FFCB9A$
��Left=�6�   $��432,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.BCommand+{�6E   �� *'%KeyboardVM.Keyboard.BButton.IsEnabled+6�   �� 5    
   $��Y��6   ���#FFCB9A$
��Left=�6�   $��448,289,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.YCommand+{�6E   �� *'%KeyboardVM.Keyboard.YButton.IsEnabled+6�   �� 5!   
   $��H��6   ���#FFCB9A$
��Left=�6�   $��464,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.HCommand+{�6E   �� *'%KeyboardVM.Keyboard.HButton.IsEnabled+6�   �� 5"   
   $��N��6   ���#FFCB9A$
��Left=�6�   $��480,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.NCommand+{�6E   �� *'%KeyboardVM.Keyboard.NButton.IsEnabled+6�   �� 5#   
   $��U��6   ���#FFCB9A$
��Left=�6�   $��496,289,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.UCommand+{�6E   �� *'%KeyboardVM.Keyboard.UButton.IsEnabled+6�   �� 5$   
   $��J��6   ���#FFCB9A$
��Left=�6�   $��512,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.JCommand+{�6E   �� *'%KeyboardVM.Keyboard.JButton.IsEnabled+6�   �� 5%   
   $��M��6   ���#FFCB9A$
��Left=�6�   $��528,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.MCommand+{�6E   �� *'%KeyboardVM.Keyboard.MButton.IsEnabled+6�   �� 5&   
   $��I��6   ���#FFCB9A$
��Left=�6�   $��544,290,0,0q�6�   $	��Top=�6�   $��32��6�   $��28��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.ICommand+{�6E   �� *'%KeyboardVM.Keyboard.IButton.IsEnabled+6�   �� 5'   
   $��K��6   ���#FFCB9A$
��Left=�6�   $��560,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.KCommand+{�6E   �� *'%KeyboardVM.Keyboard.KButton.IsEnabled+6�   �� 5(   
   $��L��6   ���#FFCB9A$
��Left=�6�   $��576,372,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.LCommand+{�6E   �� *'%KeyboardVM.Keyboard.LButton.IsEnabled+6�   �� 5)   
   $��O��6   ���#FFCB9A$
��Left=�6�   $��592,290,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.OCommand+{�6E   �� *'%KeyboardVM.Keyboard.OButton.IsEnabled+6�   �� 5*   
   $��P��6   ���#FFCB9A$
��Left=�6�   $��608,333,0,0q�6�   $	��Top=�6�   $��32��6�   $��29��6�   $ 
0.16,0.002&�6�   ��6   �� *KeyboardVM.PCommand+{�6E   �� *'%KeyboardVM.Keyboard.PButton.IsEnabled+6�   o� 5-   
   $	��Top=�6   ���#FFCB9A.@�5.      m� $
��File��6   .@�5/      m� $��New Game��6    m� Command 6-   �� *NewGameCommand+m� 50      $��	Open Game��6    6.   �� *LoadGameCommand+m� 51      $��	Save Game��6    6.   �� *SaveGameCommand+m� 52      $��Delete Account��6    63   �� *DeleteAccountCommand+m� 53      $��
Statistics��6    6/   �� *StatisticsCommand+m� 54      $
��Exit��6    6)   �� *ExitCommand+55      m� 56      $��
Categories��6   ��6+   �� *
Categories+ �� UpdateSourceTrigger$ PropertyChanged=���57      �� 58      .R�59      m�  m� IsCheckable$
 True��6;   ��6#   �� *Name+ m� 	IsChecked 6N   �� *	IsChecked+5:      5<      m� 5=      $
��Help��6    6%   �� *AboutCommand+5>      �� 5@   
   -   5         ��Name$ 	imageMiss��5@      $	��Top=�6g   $
��Left=�6   $��	10,72,0,0q�5A      $	��211��6#   $	��125��60   ��5@   #   �� *ImageSource+$ PropertyChanged=�5A   0   �� 5C   
   $��30(�5D      $��Center=�6   $��Center=�69   ��5C      �� *Game.CurrentWordState+$ PropertyChanged=�5D   9   �� 5F   
   $��	Mistakes:��6   $��25(�6$   $��Bottom=�62   $
��Left=�6M   $ 0.469,0.182&�6h   $��0,0,0,10q�6�   �� 5H   
   $��25(�6R   $��Bottom=�6`   $
��Left=�5I      $��38��6+   $��47��67   $��
117,0,0,13q�6B   ��5H      �� *
Mistakes+$ PropertyChanged=�5I   B   �� 5K   
   $��Current Level:��6   $��20(�6)   $	��Top=�67   $
��Left=�6O   $��
276,24,0,0q�6j   �� 5M   
   $��20(�6O   $	��Top=�6]   $
��Left=�5N      $ 	0.6,1.464&�6+   $��
416,23,0,0q�6M   $��35��6a   $��48��6m   ��5M      �� *Level+$ PropertyChanged=�5N   m   �� 5P   
   $��
Next Level��6   $��15(�6K   $��Bottom=�6Y   $��Right=�6t   $��	0,0,36,77q�5Q      $��25��6$   $��80��60   ��5P   &   �� *NextLevelCommand+��5R      �� 5S       �� 
TargetType" ��6   .�5T      �� 	 �� Property	 � y�
 �� Value$
 	Collapsed=�63    �� Triggers 5U      �� 5V       �� Binding 6&   �� *	Visible+ �� Value True6B   .a�5W      �� 	 � y�$
 Visible=�6;   5X      5Z      5\      �� 5^   
   $��Time Left: ��6   $	��Top=�6&   $��Right=�6>   $��20(�6Z   $��	0,24,56,0q�6h   �� 5_   
   $��20(�6V   $	��Top=�6d   $��Right=�6|   $��	0,24,10,0q�6�   $��34��6�   $��41��6�   ��6   �� *TimerContent+$ PropertyChanged=�6�   �� 5`   
   $��15(�6.   $
��Left=�6<   $��	10,29,0,0q�6W   $	��Top=�6j   ��6   �� *	Game.Name+6j   �� 5a   
   $
��Left=�6U   $��39��6p   $��	56,24,0,0q�6|   $	��Top=�6�   $��48��6�   ��6   �� *AvatarSource+$ PropertyChanged=�6�   5b      5c      