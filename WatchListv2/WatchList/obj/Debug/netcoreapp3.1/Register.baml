   M S B A M L   `   `   `  ����D  @WatchList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WatchList	WatchList  5          WatchList.Register   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WatchList     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6-     N� Title$  Register��5      $	��520��6   $	��380��6%   .��5
      � .+�5   
   �  � RowDefinitions 5      �� 5      $��25 �6    �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��3��6'   ��5      �� 5      .��5      �  � Color$ #252525��6'    � Offset$	 0.0Q�67   � 5      $ #055428��6'   $ 1Q�67   5      5      �� 5      $ 	10,10,0,0��6   ���#2525255      �� 5      $��0��6   $��Center=�6&   .+�5      �  � ColumnDefinitions 5       �� 5!      $	��200 �6+   �� 5"      .+�5%      �� $��2��6   ._�5&      � .+�5'      �� $��	WatchList��6$   
�������68   �� 5)      $��Right=�6)    �� Orientation$ 
Horizontal=�6E   .+�5+   "   �� -   5        $��20��5+   )   $��20��64   $	��✕��5,   )   
������ $��0q�5.   )   
�������$
��Bold"�50   )   6;   52      53      54      56      59      �� 5;      $��1��6   $��Center=�6&   .+�5<      �� -   5        $��
ErrorLabel��5<   M   $��Label��6   
���  ��$y�Hidden=�69   $��0,8,0,0q�6_   �� 5=      $J��DC:\Users\guial\source\repos\WatchList\WatchList\Images\Logo_copy.png��6   $	��400��6g   5>      �� 5@      $��2��6   .+�5A      �� $ 
Horizontal=�6   .+�5B      �� -   5        $��Registo_username��5O      $��	Helvetica)�5B      $��Light"�5C      $��Nome de utilizador��5D      $��20(�5E      $��Center=�5F      
�������
������ $��0q�5I      $	��233��5J      $
��Left=�5K       J� Opacity$	 0.5Q�5L      $��25��5M      $��63,0,0,0q�5N      5Q      .  (MahApps.Metro.IconPacks.PackIconMaterial  5R         Kind$ Account=�61   $��Center=�5S   1   $��Center=�5T   1   
�������5U   1   5V      �� 5W      $	��250��6   $��2��5X      
�������$	 0.5Q�5Z      � 5^      $��0,20,0,0q�6   .+�5_      G� -   5        $��Registo_password��5k      $��	Helvetica)�5_   "   $��Light"�5`      	 G� Password$	 Password��5a      $��20(�5b      $
��Left=�5c      
�������
������ $��0q�5f      $	��230��5g      $
��Left=�5h      $	 0.5Q�5i      $��25��5j      
 G� PasswordChar$	
 •��5l      $��63,0,0,0q�6/   5n      �� 5p      -   5        $��Registo_password_show��5{      $��	Helvetica)�5p      $��Light"�5q      $��20(�5r      $
��Left=�5s      
�������
������ $��0q�5v      $	��230��5w      $
��Left=�5x      $	 0.5Q�5y      $��25��5z      $��Password��5|      $y�Hidden=�5}      $��63,0,0,0q�5~      �� 5�      -   5         ��Name$ btnPass��5�      $��2q�5�      $
��Left=�6)   $��Center=�5�      $��Center=�5�      
������ $��1q�5�      
�������$��	293,0,0,0q�5�   1   .��5�        $ FormTextboxPassword=�65   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      5�      �� 5�      $	��250��6   $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5�      �� -   5        $��Registo_email��5�      $��	Helvetica)�5�      $��Light"�5�      $��Email��5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��233��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      5�        5�      $ Email=�61   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      �� 5�      $	��250��6   $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5�      �� -   5           lognRegStyle#��[  5�      $	��100��6C   $��40��6O   $
��Back��6[   $��	60,0,60,0q�6j   6}   �� 5�      -	   5        #��[  5�      $	��100��6D   $��40��6P   $��REGISTER��6\   6o   5�      5�      5�      5�      5�      