   M S B A M L   `   `   `  ����D  @WatchList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WatchList	WatchList  5   	       WatchList.MovieWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WatchList     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6/   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � Title$ MovieWindow��5   	   $	��400��6   $	��678��6*    � 	Resources 5      .  (MahApps.Metro.IconPacks.PackIconMaterial   Play   Kind J� RenderTransformOrigin 	 Pause��%�   &	        &	 X       5   
   $
 Play=�62   
�������$ 0.5,0.5&�6Q   $��30��6q   $��30��6}     5   
   $ Pause=�63   
�������$ 0.5,0.5&�6S   $��30��6s   $��30��6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      .+�5   
   �� $��0��6   	 �� CornerRadius$	 5,5,0,0��6   ���#252525._�5      � .+�5      �� $��	WatchList��6   
�������6,   �� 5      $��Right=�6   
 �� Orientation$
 
Horizontal=�69   .+�5      �� -   5        $��20��5      $��20��6(   $	��✕��5   )   
������ $��0q�5    )   
�������$
��Bold"�5"   )   6;   5$      5%      5&      �� 5(   
   $��1��6   $	 	0,0,10,10��6   ��5)      �� 5*      .��5+      �  � Color$ #252525��6#    � Offset$	 0.0Q�63   � 5,      $ #055428��6#   $ 1Q�63   5-      5/      � 51   
   $��1��6   .+�53      �� -   5        $��Titulo��53      $��Label��6"   
�������$��14(�6E   $
��Left=�6S   $��	10,10,0,0q�6n   $	��Top=�6�   $��30��6�   $	��301��6�   $ 0.516,0.513&�6�   �� 54      -   5        $��resumo��54      $��	TextBlock��6&   $
��Wrap=�67   $��426,57,26,100q�6K   
�������$��12(�6u   �� 55      -   5          normalBtnStyle#��[ 55      $��	Adicionar��6L   $
��Left=�6`   $��
10,320,0,0q�6{   $	��Top=�6�   $��21��6�   $��62��6�   r� 56      -   5        $��video��56   l    r� LoadedBehavior$ Manual=�6;    r� UnloadedBehavior$
 Stop=�6T   $
��Left=�6y   $	��244��6�   $��	10,57,0,0q�6�   $	��Top=�6�   $	��401��6�   �� 57      -   5        $��duracaoSlider��57   ;     video_Slider#��[ 6   $
��Left=�6P   $��
10,290,0,0q�6k   $	��Top=�6   $	��396��6�   $��22��6�   6�   �� 58      $	��Vol��6   $
��Left=�6"   
�������$��270,315,0,0q�6P   $	��Top=�6e   �� 59      -   5        $��
PlayButton��59   .   
������ $
��Left=�6@   $��176,313,0,0q�6[   $	��Top=�6p   .��5:      C�  C� ResourceKey$
 Play��6"   5;      �� 5<      -	   5        $��	volSlider��5<   <     volume_Slider#��[ 6   $
��Left=�6M   $	��Top=�6h   $��92��6�   $��22��6�   $��302,319,0,0q�6�   6�   �� 5=      -
   5        $��rateComboBox��5=      ���#055428$
��Left=�6@   $��
568,18,0,0q�6[   $	��Top=�6o   $��84��6�    �� 
IsReadOnly$
 True��6�   .@�5>      �� $��1��6   �� 5?      $��2��6   �� 5@      $��3��6   �� 5A      $��4��6   �� 5B      $��5��6   5C      �� 5D      -   5        $��	rateLabel��5D      $��Rate:��6%   
�������$��13(�6H   $
��Left=�6V   $��
510,15,0,0q�6q   $	��Top=�6�   $��54��6�   �� 5E      
�������$��Avg Rating:��6'   $��13(�6=   $
��Left=�6K   $��
331,15,0,0q�6f   $	��Top=�6z   �� 5F      -   5        $��avgRateLabel��5F      $��Label��6(   
�������$��13(�6K   $
��Left=�6Y   $��
411,15,0,0q�6t   $	��Top=�6�   �� 5G      -   5        $��statusLabel��5G      $��Status:��6'   
�������$��13(�6L   $
��Left=�6Z   $��449,316,0,0q�6u   $	��Top=�6�   $��54��6�   �� 5H      -   5        $��statusComboBox��5H      ���#055428$
��Left=�6C   $��510,321,0,0q�6^   $	��Top=�6s   $	��127��6�   $
 True��6�   .@�5I      �� $��Visto��6   �� 5J      $��Em pausa��6   �� 5K      $��A ver��6   �� 5L      $��Largado��6   �� 5M      $��Planeio ver��6   5N      5O      5P      5Q      