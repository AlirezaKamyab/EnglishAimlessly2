   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  )    #EnglishAimlessly2.View.MainMenuView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8vm)clr-namespace:EnglishAimlessly2.ViewModel     6local$clr-namespace:EnglishAimlessly2.View       � Title$  MainMenuView��$	��600��$	��900�� � WindowStartupLocation$ CenterOwner=�$��1q�
���   � � WindowStyle$
 None=� � 	Resources ,   &EnglishAimlessly2.ViewModel.MainMenuVM   mmvm��%   &	          .��]�  � DataContext# [  .+��� $	��Top=� �� CornerRadius$ 	0 0 20 20��$��35��$��0 0 0 5q� �� Padding$ 5q����#4c394f._�]� $
��10 0q�.+��� $
��left=�$��Center=�$��15(�
��������� ��� *LoggedUser.Name+ �� 
���  ����� *LoggedUser.Username+ �� StringFormat$ ({0})���� -    ��Name$ btnClose��  CurveButton#��[ 
���  ��$��Close��$��65��
�������$
��10 0q�$��Right=�$��Right=�$��3 0 0 0q�
������ �� -   $ btnMinimize��#��[ 
��� ���$��Minimize��
�������$��3 0 0 0q�$��65��$
��10 0q�$��Right=�$��Right=�
������ �� -   $ 	btnLogout��#��[ 
������$��Logout��
�������$��65��$
��10 0q�$��Right=�$��Right=�
������ �� $
��Left=�$	��300��
�������$��0 2 2 2q����#888$ 	0 20 20 0��$��0 5 0 5q�._�� 	 � RowDefinitions	 �� $��* ��� $
��3.5* �.+��� $��5q�$��0 0 0 1q����#999$ 0��$ 2q�._��� $��0q�.+��� $��Groups��$��20(�
 �� TextAlignment$
 Center=�$
��Bold"����#222�� $��5 10 0 3q�$8��2Input group name with at least 3 characters to add�����#222��  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ txtGroupName��  
NewTextBox#��[ $	��220��$��2q����� *	GroupName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� #��[ 
��� � �$	��ADD��$��50��$��30��
�������$��Right=�$
��10 0q�$	��5 0q�
������ ���� *CreateGroupCmd+� $��5q�$	��Top=�$��1��.+��� -    ��Name$ lstView��$��0q�
������ $��False��$��Hidden=����� *Groups+$ TwoWay=�$ PropertyChanged=� �� SelectedValue �� *SelectedGroup+$ TwoWay=�$ PropertyChanged=�����  �� 
TargetType" ��.���  �� Property � �� �� Value$ Stretch=���  � ��$ 0 0 0 5q����� �� -    ��Name$ 
borderMain��$
��Left=�$��5q�$��2q����#888$ 	25 1 25 1��._�� $��10q�	 �� $��3* ��� $��8* ��� $��* �.+��� $��0��$��10q�.+��� $��25(�$
 Center=����� *SelectedGroup.Name+]� $	��5 0q�.+��� $	��0 5q�$��14(�$
��Left=��� $�Word Count:�� �� ��� *	ItemCount+$ TwoWay=��� $	��0 5q�$��14(�$��Right=�$��Right=����� *MasterWordsCount+$ Mastered Words: {0}���� $��0 5 0 0q�$��18(�$
 Center=��� $�Available for practice:�� �� 
��������� *PracticeAvailableCount+�� $��0 2 0 0q�$��11(�$
 Center=��� ��� *NextPracticeCounter+�� $��1��$��10q�.+��� $��18(�$��Options��$
 Center=��� -   $ btnPractice��#��[ $��0 10 0 5q�$��12(�$��Center=�$	��300��$��Practice��$��7q����#00ff88�� -   $ btnMasterPractice��#��[ $	��0 5q�$��12(�$��Center=�$	��300��$��Master Challenge��$��7q����#00eeaa�� -	   $ btnMasteredWords��#��[ $	��0 5q�$��Mastered Words��$��12(�$��Center=�$	��300��$��7q����#5500ff
��������� -
   $ 
btnManager��#��[ $	��0 5q�$��Manage Words��$��12(�$��Center=�$	��300��$��7q����#aa00aa
��������� -   $ btnGroupSettings��#��[ $	��0 5q�$��Settings��$��12(�$��Center=�$	��300��$��7q����#fcb500�� -   $ 
btnHistory��#��[ $	��0 5q�$��History��$��12(�$��Center=�$	��300��$��7q����#fcb500
���   ��� #��[ $	��0 5q�$��Remove Group��$��12(�$��Center=�$	��300��$��7q�
���  ��
����������� *RemoveGroupCmd+� $��2��.+��� $��Center=�$��Center=����#555$
��Bold"�$.��(Made by Alireza Kamyab / Preview Version��