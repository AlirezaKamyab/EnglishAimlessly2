   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  +    %EnglishAimlessly2.View.MasterPractice   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8vm)clr-namespace:EnglishAimlessly2.ViewModel     6local$clr-namespace:EnglishAimlessly2.View     $	��600��$
��1000��.���� ���#555$��1q�._�� 
�������  � RowDefinitions  �� $��25 ��� .+�� -   $��0q����#082032.+��� $��Center=����#ddd$��5 0 0 0q��� $�Master Practice -�� �� ��� *
Group.Name+�� $��×��$��25��$��25��   
RectButton#��[  $��Right=�$��0 0 0 0q�$��Center=�
���  ��
�������$��	ExtraBold"�$��0q�$��15(����� *CloseMasterPracticeCmd+� $��1��  �� $��50 ��� �� $��50 �.+�� $��0��.+��� $��20(�$��5q�$��Center=����� *SelectedWord.Score+ �� StringFormat$ 
Score: {0}��y��� *MainPanelVisibility+� $��1��.+��� $��24(�$��No word for practice�� �� TextAlignment$ Center=�$��Center=�y��� *ErrorVisibility+����  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FF4F00FF��� $	 Red�� � Offset$ 1Q�� $ 	#FF2BAD52��$
 0.51Q��� $��Center=�$��Center=�$	��800��$	��400�� �� CornerRadius$ 5��$��0q����� *BackgroundColor+y��� *MainPanelVisibility+._�� .+��� .+��� $��22(�$��0 10 0 0q�$ Center=��� $
��Bold"���� *SolutionWord+���� *AnswerColor+ �� $��Italic$���� *SolutionType+���� *AnswerColor+�� $��False��$��
30 10 30 0q�$	��300��$��Hidden=�.���� .+��� $ 10��$��10 0 0 0q� �� Padding$
 0 10q����#eee���� *AnswerColor+._��� $
��Wrap=�$��5q�$��16(����#333���� *SelectedWord.Description+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� $��
10 0 10 10q�$��Bottom=� �� Orientation$ 
Horizontal=�.+��� $��15(����#222 �� TextAlignment$ Center=�$	��5 0q�$	��600��$��30��  MasterAnswerTextBox#��[ ���� *Answer+$	 TwoWay=�$
 PropertyChanged=���   CurveButton#��[ $��10 0 0 0q�$��Check��$��12(�$��50��
��� � �
�������$��7q�$��0q����� *CheckAnswerCmd+{��� *CheckAnswerButtonEnable+�� #��[ $��2 0 0 0q�$��Reveal��$��50��$��12(�
���  ��
�������$��7q�$��0q����� *	RevealCmd+{��� *RevealButtonEnabled+�� #��[ $��2 0 0 0q�$
��Next��$��50��$��12(�
������
�������$��0q�$��7q����� *	SkipCmd+