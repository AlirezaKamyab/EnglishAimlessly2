   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  '    !EnglishAimlessly2.View.ManageView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:EnglishAimlessly2.View     $	��600��$
��1000��.���� ���#777$��1q�._�� 
�������  � RowDefinitions  �� $��25 ��� .+��� $��25�����#eee._�]� $	��0 0q�.+��� -    ��Name$ btnAdd��   
RectButton#��[  ���#555$	��Add��$��75��
�������$
��10 0q�$
��Left=�$
��Left=�$��0q�
������ $	��Add������ *OpenManagerWindowsCmd+�� -   $ btnAddTogether��#��[  ���#555$��Add All��$��75��
�������$
��10 0q�$
��Left=�$
��Left=�$��0q�
������ $��AddTogether������ *OpenManagerWindowsCmd+�� #��[  
���  ��$��×��$��	ExtraBold"�$��25��$��Center=�
�������$��Right=�$��Right=�$��25��
������ ���� *CloseToMainMenuCmd+� $��1�� � ColumnDefinitions �� $	��350 ��� .+��� $	��350�����#888$��0q� �� CornerRadius$ 	0 10 10 0������  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FF6F95DC�� � Offset$ 0.006Q�� $ 	#FF224C9A��$ 1Q�._�� $��0q�  �� $	��100 ��� .+��� $��10q�$��0q�$ 5��._��� $��5q�.+��� $��Words��$��20(� �� TextAlignment$ Center=�$
��Bold"����#fff�� 	 �� Orientation$	 Vertical=�.+��� $��0 10 0 0q�  	SearchBox#��[ $��14(�$��2q�� $��1��.+��� 
������ $��0q�$��False��$��Hidden=�  ManagerWordItem#��[ ���� *
WordList+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue �� *SelectedWord+$
 TwoWay=�$ PropertyChanged=��� -    ��Name$ 
borderMain��$��1��$
��10 5q�$��0q����#eee$ 0��._��� $��False��$��Hidden=�.��� y��� *MainPanelVisibility+  �� $��2* ��� $��5* �.+��� $��10 0 0 0q�
������$��10q�$ 10��$��0�����#eee._��� $	 Vertical=�$��10q�.+��� $��16(�$ Center=����� *SelectedGroup.Name+�� $��Hidden=�$��50��.���� $��0 5 0 0q�$
��Wrap=��� ���#888$�Description:�� �� ��� *SelectedGroup.Description+$
 TwoWay=���   CurveButton#��[ $��0 10 0 0q�$
��Edit�����#eee$��Center=�$
��15 3q�$��2q�$��GroupSettings������ *OpenManagerWindowsCmd+�� -   $ borderDetails��$��0q�$��1��._��� $	 Vertical=�$��10q�.+��� ���#eee$ 10��$��10 0 0 0q�
������ �� Padding$ 10q�._��� $��5 0 0 0q�.+��� $��16(�$ Center=�$��0 5 0 0q��� ��� *SelectedWord.Name+$
 TwoWay=� �� 
���  ����� *SelectedWord.WordType+$
 TwoWay=� �� StringFormat$
  {0}���� $��0 5 0 0q�$
��Bold"��� ���#555$�Equivalent:�� �� ��� *SelectedWord.Equivalent+$
 TwoWay=��� $��0 10 0 0q�$
��Wrap=� �� LineStackingStrategy$ 	MaxHeight=��� ���#888$� �� �� ��� *SelectedWord.Description+$
 TwoWay=�� $��0 10 0 0q�.+��� $
��Left=��� ���#888$�Last Practice�� �� 
���  ����� *LastPracticed+$
 OneWay=��� $��Right=��� ���#888$�	Practiced�� �� 
���  ����� *SelectedWord.PracticeCount+$
 TwoWay=� �� ���#888$�time(s)���� $
��0 30q�$��Center=�$	 
Horizontal=�.+��� #��[ $��History��
�������
���   �$	��5 0q�$��10q�$	��100��$��2q�$��History������ *OpenManagerWindowsCmd+�� #��[ $
��Edit��
�������
���   �$	��5 0q�$��10q�$	��100��$��2q�$
��Edit������ *OpenManagerWindowsCmd+�� #��[ $��Reset��$	��5 0q�
�������
���   �$��10q�$	��100��$��2q����� *ResetWordCmd+�� #��[ $��Remove��
�������
���   �$	��5 0q�$��10q�$	��100��$��2q����� *RemoveWordCmd+