   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=0.5.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   O,clr-namespace:EnglishAimlessly2.UserControlsEnglishAimlessly2.UserControls  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   '    !EnglishAimlessly2.View.ManageView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   ;uc,clr-namespace:EnglishAimlessly2.UserControls     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	     � Title$  Manage Page��5
   	   $	��600��6   $	��900��6*    � WindowStartupLocation$ CenterOwner=�5   	    � WindowStyle$
 None=�5   	    � 	Resources 5      +   %EnglishAimlessly2.ViewModel.ManagerVM   mvm��%   &	          5   
   6   5      .��5      ]�  � DataContext# [  6   .+�5   
   �� $	��Top=�6    �� CornerRadius$ 	0 0 20 20��6&   $��35��5      $��0 0 0 5q�5       �� Padding$ 5q�5      ���#4c394f._�5      ]� $
��10 0q�6   .+�5!      �� -   5         ��Name$ btnAdd��5"        CurveButton#��[ 5!      
������$	��Add��5$      $��75��5%      
�������$
��10 0q�5'      $
��Left=�5(      $
��Left=�5)      $��0 0 0 0q�5*      
������ 5,      �� 5.      -   5        $ btnAddTogether��5/      #��[ 5.      
������$��Add All��51      $��75��52      
�������$
��10 0q�54      $
��Left=�55      $
��Left=�56      $��5 0 0 0q�57      
������ 59      �� 5;      -   5        $ btnClose��5<      #��[ 5;      
���  ��$��Close��5>      $��65��5?      
�������$
��10 0q�5A      $��Right=�5B      $��Right=�5C      $��5 0 0 0q�5D      
������ 5F      5G      5H      �� 5J   
   $
��Left=�6   $	��350��6'   ���#fff$��0 2 2 2q�5K      ���#888$ 	0 20 20 0��5M      $��0 5 0 5q�5N      ._�5O      �  � RowDefinitions 5P      �� 5Q      $��* �6$   �� 5R      $
��3.5* �6$   .+�5U      �� $��10q�6   .+�5V      �� $��Words��6    $��25(�5W       	 �� TextAlignment$	 Center=�5X       $
��Bold"�5Y       ���#2225Z       �� 5\      $��5 10 0 3q�6    $��Input word to search��5]       ���#2225^       �� 5`      
 �� Orientation$
 Vertical=�6!   .+�5a      �� -   5         ��Name$ txtWordName��5a   "     
NewTextBox#��[ 67   ��5b   "   �� *SearchWordName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5c   "   5d      5e      � 5g      $��5q�6   $	��Top=�6"   $��1��67   .+�5h      �� -   5         ��Name$ lstView��5h      $��0q�60   
������ $��Hidden=�5j      ��5k      �� *
WordList+ �� SelectedValue 5l      �� *SelectedWord+$ TwoWay=�$ PropertyChanged=���5m      �� 5n       �� 
TargetType" ��6$   .�5o   "   ��  �� Property � �� �� Value$ Stretch=�6O   �� 5p   "    � ��$ 0 0 0 5q�6;    �� Triggers 5r   "   P� 5s   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5t   *   ��  � ��
 �   �6G   5u   '   5w      ��5z      �� 5{      .R�5|   "   4   .EnglishAimlessly2.UserControls.WordItemControl  $	��320��6F   $��75��6R      Word 65   �� 6R   5}      5      5�      5�      5�      �� 5�   
   -   5         ��Name$ 
borderMain��5�      $
��Left=�6%   $
��10 5q�6;   $��2q�5�      ���#eee$ 	20 1 20 1��5�      ._�5�      �  5�      �� 5�      $��2* �6$   �� 5�      $��5* �6$   .+�5�      �� $��1q�6   ���#888$��10q�6@   $ 	20 1 20 1��5�      $��0��62   ._�5�      �� $
 Vertical=�6!   $��10q�5�   !   .+�5�      �� $��16(�6H   $	 Center=�6V   ��6$   �� *SelectedGroup.Name+6V   �� 5�      $��Hidden=�6'   $��50��6Y   .��5�      �� $��0 5 0 0q�6(   $
��Wrap=�69   �� 5�   "   ���#888$�Description:��68    �� 5�   "   �6&   �� *SelectedGroup.Description+$ TwoWay=�5�      5�      �� 5�      -   5        $ btnGroupSettings��5�   !   #��[ 5�   !   $��0 10 0 0q�5�   !   $
��Edit��5�   !   
�������$��Center=�5�   !   $
��15 3q�5�   !   $��2q�5�   !   5�   !   5�      5�      �� 5�      -   5        $ borderDetails��5�      $��1q�60   ���#fff$��10q�6W   $ 	20 1 20 1��5�      $��1��62   ._�5�      �� $
 Vertical=�6!   $��10q�5�   !   .+�5�      �� $��16(�6$   $	 Center=�62   $��0 5 0 0q�6I   �� 5�      �6"   �� *SelectedWord.Name+$ TwoWay=� �� 5�      
���  ���63   �� *SelectedWord.WordType+$ TwoWay=� �� StringFormat$
  {0}��5�      �� 5�      $��0 5 0 0q�6$   $
��Bold"�65   �� 5�      ���#555$�Equivalent:��64    �� 5�      �6"   �� *SelectedWord.Equivalent+$ TwoWay=�5�      �� 5�      $��10q�6!   ���#888$��1q�6@   $ 10��6T   ._�5�      �� $��Hidden=�6+   $��10q�6]   
������ $	��150��5�   +   .��5�   "   �� $��0 0 0 0q�6,   $
��Wrap=�5�   ,    �� LineStackingStrategy$ 	MaxHeight=�6@   �� 5�   &   ���#888$�Description:��6<    �� 5�   &   �6*   �� *SelectedWord.Description+$ TwoWay=�5�   #   5�      5�      ]� 5�      $��0 10 0 0q�6$   .+�5�      �� $
��Left=�6(   �� 5�   "   ���#888$�Last Practice��68    �� 5�   "   
���  ���67   �� *LastPracticed+$ OneWay=�5�      �� 5�      $��Right=�6(   $��Right=�5�   (   �� 5�   "   ���#888$�	Practiced��68    �� 5�   "   
���  ���67   �� *SelectedWord.PracticeCount+$ TwoWay=� �� 5�   "   ���#888$�time(s)��68   5�      5�      �� 5�      $
��0 30q�6%   $��Center=�63   $
 
Horizontal=�6P   .+�5�      �� -	   5        $ btnEdit��5�   %   #��[ 5�   %   $
��Edit��5�   %   
�������
���   �$	��5 0q�5�   %   $��10q�5�   %   $	��100��5�   %   $��2q�5�   %   5�   %   �� 5�      #��[ 6%   $��Reset��5�   %   $	��5 0q�5�   %   
�������
���   �$��10q�5�   %   $	��100��5�   %   $��2q�5�   %   ��5�   %   �� *ResetWordCmd+�� 5�      #��[ 6%   $��Remove��5�   %   
�������
���   �$	��5 0q�5�   %   $��10q�5�   %   $	��100��5�   %   $��2q�5�   %   ��5�   %   �� *RemoveWordCmd+5�      5�      5�      5�      5�      5�      5�      