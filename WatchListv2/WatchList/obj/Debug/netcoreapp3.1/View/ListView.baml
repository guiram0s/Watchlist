   M S B A M L   `   `   `  ����D  @WatchList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WatchList.ViewWatchList.View  5          WatchList.View.ListView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WatchList.View     5      
������ .��5
      � $��
40,33,33,0q�6     � ColumnDefinitions  5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��datagridList��5         HeadersVisibility$ Column=�6'   $��20,10,19,10q�6B      AutoGenerateColumns$ False��6W      DataGridRowStyle   RowStyle# �   6s     DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 6�     ForegroundWhite#���  6�     NormalColor#���  6    DataGridCellStyle   	CellStyle# �  6;     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Titulo ��6)      CellTemplate 5      �� 5      .R�5      �� ��6(   �� *titulo+6B   5      5        5      $  Duração ��6)    5      �� 5      .R�5      �� ��6(   �� *	duracao+6C   5      5        5!      $  Ano ��6)    5"      �� 5#      .R�5$      �� ��6(   �� *ano+6?   5%      5'        5)      $  Your Rating ��6)    5*      �� 5+      .R�5,      �� ��6(   �� *rating+6B   5-      5/        51      $  Status ��6)    52      �� 53      .R�54      �� ��6(   �� *status+6B   55      57        59       5:      �� 5;      .R�5<      �� -   5        
���   �
�������.��5<   `   	Details6i   5=      5?        5A       5B      �� 5C      .R�5D      �� -   5        
�������
���   �.��5D   Z   Remove6b   5E      5G      	 � 	Resources	 5K      *  $System.Windows.Controls.DataGridCell
 �� 
TargetType  
ColumnGone �� Property �� Value  DisabledColumn��%H  &	       &	 p     �� 5L      "
  6   .�5M      ��  � ��
 �W�.�63   �� 5N       � ��
 �����63   5O      �� 5Q      .�5R      ��  �@ CanUserResize$ False��5S   %   �� 5T       �@ CanUserSort$ False��5U   %   �� 5V       �@ CanUserReorder$ False��5W   %   5X      5Y      5Z      �� 5[   
   -   5        $�� Todos ��5[      $
��Left=�6#   $��
20,-25,0,0q�6>   $	��Top=�6R     normalBtnStyle#��[ 6x   �� 5\   
   -   5        $�� A ver ��5\      $
��Left=�6#   $��
78,-25,0,0q�6>   $	��Top=�6R   #��[ 6x   �� 5]   
   -   5        $�� Vistos ��5]      $
��Left=�6$   $��133,-25,0,0q�6?   $	��Top=�6T   #��[ 6z   �� 5^   
   -   5        $�� Planeio ver ��5^      $
��Left=�6)   $��190,-25,0,0q�6D   $	��Top=�6Y   #��[ 6�   �� 5_   
   -   5        $��	 Largado ��5_      $
��Left=�6%   $��275,-25,0,0q�6@   $	��Top=�6U   #��[ 6}   �� 5`   
   -	   5        $��
 Em pausa ��5`      $
��Left=�6&   $��343,-25,0,0q�6A   $	��Top=�6V   #��[ 6   5a      5b      