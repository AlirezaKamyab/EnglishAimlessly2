   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  )    #EnglishAimlessly2.View.EditWordView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8vm)clr-namespace:EnglishAimlessly2.ViewModel     6local$clr-namespace:EnglishAimlessly2.View       � Title$  EditWordView��$	��450��$	��800�� � WindowStartupLocation$ CenterOwner=�.��� ���#c33124 � ColumnDefinitions �� $��* ��� $��2* ��� $��* � � RowDefinitions �� $��* ��� $	��12* ��� $��* �.+��� $��1��$��1�����#666$��1q� �� CornerRadius$ 10��
�������._�� $��10q�.+��� .+��� $��	Edit Word�� �� TextAlignment$ Center=�$��20(� �� Padding$ 5q�$��5q�� $��5q� �� $��* ��� $��* �.+��� $��	0 0 2.5 0q�.+��� $��	Word Name���� -    ��Name$ txtWordName��   
NewTextBox#��[  $��0 5 0 0q� �� 	MaxLength$ 30������ *
WordName+	 �� Mode$	 TwoWay=��� $��	2.5 0 0 0q�$��1��.+��� $��	Word Type���� -   $ txtWordType��#��[  $��0 5 0 0q�$ 20������ *
WordType+$	 TwoWay=��� $	��5 0q�$��
Equivalent���� -   $ txtEquivalent��#��[  $��5q�$ 60������ *
Equivalent+$	 TwoWay=��� $	��5 0q�$��Description���� -   $ txtDescription��#��[  $��5q�$��False��$	��100��
 �� AcceptsReturn$

 True�� �� 
AcceptsTab$
 True������ *Description+$	 TwoWay=��� -     CurveButton#��[ $
��0 10q�$��Center=�$��Update��$
��10 5q����� *EditWordCmd+