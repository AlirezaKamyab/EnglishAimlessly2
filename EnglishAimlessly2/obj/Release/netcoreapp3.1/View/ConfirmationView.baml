   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  -    'EnglishAimlessly2.View.ConfirmationView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:EnglishAimlessly2.View       � Title$  Confirmation��$	��200��$	��400�� � WindowStartupLocation$ CenterOwner=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�.���� 
�������$��1q����#666._��  � RowDefinitions �� $��* ��� $��2* ��� $��* �.+��� $��0q�$��0��$��0q����#666 �� CornerRadius$ 0 0 0 0�����#888._��� $��10q�$��Center=�.+��� -    ��Name$ lblTitle��$��18(�
�������$��Confirmation Title��$��WrapWithOverflow=��� $��0q�$��1��$��0 0 0 0q����#666._��� $��10q�$��Center=�$��Center=�.+��� -   $ 
lblMessage��$��14(�$'��!Are you sure you want to do this?��$
��Wrap=��� $��0q�$��2��$��0 0 0 0q����#666���#eee$ 0 0 0 0��._�� $��5q�.+��� -    ��Name$ btnYes��$��65��$��35��   CurveButton#��[  $��Right=�$	��Top=�$��	 0 0 30 0q�
������$	��YES��
�������$��0q�$��5q��� -   $ btnNo��$��65��$��35��#��[  $
��Left=�$	��Top=�$��	 30 0 0 0q�
���  ��
�������$��NO��$��2q�$��5q�