   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=0.5.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   .    (EnglishAimlessly2.View.GroupSettingsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	     � Title$  GroupSettingsView��5	   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterOwner=�5
   	    � 	Resources 5      1   +EnglishAimlessly2.ViewModel.GroupSettingsVM   gsvm��%   &	          5   
   6   5      .��5      � ���#c33124 � DataContext# [  6     � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6   ���#666$��1q�6A    �� CornerRadius$ 10��6U   
�������._�5      � $��10q�6   .+�5       �� .+�5!      �� $��Group Settings��6     �� TextAlignment$ Center=�5"       $��20(�5#        �� Padding$ 5q�5$       $��5q�5%       �� 5'      $	��5 0q�6    $��
Group Name��6-   �� 5(        
NewTextBox#��[ 6   $��5q�5)      ��5*      �� *	GroupName+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5,      $	��5 0q�6    $��Description��6-   �� 5-      #��[ 6   $��5q�5.       �� AcceptsReturn$
 True��5/       �� 
AcceptsTab$
 True��50      $��50��51      ��52      �� *Description+$	 TwoWay=�$
 PropertyChanged=��� 54      -   5         ��Name$ 	btnUpdate��55        CurveButton#��[ 54      $
��0 10q�56      $��Center=�57      $��Update��58      $
��10 5q�59      ��5:      �� *UpdateGroupCmd+5;      5<      5=      5>      5?      