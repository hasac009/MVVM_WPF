   M S B A M L   `   `   `  ����C  ?testMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:testMvvm.View.UserControllerstestMvvm.View.UserControllers  5      /    )testMvvm.View.UserControllers.SPControler   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:testMvvm.View.UserControllers     5      .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5           Name$
  MyDG��5         DataGridRowStyle1   RowStyle# �   5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5        DataGridCellStyle1   	CellStyle# �  5        DataGridStyle1#���  5      $��44,25,64,25q�69      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      
IsReadOnly$
 True��6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Name��6%   $
 True��6L    63   �� *name+6L     5      $ Count��6%   $
 True��6N    64   �� *count+6N   5      �� 5   
     MyButtonStyle#��[ 6   $��34��68   $��	462,3,0,0q�6D   $��94��6W   $
��Left=�6b   $	��add��6}   $��20(�6�   ��6�   �� *CreatAddWindowSPCommand+�� 5   
   -   5        #��[ 5      $��34��68   $��	561,3,0,0q�6D   $��93��6W   $
��Left=�6c   $	��Del��6~   $��20(�6�   6�   �� 5   
   -   5        #��[ 5      $��34��68   $��36,3,0,0q�6D   $��94��6V   $
��Left=�6a   $��Excel��6|   $��20(�6�   6�   5      5      