   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  I)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  0    *EnglishAimlessly2.View.MainMenuViewPreview   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:EnglishAimlessly2.View     8vm)clr-namespace:EnglishAimlessly2.ViewModel     $	��600��$
��1000��.���� ���#999$��1q�._��   � RowDefinitions  �� $��25 ��� .+��� -   $��0�����#EAEAEA._�� .+��� $��Center=�$��10 0 0 0q����#555���� *LoggedUser.Username+��  �� Orientation$ 
Horizontal=�$��Center=�$��Right=�.+��� $��60��$��25��$��Logout��   
RectButton#��[  
������
����������#999$��0 1 1 0q�$��	ExtraBold"�$��0 0 2 0q�$��Login������ *ChooseOptionCmd+�� -   $��60��$��25��$��Close��#��[  
���  ��
����������#999$��0 1 1 0q�$��	ExtraBold"�� $��1�� � ColumnDefinitions �� $	��350 ��� .+��� $��0�� �� CornerRadius$ 0 5 5 0������  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FF6F95DC�� � Offset$ 0.006Q�� $ 	#FF224C9A��$ 1Q�._��   �� $��75 ��� .+��� $��0��.+��� $��Group�����#333$��	15 10 0 0q�$��14(�$
��Bold"�� .+��� $��10q�$��14(�  SearchTextbox#��[ �� 
������ $��25��$��25��$��Right=�$��0q�$��0 0 20 0q����� *CreateGroupCmd+.���� $)��#/Resources/Images/Icons/AddIcon.jpg�� �� BitmapScalingMode$ HighQuality=�� $��1��$��0 5 0 0q�.+��� 
������ $��Hidden=�$��0q�$��False��  MainMenuGroupItem#��[ ���� *Groups+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedValue �� *SelectedGroup+�� $��1�����#FFF$��2��._�� y��� *MainPanelVisibility+  �� $	��200 ��� .+��� $��0�����#eee$ 10��$��10q�$��5 0 0 0q�
������._��� .+��� $��10q� �� TextAlignment$ Center=�$��20(�
���   �$��	ExtraBold"����� *SelectedGroup.Name+$
 PropertyChanged=��� 
���   �$��14(�$��	10 0 10 0q�$
��Wrap=��� $�
There are �� �� 
���  ��$��20(���� *	ItemCount+ �� $&� word(s) added to this group and �� �� $��20(�
���  ����� *MasterWordsCount+ �� $Y�Sword(s) has been practiced to MASTER level. You can practice via the options below.���� $ Center=�$��16(�$��0 30 0 0q����#333y��� *PracticeCountVisibilty+�� $�Practice Available :�� �� $
��Bold"�
��������� *PracticeAvailableCount+�� $ Center=�$��16(�$��Next Practice in��$��0 10 0 0q�$��SemiBold"�
���  ��y��� *CountDownVisibility+�� $ Center=�$��16(�$��SemiBold"�$��0 5 0 0q����#333���� *NextPracticeCounter+y��� *CountDownVisibility+�� $��1��.+��� $ 
Horizontal=�$��10q�$	��100��$��Center=�.+���   MenuOptionButton#��[ $��Normal Practice��$��NormalPractice������ *ChooseOptionCmd+�� #��[ $��Master Practice��$��MasterPractice������ *ChooseOptionCmd+�� #��[ $��Master Words��$��MasterWords������ *ChooseOptionCmd+�� $ 
Horizontal=�$
��10 0q�$	��100��$��Center=�.+��� #��[ $��Words Manager��$��ManageWords������ *ChooseOptionCmd+�� #��[ $��History������ *OpenHistoryCmd+�� #��[ $��Settings������ *OpenSettingsCmd+�� $ 
Horizontal=�$
��10 0q�$	��100��$��Center=�.+��� #��[ $��Remove Group��$��75�����	#FFFFB7B7���� *RemoveGroupCmd+