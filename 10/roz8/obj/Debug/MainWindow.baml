   M S B A M L   `   `   `  ����?  ;roz8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:roz8roz8  5   	       roz8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:roz8     5   	     � Title$  Prosta przeglądarka www��5   	   $	��550��6)   $	��750��66   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   o� $��0��6   $��0��6   .@�5      m� $
��Plik��6   .@�5      m� -   5        $��Zapisz jako��5      60   m� 5      -   5        $��Drukuj��5      6+   �� 5      m� 5      -   5        $��Wyjście��5      6,   5      m� 5      $��
Narzędzia��6   .@�5      m� -   5        $��Ramka��5       m� 	IsChecked .  m� IsCheckable . 6f   �� 5      m� 5      -   5        $��
Ustawienia��5      6/   m� 5      $��Rozmiar��6   .@�5      m� -   5        $��
Zwiększ +��5      62   m� 5      -   5        $��
Zmniejsz -��5      63   5      �� 5       m� 5!      -   5        $��O programie��5!       � ToolTip$ Informacje o programie��5"   P   5#      5$      5%      ]� 5'   
   $��1��6   $��0��6!   .+�5(      c� $	��Top=�6   .@�5)      �� -	   5         ��Name$ 	btnWstecz��5)      $��Wstecz��6,   $��25��6=   
����İ�$
��Left=�6e   $	��Top=�6�   $��55��6�   6�   �� 5*      -
   5        $ btnDalej��5*      $��Dalej��6+   $��25��6;   
����İ�$
��Left=�6c   $	��Top=�6~   $��55��6�   6�   �� 5+      �� 5,      -   5         ��Name$ txtAdres��5,      $
��Left=�6,   $��25��6G    �� TextWrapping$
 Wrap=�6S   $��http://��6g   $	��Top=�6�   $	��400��6�   .��6�   	 � ContextMenu	 5-      �� 5.      .@�5/      m� 
 m� Command$
 ApplicationCommands.Cut��6'   m� 50      $
 ApplicationCommands.Copy��6'   m� 51      $
 ApplicationCommands.Paste��6'   �� 52      m� 53      $��Dodaj do ulubionych��6'   .@�54   "   m� -   5        $��
Do folderu��54   +   6?   m� 55   "   -   5        $��Do paska ulubionych��55   +   6H   56      57      .��58   +   59      �� 5:      -   5        $ btnWejdz��5:      $��Wejdź��6+   $��25��6;   
����İ�$
��Left=�6c   $	��Top=�6~   $��50��6�   6�   5;      �� 5<      -   5         ��Name$ brdRamka��5<      $��3q�6'   
����� �._�5=      (  "System.Windows.Controls.WebBrowser  -   5          Name$ wbPrzegladarka��5=      $	��Top=�6\   $
��Left=�6�   5>      5?      5@      5A      