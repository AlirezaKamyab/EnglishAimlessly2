   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  (    "EnglishAimlessly2.View.HistoryView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:EnglishAimlessly2.View       � Title$  History Page��$	��600��$	��900�� � WindowStartupLocation$ CenterOwner=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�.���� $��1q����#888._��  � RowDefinitions �� $��25 ��� .+��� -   $��0�����#eee._�� $	��0 0q�.+��� -   
���  ��   
RectButton#��[  $��×��$��25��$��25��$��	ExtraBold"�
�������$��Right=�
������ � $��1�� � ColumnDefinitions �� $	��300 ��� .+��� $��0��$��0q� �� CornerRadius$ 7������  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.��� 	 � Color$	 	#FFEEEEEE��� $	 	#FFDFDFDF��
 � Offset$
 1Q�._��� $��0��.+��� $��Options��$��5q�$��12(�$
��Bold"�(  "System.Windows.Controls.DatePicker  $
��10 5q�  NewDatePicker#��[    SelectedDate �� *PracticedDateTime+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�y��� *DatePickerVisibility+$ TwoWay=�$ PropertyChanged=���   HistoryButton#��[ $��50��$	��275��
���  ��
�������$��0 10 0 0q�$��Remove��$��18(�$
��Bold"����� *RemoveHistoryCmd+�� $��1�����#fff$��0q�._��  �� $��40 ��� .+��� $��5q�.+��� $��History��$��18(� �� TextAlignment$ Center=�$
��Bold"����#555� $��5q�$	��Top=�$��1��.+��� -    ��Name$ lstView��$��0q�
������ $��False��$��Hidden=�  HistoryItem#��[ ���� *	Histories+ �� SelectedValue �� *SelectedHistory+$ TwoWay=�$ PropertyChanged=�