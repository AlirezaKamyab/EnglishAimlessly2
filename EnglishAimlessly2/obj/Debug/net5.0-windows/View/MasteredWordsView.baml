   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   .    (EnglishAimlessly2.View.MasteredWordsView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	   $	��600��5	   	   $
��1000��6   .��5      � 
�������  � RowDefinitions  5   
   �� 5      $��25 �6   �� 5      .+�5   
   �� $��0��6   ���#eee._�5      � -   5        .+�5      �� $��Mastered Words��6   $��14(�5      $
��Bold"�5      $��Center=�5      $��10 0 0 0q�5      ���#eee5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5      �� $��25��6   
���  ��
�������$��	ExtraBold"�5"      $��0q�5#      $��X��5$      $��14(�5%      $��2q�5&      ��5'      �� *CloseToMainMenuCmd+5(      5)      5*      � 5,   
   $��1��6    � ColumnDefinitions 5-      �� 5.      $	��350 �6#   �� 5/      .+�53      �� $��0��6    �� CornerRadius$ 0 8 8 0��6%   ��54      �� 55       �� EndPoint$ 1,0.5&�6*    �� 
StartPoint$ 0,0.5&�6;   .��56      �  � Color$ 	#FF6F95DC��6'    � Offset$ 0.006Q�69   � 57      $ 	#FF224C9A��6'   $ 1Q�69   58      ._�5:      �   5;      �� 5<      $��30 �6(   �� 5=      .+�5A      � $��0��6   .+�5B      �� ���#eee$��16(�5D   $   $
��Bold"�5E   $   $��10 0 0 0q�5F   $   $��Center=�5G   $   ��5B   $   �� *
Group.Name+5G   $   5H      � 5K      $��1��6   .+�5L      �� 
������ $��0q�5M   #      MasterWordItem#��[  5N   #   $��False��5P   #   ��5O   #   �� *MasterWords+ �� SelectedValue 5Q   #   �� *SelectedWord+5S      5T      5U      5V      �� 5X      $��1��6   y�6)   �� *PanelVisibility+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.+�5Z      �� $��20 10q�6   $ 10��5[      $��0q�6+   ���	#FFF65B3D �� Padding$ 10q�5\      ._�5]      �� .+�5^      �� $��10 10q�6$    �� TextAlignment$ Center=�5_   $   $��18(�6;   
��������� 5a      �6"   �� *SelectedWord.Name+ �� 5b      $�(��6"    �� 5c      �6"   �� *SelectedWord.WordType+ �� 5d      $�)��6"   5e      �� 5f      $����This word is considered mastered, try a bit more to make this word a habit by doing Master Practice. This way you can gain score for this word faster��6$   $��10 10q�5g   $   $
��Wrap=�5h   $   $��12(�5i   $   
�������5j   $   �� 5k      $��10 10q�6$   �� 5l      $�Score: ��6"   
�������61    �� 5m      
��� ����6"   �� *SelectedWord.Score+6F   5n      5o      5p      �� 5r      $��20 10q�6   $ 10��5s      $��0q�6+   ���#dedede$ 10q�5t      ._�5u      �� .+�5v      �� $��Practice Settings��6$   $��	10 10 0 0q�6=   $ Center=�5w   $   $��18(�6;   ���#3335x   $   �� 5y      $��0 5 0 0q�6$   $ Center=�65   �� 5z      $�Last practice on ��6"   ���#3336;    �� 5{      
���  ���6"   �� *SelectedWord.UpdatedDate+6L    �� 5|      $�and total practices is ��6"   ���#3336A    �� 5}      
���  ���6"   �� *SelectedWord.PracticeCount+6N   5~      �� 5�      $��0 10 0 0q�6$   $
��Wrap=�66   $ Center=�6J   �� 5�      $\�VYou can have your checkpoint set so you practice the word again and reset the duration��6"   ���#4445�   "    �� 5�      $)�#without reseting scores and history��6"   
������6M   5�      �� 5�      $ 
Horizontal=�6%   $��10q�6>   $��Center=�5�   %   .+�5�      ��   CurveButton#��[ 6%   $��
CheckPoint��6J   $��5q�5�   %   ��5�   %   �� *CheckPointCmd+5�      5�      5�      �� 5�      $��20 10q�6   $ 10��5�      $��0q�6+   ���	#FF8BBFF1$ 10q�5�      ._�5�      �� .+�5�      �� $��Target��6$   $��10 5 0 0q�62   $ Center=�5�   $   $��18(�6;   
�������5�   $   �� 5�      $��15(�6$   �� 5�      $�Score ��6"    �� 5�      
���  ���6"   �� *SelectedWord.Score+6F    �� 5�      $
� of ��6"    �� 5�      $�10000��6"   ���	#FFFCFF176/   5�      � 5�      $��15��6&    � Maximum$ 10000Q�5�   &   ���	#FF03FF00
������� � Value 5�   2   �� *SelectedWord.Score+5�   &   5�      5�      5�      5�      5�      5�      