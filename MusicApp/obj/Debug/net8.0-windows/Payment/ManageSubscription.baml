   M S B A M L   `   `   `  ����  MusicApp)    #MusicApp.Payment.ManageSubscription   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  ManageSubscription��5   	   $	��451��6$   $	��915��61    � 	Resources 5       �� 
TargetType   	PlanStyle �� Property �� Value  SubscribeButtonStyle �� Triggers P� Property P� Value��%!  &	        &	 <    �� 5	   
   " ��6   .�5
      ��  � �� �#3336+   �� 5       � ��$	 180��6&   �� 5       � ��$	 200��6'   �� 5       � ��$ 10q�6'   �� 5       �@��Padding$ 20q�6(   �� 5       �@��CornerRadius$ 10��6-   �� 5       � ��$
 Left=�64   5      �� 5   
   " ��6   .�5      ��  � �� �#1DB9546+   �� 5       � ��
 �����6+   �� 5       � ��$ 10,20q�6(   �� 5       � ��$ 14(�6)   �� 5       � ��$ 0q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 0,10,0,0q�6'    5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� �#17a74b63   5      5       5!      .��5"      � ���#191414$��0,0,0,-6q�6     � ColumnDefinitions 5#   
   �� 5$      $	��26* �6   �� 5%      $
��175* �6   �� 5&      $
��137* �6   �� 5'      $
��362* �6   �� 5(      $
��400* �6   .+�5*   
   �� ���#191414	 �� CornerRadius$	 10��6&   $��	18,47,0,0q�68   
 �� Padding$
 20q�6K   $
��Left=�5+      $	��Top=�6,   $��4��6D   $��1��6X   ._�5,      �� .+�5-      �� $��Manage Subscription��6   $��24(�67   $
��Bold"�6E   ���#9f61e2$��Center=�5.   1   $��0,0,0,20q�6N   � 5/      $��Center=�6   $	��Top=�69    � Orientation$ 
Horizontal=�6Q   .+�50      �� #��[  6   ._�51      �� .+�52      �� $��Monthly Plan��6(   $��18(�6<   $
��Bold"�6J   �� 53      $��Price: $4.95/month��6(   �� 54      $4��.Next Expire Date: [Calculate and Display Here]��6(   �� 55      -   5        #��[ 55   %   .��6m   	Subscribe6x   56      57      �� 58      #��[  6   ._�59      �� .+�5:      �� $��3-Month Plan��6(   $��18(�6<   $
��Bold"�6J   �� 5;      $ ��Price: $12.99 for 3 months��6(   �� 5<      $4��.Next Expire Date: [Calculate and Display Here]��6(   �� 5=      -   5        #��[ 5=   %   .��6p   	Subscribe6{   5>      5?      �� 5@      #��[  6   ._�5A      �� .+�5B      �� $��6-Month Plan��6(   $��18(�6<   $
��Bold"�6J   �� 5C      $ ��Price: $22.90 for 6 months��6(   �� 5D      $4��.Next Expire Date: [Calculate and Display Here]��6(   �� 5E      -   5        #��[ 5E   %   .��6n   	Subscribe6y   5F      5G      �� 5H      #��[  6   ._�5I      �� .+�5J      �� $��Yearly Plan��6(   $��18(�6;   $
��Bold"�6I   �� 5K      $��Price: $39.95/year��6(   �� 5L      $4��.Next Expire Date: [Calculate and Display Here]��6(   �� 5M      -   5        #��[ 5M   %   .��6l   	Subscribe6w   5N      5O      5P      5Q      5R      5S      5T      