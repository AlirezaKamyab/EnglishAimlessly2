   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  .    (EnglishAimlessly2.View.MasteredWordsView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8vm)clr-namespace:EnglishAimlessly2.ViewModel     6local$clr-namespace:EnglishAimlessly2.View     $	��600��$
��1000��.��� 
�������  � RowDefinitions  �� $��25 ��� .+��� $��0�����#eee._�� -   .+��� $��Mastered Words��$��14(�$
��Bold"�$��Center=�$��10 0 0 0q����#eee��  �� Orientation$ 
Horizontal=�$��Right=�.+��� $��25��
���  ��
�������$��	ExtraBold"�$��0q�$��X��$��14(�$��2q����� *CloseToMainMenuCmd+� $��1�� � ColumnDefinitions �� $	��350 ��� .+��� $��0�� �� CornerRadius$ 0 8 8 0������  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FF6F95DC�� � Offset$ 0.006Q�� $ 	#FF224C9A��$ 1Q�._��   �� $��30 ��� .+�� $��0��.+��� ���#eee$��16(�$
��Bold"�$��10 0 0 0q�$��Center=����� *
Group.Name+� $��1��.+��� 
������ $��0q�   MasterWordItem#��[  $��False������ *MasterWords+ �� SelectedValue �� *SelectedWord+�� $��1��y��� *PanelVisibility+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.+��� $��20 10q�$ 10��$��0q����	#FFF65B3D �� Padding$ 10q�._��� .+��� $��10 10q� �� TextAlignment$ Center=�$��18(�
��������� ��� *SelectedWord.Name+ �� $�(�� �� ��� *SelectedWord.WordType+ �� $�)���� $����This word is considered mastered, try a bit more to make this word a habit by doing Master Practice. This way you can gain score for this word faster��$��10 10q�$
��Wrap=�$��12(�
��������� $��10 10q��� $�Score: ��
������� �� 
��� ������ *SelectedWord.Score+�� $��20 10q�$ 10��$��0q����#dedede$ 10q�._��� .+��� $��Practice Settings��$��	10 10 0 0q�$ Center=�$��18(����#333�� $��0 5 0 0q�$ Center=��� $�Last practice on �����#333 �� 
���  ����� *SelectedWord.UpdatedDate+ �� $�and total practices is �����#333 �� 
���  ����� *SelectedWord.PracticeCount+�� $��0 10 0 0q�$
��Wrap=�$ Center=��� $\�VYou can have your checkpoint set so you practice the word again and reset the duration�����#444 �� $)�#without reseting scores and history��
�������� $ 
Horizontal=�$��10q�$��Center=�.+���   CurveButton#��[ $��
CheckPoint��$��5q����� *CheckPointCmd+�� $��20 10q�$ 10��$��0q����	#FF8BBFF1$ 10q�._��� .+��� $��Target��$��10 5 0 0q�$ Center=�$��18(�
��������� $��15(��� $�Score �� �� 
���  ����� *SelectedWord.Score+ �� $
� of �� �� $�10000�����	#FFFCFF17� $��15�� � Maximum$ 10000Q����	#FF03FF00
������� � Value �� *SelectedWord.Score+