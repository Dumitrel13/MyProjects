   M S B A M L   `   `   `  ����B  >Notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NotepadNotepad  5   	       Notepad.FindWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Notepad     5   	     � Title$  
FindWindow��5   	   $	��200��6   $	��400��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� $��Text to find:��6   $
��Left=�6(   $��	24,26,0,0q�6C   $	��Top=�6V   $��26��6n   $��72��6z   �� 5   
   -   5         ��Name$ txtFind��5      $
��Left=�6#   $��
101,30,0,0q�6>   $�� ��6R    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��138��6�   $��18��6�   �� 5   
   -   5         ��Name$ btnFindNext��5      $
��Find��6&   $
��Left=�65   $��
306,28,0,0q�6P   $	��Top=�6d    J� RenderTransformOrigin$ 0.283,-0.559&�6|   $��20��6�   $��55��6�   6�   	� 5   
   -   5         	�Name$	 oUp��5      $��Up��6#   $
��Left=�60   $��
101,92,0,0q�6K   $	��Top=�6_   $��15��6x   $��34��6�   	� 5   
   -   5        $ oDown��5      $
��Down��6%   $
��Left=�64   $��
189,95,0,0q�6O   $	��Top=�6c   $��15��6{   $��50��6�   �� 5   
   -   5         ��Name$ chkMatchCase��5      $��
Match Case��6)   $
��Left=�6>   $��
24,128,0,0q�6Y   $	��Top=�6m   $ -0.275,0.718&�6�   $��15��6�   $��81��6�   �� 5   
   -   5        $ 
txtReplace��5      $
��Left=�6&   $��
101,53,0,0q�6A   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��138��6�   �� 5   
   $��Replace With:��6   $
��Left=�6(   $��	19,48,0,0q�6C   $	��Top=�6V   $ -0.347,-0.961&�6n   $��23��6�   �� 5   
   -   5        $��Replace��5      $
��Left=�6#   $��
306,60,0,0q�6>   $	��Top=�6R   6j   �� 5   
   -   5        $��Replace all��5      $
��Left=�6'   $��
306,95,0,0q�6B   $	��Top=�6V   6n   5      5      