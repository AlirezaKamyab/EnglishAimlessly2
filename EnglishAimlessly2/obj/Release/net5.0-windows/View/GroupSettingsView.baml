   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  .    (EnglishAimlessly2.View.GroupSettingsView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     8vm)clr-namespace:EnglishAimlessly2.ViewModel     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:EnglishAimlessly2.View       � Title$  GroupSettingsView��$	��450��$	��800�� � WindowStartupLocation$ CenterOwner=� � 	Resources 1   +EnglishAimlessly2.ViewModel.GroupSettingsVM   gsvm��%   &	          .��� ���#c33124 � DataContext# [   � ColumnDefinitions �� $��* ��� $��2* ��� $��* � � RowDefinitions �� $��* ��� $��3* ��� $��* �.+��� $��1��$��1�����#666$��1q� �� CornerRadius$ 10��
�������._�� $��10q�.+��� .+��� $��Group Settings�� �� TextAlignment$ Center=�$��20(� �� Padding$ 5q�$��5q��� $	��5 0q�$��
Group Name����   
NewTextBox#��[ $��5q����� *	GroupName+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� $	��5 0q�$��Description���� #��[ $��5q� �� AcceptsReturn$
 True�� �� 
AcceptsTab$
 True��$��50������ *Description+$	 TwoWay=�$
 PropertyChanged=���  �� Orientation$ 
Horizontal=�$��Center=�.+���   CurveButton#��[ $
��0 10q�$��Center=�$��Update��$
��10 5q����� *UpdateGroupCmd+