   M S B A M L   `   `   `  ����  MusicApp"    MusicApp.Search.SearchWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Search - Music App��5   	   $	��600��6$   $	��800��61   ���#121212$2��,Helvetica Neue, Helvetica, Arial, sans-serif)�5      .��5      �� $
��Auto=�6   .��5   
   �  � ColumnDefinitions 5   
   �� 5	      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� ���#191414���#888$��1q�69    �� CornerRadius$ 10��6M   $��40q�6_   ._�5      �  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Search��6   $��24(�6*   ���#9f61e2$��Center=�6M   $
��0,20q�6j   �� 5      -   5         ��Name$ 
searchArea��5      $��1��61   $��20q�6>   .+�5      �� -   5         ��Name$ searchInput��5      $��Enter keywords to search��63   ���#333
�������$��10q�5       $
��0,10q�6+   $��0q�69   
������ 6M   �� 5!      -   5         ��Name$ filterComboBox��5!   #    �� SelectedIndex$ 0��6;   $
��0,10q�6M   .@�5"      �� $��	No filter��6'   �� 5#      $
��Song��6'   �� 5$      $��Artist��6'   �� 5%      $��Album��6'   �� 5&      $��Genre��6'   �� 5'      $
��User��6'   5(      �� 5*      -   5        $ 
genreInput��5*      $��Enter genre to filter��62   ���#333
�������$��10q�5+      $
��0,10q�6"   $��0q�60   
������ $y�	Collapsed=�6^   �� 5-      -   5        $ sortComboBox��5-      $ 0��65   $
��0,10q�6G   .@�5.      �� $��	Relevance��6'   �� 5/      $��
Popularity��6'   �� 50      $��Release Date��6'   �� 51      $��Alphabetical��6'   52      �� 53      -   5        $��Search��53      ���#1DB954
�������$��10q�6V   $
��0,10q�6c   $��0q�6q   $��Stretch=�54      6;   �� 56      -   5        $ searchResultsStackPanel��56   !   $��1��6B   $
��Auto��6R   $
��Auto��6`   $��
427,60,0,0q�6m   $��2��6�   $	��Top=�6�   $
��Left=�6�   57      58      59      5:      5;      5<      