   M S B A M L   `   `   `  ����@  <todoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:todootodoo  5   	       todoo.Tasks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:todoo     5   	     � Title$  Tasks��5   	   $	��450��6   $	��800��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��267* �6   �� 5      $��8* �6   �� 5      $	��97* �6   �� 5      $
��428* �6   .+�5   
   �� -   5         ��Name$ TaskListBox��5      $
��Auto=�6W   $��	73,44,0,0q�6�   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      ��  d� 	IsChecked 6#   �� *IsCompleted+�� 5      $��10,0,0,0q�6:   ��6$   �� *Name+6:   �� 5      $��10,0,0,0q�6J   ��6$   �� *Date+ �� StringFormat$ d��6J   5      5      5      �� 5   
   $��2��6   $��
2,10,10,10q�6%   $��2��69   .+�5      �� $
��Wrap=�6p   ��6   �� *SelectedTask.Description+ �� FallbackValue$" Select a task to see details��6p   �� 5      -   5        $��Готово��5      $��0,10,0,0q�6C   �� 5       -   5        $��Удалить��5       $��0,10,0,0q�6B   5!      �� 5"   
   $��Дом��6   $
��Left=�6   $��	73,19,0,0q�6:   $	��Top=�6M   �� 5#   
   $��Работа��6   $
��Left=�6"   $��
106,19,0,0q�6=   $	��Top=�6Q   �� 5$   
   $��
Учёба��6   $
��Left=�6!   $��
153,19,0,0q�6<   $	��Top=�6P   �� 5%   
   $��
Отдых��6   $
��Left=�6!   $��
195,19,0,0q�6<   $	��Top=�6P   �� 5&   
   $��Задача��6   $
��Left=�6"   $��	10,56,0,0q�6=   $	��Top=�6P   $��46��6h   �� 5'   
   -   5        $��История��5'      $
��Left=�6?   $��4,81,0,0q�6Z   $	��Top=�6l   $��58��6�   �� 5(   
   -   5         ��Name$ 	NameLabel��5(      $��Label��6%   $
��Left=�65   $��7,19,0,0q�6P   $	��Top=�6b   $��52��6z   $��32��6�   5)      5*      