   M S B A M L   `   `   `  ����L  HEnglishAimlessly2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EnglishAimlessly2.ViewModelEnglishAimlessly2.ViewModel  5   	   ?$clr-namespace:EnglishAimlessly2.ViewEnglishAimlessly2.View  5   	   (    "EnglishAimlessly2.View.AddWordView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:EnglishAimlessly2.ViewModel     5   	   6local$clr-namespace:EnglishAimlessly2.View     5   	     � Title$  Add Page��5	   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ CenterOwner=�5
   	   .��5      � ���#c33124 � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��13* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6   ���#666$��1q�6A    �� CornerRadius$ 10��6U   
�������._�5      � $��10q�6   .+�5      �� .+�5      �� $��Add Word��6     �� TextAlignment$ Center=�5       $��20(�5        �� Padding$ 5q�5        $��5q�5!       � 5"      $��5q�6    5#      �� 5$      $��* �6/   �� 5%      $��* �6/   .+�5'      �� $��	0 0 2.5 0q�6%   .+�5(      �� $��	Word Name��6(   �� 5)         
NewTextBox#��[  6&   $��0 5 0 0q�6J    �� 	MaxLength$ 30��5+   &   ��5*   &   �� *
WordName+ �� Mode$ TwoWay=�5+   &   5,      �� 5.      $��	2.5 0 0 0q�6%   $��1��68   .+�5/      �� $��	Word Type��6(   �� 50      #��[  6&   $��0 5 0 0q�6J   $ 20��52   &   ��51   &   �� *
WordType+$ TwoWay=�52   &   53      54      �� 56      $	��5 0q�6    $��
Equivalent��6-   �� 57      #��[  6   $��5q�58      $ 60��5:      ��59      �� *
Equivalent+$ TwoWay=�5:      �� 5<      $	��5 0q�6    $��Description��6-   �� 5=      #��[  6   $��5q�5>      $��False��5?      $	��100��5@      	 �� TextWrapping$
	 Wrap=�5A      
 �� MaxLines$
 10��5B       �� AcceptsReturn$
 True��5C       �� 
AcceptsTab$
 True��5D      ��5E      �� *Description+$ TwoWay=��� 5G      -   5          CurveButton#��[ 5G      $
��0 10q�5H      $��Center=�5I      $	��Add��5J      $
��10 5q�5K      ��5L      �� *
AddWordCmd+5M      5N      5O      5P      5Q      5R      