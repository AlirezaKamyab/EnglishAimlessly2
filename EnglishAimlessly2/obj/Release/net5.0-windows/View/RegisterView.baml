   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  )    #EnglishAimlessly2.View.RegisterView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8vm)clr-namespace:EnglishAimlessly2.ViewModel     6local$clr-namespace:EnglishAimlessly2.View       � Title$  Register Page��$	��600��$	��900�� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � 	Resources 2   ,EnglishAimlessly2.ViewModel.UserCredentialVM   uvm��%   &	          .��� ���#c33124 � DataContext# [   � ColumnDefinitions �� $��3* ��� $��4* ��� $��3* � � RowDefinitions �� $��25 ��� �� $��25 �.+��� -   $��0��$��3�����#eee._�� .+��� -     
RectButton#��[ $��Right=�$��Center=�$��25��$��25��
���  ��$��×��$��16(�$
��Bold"�
��������� $��1��$��1�����#ffffff �� CornerRadius$ 20��$��0 5 0 0q�._��  �� $��* ��� $	��10* ��� $��* �.+�� .+��� $��Register��$��25(�$
��Bold"�$��Center=�$��Center=��� $��1��$��25 10q�.+��� $��Username��$��12(��� $	��0 5q�$��12(�  
NewTextBox#��[ ���� *
Username+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� -    ��Name$ txtPass��$	��0 5q�$��12(�$y�	Collapsed=����� *
Password+$	 TwoWay=�$
 PropertyChanged=�� $	��0 5q�.+���  �� Orientation$ Vertical=�$	��2 0q�.+��� $
��Name��$��12(��� $	��0 5q�$��12(�#��[ ���� *Name+$	 TwoWay=�$
 PropertyChanged=��� $��Email��$��12(��� $	��0 5q�$��12(�#��[ ���� *Email+$	 TwoWay=�$
 PropertyChanged=��� -    ��Name$ permissionCheck��$%��I accept the policies and terms��  NewCheckBox#��[ �� -     CurveButton#��[ $��Register��$
��0 10q�����  �� ElementName$ permissionCheck�� �� Path$ 	IsChecked����� *CreateAccountCmd+��  �� TextAlignment$ Center=����	#FFDC8E00���� *Hint+$	 TwoWay=��� -    ��Name$ btnBackToLogin��  ClickableText#��[ $��Back to login��$��Center=�$��20q�
����  �� $��2��.+��� $��10q�$��Center=�$��Center=����#555$
��Bold"�$(��"Made by Alireza Kamyab / Version 2��