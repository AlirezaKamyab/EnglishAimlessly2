   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   )    #EnglishAimlessly2.View.PracticeView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	   $	��600��5      $
��1000��6'   .��5
      �� $��1q�6   
���   �
�������._�5   
   �   � RowDefinitions  5      �� 5      $��25 �6    �� 5      .+�5      �� $��25��6   ���	#FF3A639E$��0q�5      ._�5      ]� $	��0 0q�6   .+�5      �� $��Center=�6    $��15(�5       $	��5 0q�5       
��������� 5      
��� ����62   �� *SelectedGroup.Name+5      �� 5         
RectButton#��[  6   $��Center=�5      
���  ��$��×��5      $��25��5      $��25��5      $��	ExtraBold"�5       
�������$��Right=�5"      
������ ��5$      �� *ClosePracticeCmd+5%      5&      � 5(      $��1��6   ���#fff  5*      �� 5+      $	��100 �6$   �� 5,      $��3* �6$   �� 5-      $��* �6$   .+�50      �� -   5         ��Name$ pnlCard��50      $��1��6*   ���	#FFF1F1F1 �� CornerRadius$ 10��51      $��5q�52      ._�54      � $��Center=�6   .+�55      �� -   5         ��Name$ pnlError��55   %   $��Center=�56   %   y�55   7   �� *ErrorPanelVisibility+.+�57      �� $��20(�6(   $��No word for practice��66    �� TextAlignment$ Center=�6R   ��58   "   �� 59   &    �� EndPoint$ 1,0.5&�6:    �� 
StartPoint$ 0,0.5&�6K   .��5:   *   �  � Color$ 	#FF4F00FF��67   � 5;   *   $	 Red��67    � Offset$ 1Q�6C   � 5<   *   $ 	#FF2BAD52��67   $
 0.51Q�6I   5=   '   5?      5@      � 5A      -   5        	 �Name$	 
stackPanel��5A      y�5B   %   �� *ControlPanelVisibility+.+�5C      �� $��0 10 0 0q�6)   .+�5E   "   �� ���	#FFE9E9E9$
��10 0q�6@   $ 8��5F   )   
 �� Padding$
 2q�6:   ._�5G   &   �� -   5         ��Name$ txtWord��5G   0   $��18(�6A   $
��Bold"�5H   0   $ Center=�5I   0   �� 5J   *   �6.   �� *SelectedWord.Name+ �� 5K   *   
���  ���6?   �� *SelectedWord.WordType+ �� StringFormat$
  {0}��5L   '   5M   #   �� 5O   "   -   5        $ txtEquivalent��5P   ,   $��14(�5O   ,   $ Center=�5Q   ,   $��5 5 5 0q�5R   ,   $��SemiBold"�5S   ,   y�5T   ,   �� *AnswerVisibility+�� 5U   "   �6&   �� *SelectedWord.Equivalent+5V   #   �� 5X   "   $��Hidden=�6/   $	��225��5Y   +   $��10q�68   $	��650��6D   $��False��5Z   +   y�5[   +   �� *AnswerVisibility+.��5\   &   �� .+�5]   *   �� $

 0 10q�61   $��10 0 0 0q�6@   
������$ 10��5_   1   ._�5`   .   �� $��14(�68   $��10 0 0 0q�5a   8   $y�Visible=�5b   8   $
��Wrap=�5c   8   �� 5d   2   �66   �� *SelectedWord.Description+5e   /   5f   +   5g   '   5h   #   5i      � 5k      $��Bottom=�6$   $��0 0 0 10q�5l   )   .+�5m   "   �� $��12(�6-   $��0 0 0 0q�6;     PracticeExampleBox#��[ 5n   -    �� 	MaxLength$	 250��5o   -   $
��Left=�6=   $	��650��5p   -   $��7q�5q   -   �� 5s   "    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   $��Center=�5t   -   .+�5u   &   �� $��20��6-   $��20��68   $��0 0 5 0q�5v   -   $��0q�5w   -   
������ y�5y   -   �� *ShowButtonVisibility+��5z   -   �� *ShowAnswerCmd+.��5{   *   �� $)��#/Resources/Images/Icons/lightOn.png��60    �� BitmapScalingMode$ HighQuality=�5|   ,   5}   '   �� 5   &   $��20��6-   $��20��5�   )   $��0 0 25 0q�5�   )   
������ $��2q�5�   )   $��0q�5�   )   ��5�   )   �� *OpenHistoryCmd+.��5�   *   �� $-��'/Resources/Images/Icons/historyIcon.png��60   $ HighQuality=�5�   ,   5�   '   5�   #   5�      5�      5�      5�      �� 5�      -   5        $ 
pnlButtons��5�      $��2��5�      $��1��6*   $��Center=�6:   $��Center=�6U   $ 
Horizontal=�5�      y�5�      �� *ControlPanelVisibility+.+�5�      �� -   5         ��Name$ btnNextHours��5�        CurveButton#��[ 5�      $��Right=�5�      $��
Next Hours��5�      $	��100��5�      $��10q�5�      $��5q�5�      $��11(�5�      
����������#444$��0q�5�      $��4��5�      ��5�      �� *NextWordPracticeCmd+�� 5�      -   5        $ btnNextHard��5�      #��[ 5�      $��Right=�5�      $
��Hard��5�      $	��100��5�      $��10q�5�      $��11(�5�      
���  ��
�������$��0q�5�      $��5q�5�      $��3��5�      ��5�      �� *NextWordPracticeCmd+�� 5�      -	   5        $ btnNextNormal��5�      #��[ 5�      $��Right=�5�      $��Normal��5�      $��10q�5�      $	��100��5�      $��11(�5�      
��� ���
�������$��5q�5�      $��0q�5�      $��2��5�      ��5�      �� *NextWordPracticeCmd+�� 5�      -
   5        $ btnNextEasy��5�      #��[ 5�      $��Right=�5�      $
��Easy��5�      $��10q�5�      $	��100��5�      $��11(�5�      
����  �
�������$��5q�5�      $��0q�5�      $��1��5�      ��5�      �� *NextWordPracticeCmd+5�      5�      5�      5�      5�      