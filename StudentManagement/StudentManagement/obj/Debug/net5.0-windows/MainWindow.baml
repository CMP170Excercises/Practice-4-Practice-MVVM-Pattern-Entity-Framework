   M S B A M L   `   `   `  ����L  HStudentManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentManagementStudentManagement  5   	   "    StudentManagement.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentManagement     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  StudentSearch��5	   	   $	��450��6   $	��800��6,    � DataContext 5
      .   (StudentManagement.SearchStudentViewModel  5   
    � 	Resources 5         styleTextBox �� 
TargetType �� Property �� Value  LableContent  StyleButton  StyleComboBox  StyleListBox��%N  &	        &	 �     &	 L    &	     &	 �    �� 5   
   " ��6%   .�5      ��  � ��$ Center=�62   �� 5       �@��TextWrapping$
 Wrap=�6-   �� 5       � ��$ 25��6'   �� 5       � ��$ 1q�60   �� 5       � ��$ Times New Roman)�6+   5      �� 5   
   " ��6%   .�5      ��  � ��$ Times New Roman)�6+   5      �� 5   
   " ��6$   .�5      ��  � ��$ 7q�6'   �� 5       � ��$ Medium"�6+   �� 5       � ��
 �/���6+   �� 5       � ��$ Times New Roman)�6+   5      �� 5   
   " ��6&   .�5       ��  � ��$ 7q�6'   �� 5!       � ��$ 20(�6)   �� 5"       � ��$ Arial)�6+   5#      �� 5$   
   " ��6%   .�5%      ��  � ��$ 5q�6'   �� 5&       � ��$ Times New Roman)�6+   5'      5(      .��5*      � $��5q�6    � RowDefinitions 5+   
   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   �� 5/      $��* �6   �� 50      $
��Auto �6   .+�52   
   o� $��0��6   $��30��6   .@�53      m� $��Students��6   $��10(�6)   $��Center=�67   $��Center=�6T   .@�54      m� $��Search Student��6   m� 55      $��Create a new Student��6   56      m� 57      $��Class��6   $��10(�6&   $��Center=�64   $��Center=�6Q   58      �� 59   
   $��1��6   
���   �$��0 0 0 1q�62   ._�5:      �� $��20(�6   #��[ 6"   .��6H   Search Students6Y   5;      � 5<   
   $��2��6   $��40��6    � ColumnDefinitions 5=      �� 5>      $
��0.5* �6#   �� 5?      $
��0.2* �6#   �� 5@      $
��0.1* �6#   �� 5A      $
��0.1* �6#   .+�5C      �� $��0��6   #��[  6'   ��6M   ��  �� Path$ SearchKeyword��� 5D      $��1��6   #��[ 6'   	 �� SelectedValuePath$	 Content ��6v   
 �� SelectedValue
 6N   �� *SelectedClass+.@�5E      ��  �� 
IsSelected$
 True��6   .��61   
19DTHQA16;   �� 5F      .��6   
19DTHQA26)   5G      �� 5H      $��2��6   #��[ 6G   ��6%   �� *SearchCommand+.��6l   Search6t   �� 5I      $��3��6   #��[ 6F   ��6%   �� *ResetCommand+.��6k   Reset6r   5J      �� 5L   
   $��2��6   
���   �$��1 1 1 1q�63   $��Stretch=�6�   $��0,40,0,5q�6�   $��2��6�   ��6M   �� *
Students+ �� SelectedItem 6n   �� *SelectedStudent+��5M      �� 5N      .R�5O      �� $��border��6   
����  �$��1q�6>    �� Padding$ 5q�6R   $��5q�6^   ._�5P      �  5Q      �� 5R   "   �� 5S   "   �� 5T   "    5V      �� 5W   "   �� 5X   "   .+�5Z      �� $��0��6(   $��0��65   $��Student Id:��6E   �� 5[      $��0��6(   $��1��65   ��6E   �� $ 	studentId��� 5\      $��1��6(   $��0��65   $��
Firstname:��6E   �� 5]      $��1��6(   $��1��65   ��6E   �� $ 	firstname��� 5^      $��2��6(   $��0��65   $��	Lastname:��6E   �� 5_      $��2��6(   $��1��65   ��6E   �� $ lastname�5`      5a      5b      5d      � 5e   
   $��4��6    5f      �� 5g      $
��0.4* �6#   �� 5h      $
��0.1* �6#   .+�5j      �� $��1��6   $��25��6%   #��[ 6W   ��61   �� *OpenDetailCommand+.��6|   Open Student Detail6�   5k      5l      5m      