   M S B A M L   `   `   `  ����C  ?testMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:testMvvm.View.WindowstestMvvm.View.Windows  5   	   9!clr-namespace:testMvvm.ViewModelstestMvvm.ViewModels  5   	   )    #testMvvm.View.Windows.InfoCarWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:testMvvm.View.Windows     5   	   0vm!clr-namespace:testMvvm.ViewModels     5   	     � Title$  InfoCarWindow��5	   	    � 
ResizeMode$ NoResize=�6    � AllowsTransparency$
 True��65   $	��450��6O   $	��800��6\    � WindowStyle$
 None=�6h   
������  � DataContext 5
      )  #testMvvm.ViewModels.MainWindowModel  5   
   .��5      � 
������ .+�5   
   �� -   5         �� CornerRadius$ 10��5      ���#DAD1BD._�5      � .+�5      �� -   5           MyButtonStyle#��[  5      $��	763,5,0,0q�6@   $��27��6S    J� RenderTransformOrigin$ 0.5,0.5&�6_   $��30��6   $��X��6�   $
��Left=�6�   $��14(�6�   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6-   �� 5      �� 5      T� 5      5      5      �� 5      -   5         ��Name$ ImageControl��5      $��11,44,498,203q�6.   � 5      ���#F4E8DE$��364,40,126,142q�6-   	 � RowDefinitions	 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      
 � ColumnDefinitions
 5$      �� 5%      $	��17* �6+   �� 5&      $	��15* �6+   .+�5(      �� $��	Driver : ��6   $
��Left=�60   $��10,0,0,0q�6K   $��Center=�6]   $��26��6x   $��70��6�   �� 5)      $��service date : ��6   $
��Left=�66   $��Center=�6Q   $��1��6l   $��10,0,0,0q�6y   $��26��6�   $��94��6�   �� 5*      $��next service date : ��6   $
��Left=�6;   $��Center=�6V   $��3��6q   $��10,0,0,0q�6~   $��26��6�   $	��118��6�   �� 5+      $��date of insurance : ��6   $
��Left=�6;   $��Center=�6V   $��2��6q   $��10,0,0,0q�6~   $��26��6�   $	��118��6�   �� 5,      $��next insurance date: ��6   $
��Left=�6<   $��Center=�6W   $��4��6r   $��10,0,0,0q�6   $��26��6�   $	��131��6�   �� 5-      -   5         ��Name$ LableDriverName��5-      $��1��65   $��Label��6E   $
��Left=�6U   $��10,0,0,0q�6p   $��Center=�6�   �� 5.      -   5        $ LableDateTO��5.      $��1��61   $��Label��6A   $
��Left=�6Q   $��10,0,0,0q�6l   $��Center=�6~   $��1��6�   �� 5/      -   5        $ LableDateCT��5/      $��1��61   $��Label��6A   $
��Left=�6Q   $��10,0,0,0q�6l   $��Center=�6~   $��2��6�   �� 50      -   5        $ LableDateNextTO��50      $��1��65   $��Label��6E   $
��Left=�6U   $��	10,14,0,0q�6p   $	��Top=�6�   $��3��6�   �� 51      -   5        $ LableDateNextCT��51      $��1��65   $��Label��6E   $
��Left=�6U   $��	10,14,0,0q�6p   $	��Top=�6�   $��4��6�   53      &   System.Windows.Controls.DataGrid  55      -	   5          Name$
 MyDG��55      $	��131��6+   "   VerticalScrollBarVisibility$ Hidden=�68   $   HorizontalScrollBarVisibility$ Hidden=�6]     DataGridRowStyle1   RowStyle# �  56        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  57        DataGridCellStyle1   	CellStyle# �  58        DataGridStyle1#���  59      $��11,315,130,0q�6>      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6-      
IsReadOnly$
 True��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *name+6T     5<      $ Count��6-   $
 True��6V    6<   �� *count+6V   5?      �� 5A      -
   5        #��[  5A      $��	add Spart��6A   $
��Left=�6U   $��685,316,0,0q�6p   $��30��6�   $��93��6�   $��15(�6�   5B      5C      5D      5G      