   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  &     EnglishAimlessly2.View.LoginView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8vm)clr-namespace:EnglishAimlessly2.ViewModel     6local$clr-namespace:EnglishAimlessly2.View     $	��600��$
��1000��.���� ���#555$��1q�._�� ���#c33124  � ColumnDefinitions  �� $��3* ��� $��4* ��� $��3* � � RowDefinitions �� $��25 ��� �� $��25 �.+��� -   $��0��$��3�����#eee._�� .+��� -      
RectButton#��[  $��Right=�$��Center=�$��25��$��25��
���  ��$��×��$��16(�$
��Bold"�
��������� $��1��$��1�����#ffffff$��0 5 0 0q� �� CornerRadius$ 20��._��  �� $��50 ��� $��5* ��� $��25 �.+��� $��Center=�$��Center=�.+��� $��Login��$��25(�$
��Bold"��� $��1��$��30 10q�.+��� 
������ $��0q�$ 8��._��� $	��275��$��10q�
������ $��0q�  UserItem#��[ $��False������ *Users+ �� SelectedValue �� *SelectedUser+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���   CurveButton#��[ $��Login��$	��0 5q�$	��100������ *
LoginCmd+��  �� TextAlignment$ Center=����	#FFDC8E00���� *Hint+�� $ Center=�$��
Find me on�����#444��  �� Orientation$ 
Horizontal=�$��5q�$��Center=�.+��� $+��%/Resources/Images/Icons/Instagram.png��$��25��$��25�� �� BitmapScalingMode$ HighQuality=��� $(��"/Resources/Images/Icons/github.png��$��25��$��25��$	��5 0q�$ HighQuality=��� -   	 ��Name$	 btnCreateAccountPage��  ClickableText#��[ $
��0 20q�
����  �$��CREATE ACCOUNT?��$��Center=�$
��Bold"��� $��2��$��Center=�.+��� $��10q�$��Center=����#555$
��Bold"�$(��"Made by Alireza Kamyab / Preview 2��