   M S B A M L   `   `   `  ����J  FCompConstructor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CompConstructor.ViewsCompConstructor.Views  5      $    CompConstructor.Views.CaseList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CompConstructor.Views     5        N� Title$  Cases��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       '�� H     �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.3* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.8* �6   .+�5   
   �� $��0��6   $��2��5      ��5      �� *Cases+ �� SelectedItem 5       �� *SelectedCase+��5!      �� 5"      .R�5#      �� $��5q�6!   .+�5$      �� $��18(�6$   ��62   ��  �� Path$
 Name��� 5%      ��6$   �� $
 Cost�5&      5'      5)      �� 5+   
   $��1��6   	 � DataContext	 6%   �� *SelectedCase+.+�5,      �� $'��!Выбранный элемент��6   �� 5-      $��Модель��6   �� 5.      $��30��6   ��6%   �� *Name+
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5/      $��Цена��6   �� 50      $��30��6   ��6%   �� *Cost+$
 PropertyChanged=��� 51      $��Формат��6   �� 52      $��30��6   ��6%   �� *Format+$
 PropertyChanged=��� 53      $��Высота��6   �� 54      $��30��6   ��6%   �� *Height+$
 PropertyChanged=��� 55      $��Ширина��6   �� 56      $��30��6   ��6%   �� *Length+$
 PropertyChanged=�57      �� 58   
   $��1��6   $��1��6!   $	��100��6.   $��50��6:   $��
 0 0 200 0q�59      ��58   F   �� *
AddCommand+.��59   %   +6(   �� 5:   
   $��1��6   $��1��6!   $	��100��6.   $��50��6:   $��	 10 0 0 0q�5;   ;   ��5:   F   �� *RemoveCommand+��5;      �� *SelectedCase+.��6N   -6Q   5<      5=      