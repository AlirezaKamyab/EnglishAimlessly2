   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   +    %EnglishAimlessly2.View.MasterPractice   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	   $	��600��5	   	   $
��1000��6   .��5      �� ���#555$��1q�6    ._�5   
   � 
�������  � RowDefinitions  5      �� 5      $��25 �6    �� 5      .+�5      � -   5        $��0q�5      ���#082032.+�5      �� $��Center=�6   ���#ddd$��5 0 0 0q�5      �� 5      $�Master Practice -��6    �� 5      �6   �� *
Group.Name+5      �� 5      $��×��6   $��25��6%   $��25��60      
RectButton#��[  5      $��Right=�5      $��0 0 0 0q�5      $��Center=�5       
���  ��
�������$��	ExtraBold"�5#      $��0q�5$      $��15(�5%      ��5&      �� *CloseMasterPracticeCmd+5(      � 5+      $��1��6     5,      �� 5-      $��50 �6$   �� 5.      �� 5/      $��50 �6$   .+�52      � $��0��6   .+�53      �� $��20(�54      $��5q�56      $��Center=�57      ��53       �� *SelectedWord.Score+ �� StringFormat$ 
Score: {0}��y�55      �� *MainPanelVisibility+57      58      � 5:      $��1��6   .+�5;      �� $��24(�6    $��No word for practice��6.    �� TextAlignment$ Center=�6J   $��Center=�5<      y�5=      �� *ErrorVisibility+��5>      �� 5?       �� EndPoint$ 1,0.5&�62    �� 
StartPoint$ 0,0.5&�6C   .��5@   "   �  � Color$ 	#FF4F00FF��6/   � 5A   "   $	 Red��6/    � Offset$ 1Q�6;   � 5B   "   $ 	#FF2BAD52��6/   $
 0.51Q�6A   5C      5E      �� 5G      $��Center=�6   $��Center=�5H      $	��800��5I      $	��400��5J       �� CornerRadius$ 5��5K      $��0q�5L      ��6-   �� *BackgroundColor+y�5M      �� *MainPanelVisibility+._�5N      � .+�5O      �� .+�5P   "   �� $��22(�6,   $��0 10 0 0q�5Q   (   $ Center=�5R   (   �� 5S   "   $
��Bold"�6g   �6&   �� *SolutionWord+��6D   �� *AnswerColor+6g    �� 5T   "   $��Italic$�6g   �6&   �� *SolutionType+��6D   �� *AnswerColor+6g   5U   #   �� 5W   "   $��False��6/   $��
30 10 30 0q�5X   +   $	��300��5Y   +   $��Hidden=�5Z   +   .��5[   &   �� .+�5\   *   �� $ 10��61   $��10 0 0 0q�6g    �� Padding$
 0 10q�5]   -   ���#eee��5\   C   �� *AnswerColor+._�5_   .   �� $
��Wrap=�68   $��5q�6L   $��16(�5a   4   ���#333��5`   4   �� *SelectedWord.Description+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5b   4   5c   +   5d   '   5e   #   5f      �� 5h      $��
10 0 10 10q�6)   $��Bottom=�5i   %    �� Orientation$ 
Horizontal=�5j   %   .+�5l   "   �� $��15(�6*   ���#222 �� TextAlignment$ Center=�5n   &   $	��5 0q�5o   &   $	��600��5p   &   $��30��5q   &     MasterAnswerTextBox#��[ 5s   &   ��5r   &   �� *Answer+$	 TwoWay=�$
 PropertyChanged=�5s   &   �� 5u   "     CurveButton#��[ 6)   $��10 0 0 0q�5v   %   $��Check��5w   %   $��12(�5x   %   $��50��5y   %   
��� � �
�������$��7q�5|   %   $��0q�5}   %   ��5~   %   �� *CheckAnswerCmd+{�5   %   �� *CheckAnswerButtonEnable+�� 5�   "   #��[ 6)   $��2 0 0 0q�5�   %   $��Reveal��5�   %   $��50��5�   %   $��12(�5�   %   
���  ��
�������$��7q�5�   %   $��0q�5�   %   ��5�   %   �� *	RevealCmd+{�5�   %   �� *RevealButtonEnabled+�� 5�   "   #��[ 6)   $��2 0 0 0q�5�   %   $
��Next��5�   %   $��50��5�   %   $��12(�5�   %   
������
�������$��0q�5�   %   $��7q�5�   %   ��5�   %   �� *	SkipCmd+5�      5�      5�      5�      5�      5�      5�      5�      