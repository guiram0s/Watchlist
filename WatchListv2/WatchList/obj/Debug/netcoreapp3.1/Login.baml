   M S B A M L   `   `   `  ����D  @WatchList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WatchList	WatchList  5          WatchList.Login   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WatchList     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6-     N� Title$  Login��5      $	��520��6   $	��380��6"   .��5
      � .+�5   
   �  � RowDefinitions 5      �� 5      $��25 �6    �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��3��6'   ��5      �� 5      .��5      �  � Color$ #252525��6'    � Offset$	 0.0Q�67   � 5      $ #055428��6'   $ 1Q�67   5      5      �� 5      $ 	10,10,0,0��6   ���#2525256.   �� 5      $��0��6   $��Center=�6&   .+�5      �  � ColumnDefinitions 5       �� 5!      $	��200 �6+   �� 5"      .+�5%      �� $��2��6   ._�5&      � .+�5'      �� $��	WatchList��6$   
�������68   �� 5)      $��Right=�6)    �� Orientation$ 
Horizontal=�6E   .+�5*   "   �� $��20��6)   $��20��64   $
��🗕��5+   )   
������ $��0q�5-   )   
�������$
��Bold"�5/   )   $��0,0,0,3q�50   )   �� 52   "   $��20��6)   $��20��64   $	��☐��53   )   
������ $��0q�55   )   
�������$
��Bold"�57   )   �� 59   "   -   5        $��20��59   )   $��20��64   $	��✕��5:   )   
������ $��0q�5<   )   
�������$
��Bold"�5>   )   6;   5@      5A      5B      5D      5G      �� 5I      $��1��6   $��Center=�6&   .+�5J      �� $J��DC:\Users\guial\source\repos\WatchList\WatchList\Images\Logo_copy.png��6   $	��400��6g   5K      �� 5M      $��2��6   .+�5N      �� $ 
Horizontal=�6   .+�5O      �� -   5         ��Name$ login_username��5[      $��	Helvetica)�5O      $��Light"�5P      $��Nome de utilizador��5Q      $��20(�5R      $��Center=�5S      
�������
������ $��0q�5V      $	��235��5W      $
��Left=�5X       J� Opacity$	 0.5Q�5Y      $��25��5Z      $��63,0,0,0q�5\      5^      .  (MahApps.Metro.IconPacks.PackIconMaterial  5_      	   Kind$	 Account=�61   $��Center=�5`   1   $��Center=�5a   1   
�������5b   1   5c      �� 5d      $	��250��6   $��2��5e      
�������$	 0.5Q�5g      �� 5k      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5l      G� -   5        
 G�Name$
 login_password��5x      $��	Helvetica)�5l   "   $��Light"�5m       G� Password$ Password��5n      $��20(�5o      $��Center=�5p      
�������
������ $��0q�5s      $	��235��5t      $
��Left=�5u      $	 0.5Q�5v      $��25��5w      $��63,0,0,0q�5y      5{        5|      $	 FormTextboxPassword=�61   $��Center=�5}   1   $��Center=�5~   1   
�������5   1   5�      �� 5�      $	��250��6   $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0,30,0,0q�66   .+�5�      �� -   5           lognRegStyle#��[  5�      $	��100��6C   $��40��6O   $��LOGIN��6[   $��	60,0,60,0q�6k   6~   �� 5�      -   5        #��[  5�      $	��100��6D   $��40��6P   $��REGISTER��6\   6o   5�      �� 5�      $ 
Horizontal=�6   $��Center=�66   $��0,20,0,0q�6S   .+�5�      �� -   5          normalBtnStyle#��[ 5�      $	��155��6E   $��28��6Q   $!��Perdi a minha palavra-passe��6]   6�   5�      5�      5�      �� 5�   
   -   5        $��label_login��5�      
���  ��$��Label��64   $y�Hidden=�6D   $��0,242,0,252q�6X   5�      5�      