   M S B A M L   `   `   `  ���� L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  )    #EnglishAimlessly2.View.PracticeView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     8vm)clr-namespace:EnglishAimlessly2.ViewModel     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:EnglishAimlessly2.View     $	��600��$
��1000��.���� $��1q�
���   �
�������._��   � RowDefinitions  �� $��25 ��� .+��� $��25�����	#FF3A639E$��0q�._�]� $	��0 0q�.+��� $��Center=�$��15(�$	��5 0q�
��������� 
��� ������ *SelectedGroup.Name+��    
RectButton#��[  $��Center=�
���  ��$��×��$��25��$��25��$��	ExtraBold"�
�������$��Right=�
������ ���� *ClosePracticeCmd+� $��1�����#fff  �� $	��100 ��� $��3* ��� $��* �.+��� -    ��Name$ pnlCard��$��1�����	#FFF1F1F1 �� CornerRadius$ 10��$��5q�._�� $��Center=�.+��� -    ��Name$ pnlError��$��Center=�y��� *ErrorPanelVisibility+.+��� $��20(�$��No word for practice�� �� TextAlignment$ Center=�����  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FF4F00FF��� $	 Red�� � Offset$ 1Q�� $ 	#FF2BAD52��$
 0.51Q�� -   	 �Name$	 
stackPanel��y��� *ControlPanelVisibility+.+��� $��0 10 0 0q�.+��� ���	#FFE9E9E9$
��10 0q�$ 8��
 �� Padding$
 2q�._��� -    ��Name$ txtWord��$��18(�$
��Bold"�$ Center=��� ��� *SelectedWord.Name+ �� 
���  ����� *SelectedWord.WordType+ �� StringFormat$
  {0}���� -   $ txtEquivalent��$��14(�$ Center=�$��5 5 5 0q�$��SemiBold"�y��� *AnswerVisibility+�� ��� *SelectedWord.Equivalent+�� $��Hidden=�$	��225��$��10q�$	��650��$��False��y��� *AnswerVisibility+.���� .+��� $

 0 10q�$��10 0 0 0q�
������$ 10��._��� $��14(�$��10 0 0 0q�$y�Visible=�$
��Wrap=��� ��� *SelectedWord.Description+� $��Bottom=�$��0 0 0 10q�.+��� $��12(�$��0 0 0 0q�  PracticeExampleBox#��[  �� 	MaxLength$	 250��$
��Left=�$	��650��$��7q���  �� Orientation$ 
Horizontal=�$��Right=�$��Center=�.+��� $��20��$��20��$��0 0 5 0q�$��0q�
������ y��� *ShowButtonVisibility+���� *ShowAnswerCmd+.���� $)��#/Resources/Images/Icons/lightOn.png�� �� BitmapScalingMode$ HighQuality=��� $��20��$��20��$��0 0 25 0q�
������ $��2q�$��0q����� *OpenHistoryCmd+.���� $-��'/Resources/Images/Icons/historyIcon.png��$ HighQuality=��� -   $ 
pnlButtons��$��2��$��1��$��Center=�$��Center=�$ 
Horizontal=�y��� *ControlPanelVisibility+.+��� -    ��Name$ btnNextHours��  CurveButton#��[ $��Right=�$��
Next Hours��$	��100��$��10q�$��5q�$��11(�
����������#444$��0q�$��4������ *NextWordPracticeCmd+�� -   $ btnNextHard��#��[ $��Right=�$
��Hard��$	��100��$��10q�$��11(�
���  ��
�������$��0q�$��5q�$��3������ *NextWordPracticeCmd+�� -	   $ btnNextNormal��#��[ $��Right=�$��Normal��$��10q�$	��100��$��11(�
��� ���
�������$��5q�$��0q�$��2������ *NextWordPracticeCmd+�� -
   $ btnNextEasy��#��[ $��Right=�$
��Easy��$��10q�$	��100��$��11(�
����  �
�������$��5q�$��0q�$��1������ *NextWordPracticeCmd+