   M S B A M L   `   `   `  ����@  <todoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:todootodoo  5   	       todoo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:todoo     5   	   -   5          �Name$  MainWindow2��5   	    � Title$ 
MainWindow��5	   	   $	��283��6   $	��547��6)   .��5
      � -   5         �Name$ MainWindowwww��5
       � ColumnDefinitions 5   
   �� 5      $	��19* �6   �� 5      $	��21* �6   .+�5   
   �� -   5         ��Name$ Login��5   g   $��Вход��6   $
��Left=�6    $��
20,104,0,0q�6;   $	��Top=�6O   ���	#FF498C51$��40��6�   $	��114��6�   $��1��6�   �� 5   
   -   5         ��Name$ EnterPassword��5   ~   $
��Left=�6   $��130,144,0,0q�6/   $
��Wrap=�6D   $��Пароль��6X   $	��Top=�6f   $��16(�6�   �� 5   
   -   5        $ 	EnterMail��5   |   $
��Left=�6   $��
129,85,0,0q�6/   $
��Wrap=�6C   $��
Почта��6W   $	��Top=�6d   $��16(�6�   �� 5   
   -   5        $ Welcome��5   �   $
��Left=�6   $��
129,42,0,0q�6/   $
��Wrap=�6C   $%��Добро Пожаловать��6W   $	��Top=�6o   $��22(�6�   $��2��6�   
���   �6�   �� 5   
   -   5        $ Register��5   n   $��Регистрация��6   $
��Left=�6'   $��
20,170,0,0q�6B   $	��Top=�6V   ���	#FF498C51$��40��6�   $	��114��6�   $��1��6�   �� 5   
   $+��%Восстановить пароль��6   $
��Left=�6/   $��129,202,0,0q�6J   $	��Top=�6_   ���	#FF498C51$��20��6�   $	��121��6�   ���	#FFFFFDFD6�   �� 5   
   -   5         ��Name$ mailBox��5      $
��Left=�6#   $��129,111,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $��Введите почту��6g   $	��Top=�6|   $	��120��6�    J� Opacity$	 0.4Q�6�   �� 5   
   -	   5        $ passBox��5      $
��Left=�6#   $��130,170,0,0q�6>   $
 Wrap=�6S   $!��Введите пароль��6g   $	��Top=�6}   $	��120��6�   $	 0.4Q�6�   5      5      