   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   )    #EnglishAimlessly2.View.RegisterView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	     � Title$  Register Page��5	   	   $	��600��6   $	��900��6,    � WindowStartupLocation$ CenterOwner=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � 	Resources 5      2   ,EnglishAimlessly2.ViewModel.UserCredentialVM   uvm��%   &	          5   
   6   5      .��5      � ���#c33124 � DataContext# [  6     � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��4* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      �� 5      $��25 �6   .+�5   
   �� -   5        $��0��5      $��3��6   ���#eee._�5!      � .+�5"      �� -   5          
RectButton#��[ 5"      $��Right=�5#      $��Center=�5$      $��25��5%      $��25��5&      
���  ��$��×��5(      $��16(�5)      $
��Bold"�5*      
�������5,      5-      5.      �� 50   
   $��1��6   $��1��6!   ���#ffffff �� CornerRadius$ 20��52      $��0 5 0 0q�53      ._�54      �  55      �� 56      $��* �6$   �� 57      $	��10* �6$   �� 58      $��* �6$   .+�5;      � .+�5<      �� $��Register��6    $��25(�60   $
��Bold"�5=       $��Center=�5>       $��Center=�5?       5@      �� 5B      $��1��6   $��25 10q�5C      .+�5D      �� $��Username��6    $��12(�60   �� 5F      $	��0 5q�6   $��12(�6+     
NewTextBox#��[ 5G      ��5H      �� *
Username+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5K      -   5         ��Name$ txtPass��5K      $	��0 5q�6/   $��12(�6<   $y�	Collapsed=�6J   ��5L      �� *
Password+$	 TwoWay=�$
 PropertyChanged=�� 5N      $	��0 5q�6   .+�5O      ��  �� Orientation$ Vertical=�6%   $	��2 0q�6<   .+�5P      �� $
��Name��6(   $��12(�64   �� 5R      $	��0 5q�6&   $��12(�63   #��[ 5S      ��5T      �� *Name+$	 TwoWay=�$
 PropertyChanged=�5U      5W      �� 5Y      $��Email��6    $��12(�6-   �� 5[      $	��0 5q�6   $��12(�6+   #��[ 5\      ��5]      �� *Email+$	 TwoWay=�$
 PropertyChanged=��� 5`      -   5         ��Name$ permissionCheck��5b      $%��I accept the policies and terms��5`        NewCheckBox#��[ 5a      5b      �� 5d      -   5          CurveButton#��[ 5d      $��Register��6B   $
��0 10q�5e      ��5f      ��  �� ElementName$ permissionCheck�� �� Path$ 	IsChecked���5g      �� *CreateAccountCmd+5h      �� 5j       �� TextAlignment$ Center=�6C   ���	#FFDC8E00��6    �� *Hint+$	 TwoWay=�6Z   �� 5l      -   5         ��Name$ btnBackToLogin��5m        ClickableText#��[ 5l      $��Back to login��5n      $��Center=�5o      $��20q�5p      
����  �5r      5s      � 5u      $��2��6   .+�5v      �� $��10q�6    $��Center=�6,   $��Center=�5w       ���#555$
��Bold"�5y       $(��"Made by Alireza Kamyab / Version 2��5z       5{      5|      5}      5~      5      