   M S B A M L   `   `   `  ���� C  ?testMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:testMvvmtestMvvm      testMvvm.App   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     (localclr-namespace:testMvvm       �� 	Resources     MyButtonStyle4 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName �� Triggers  MyButtonStyle �� EndPoint �� 
StartPoint �� RelativeTransform �� CenterY �� CenterX �� CenterX �� CenterY �� Angle �� CenterX �� CenterY � Color � Offset  img  SlideBtnStyle �Name �� Orientation �� Binding �� Path �� ElementName �� Value �� RelativeSource �� Mode  �� AncestorType  carIcon! �� ImageSource  
numberIcon  tbox_nameCar" J� SnapsToDevicePixels# � ColumnDefinitions$ ��Name% � ToolTip& � Cursor' ��Name
( � Tag) ]� 
Conditions* �� Property+ �� Value  tbox_numberCar  tbox_Calendar 	 imgCalendar 
 	ImgButton  DataPickerCalendarStyle&   System.Windows.Controls.Calendar, ��Name5  /System.Windows.Controls.Primitives.CalendarItem-  Name.   CalendarItemStyle  DataPickerStyle(  "System.Windows.Controls.DatePicker:  4System.Windows.Controls.Primitives.DatePickerTextBox/  Name0 ��Name1 �Name2 � AllowsTransparency3 � 	StaysOpen4 � HorizontalOffset5 � PlacementTarget��%�  &	        &	 �    &	 T    &	 v    &	 �    &	 �    &	 �    7  &	 �    7  &	     &		 �    &	
 �    7 	 &	 �    &	 �    7  7 
 �� " ��.���  � ��
 ���� ��  � �� �#FF0A5D��  � ��$ Bottom=���  � �� �� " ��.R��� #��z��#��z��$ 5��._�� .+��� $ Border�����#F4E8DE$��25��$��Bottom=�$ 3���� $��Bottom=�$��Center=� P�  �@J�IsMouseOver$
	 True��. ��� $
 Border�� � �� �#FF0A5D P�  �@J�IsMouseOver$
	 True��. ���  �@J�Opacity$	 0.8Q���  � �� �#F4E8DE�� " ��.���  � �� �#FB2576��  � �� �#E7F6F2��  � ��$ Arial Black)���  � ��$ 45(���  � ��$ 64����  � ��$	 307����  � ��$
 0,10q���  � ��$ Center=���  � ��$	 Top=���  � �� �� " ��.R��� #��z��$ 10������ $	 1,1&�$	 0,2&� V� .~��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q��� $ -30.964Q�$	 0.5Q�$	 0.5Q�T� .��� $ #FFF092��� $ #FF005B��$ 1Q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
	 True��. ���  � �� �	#FFC7C2C2P�  � ��$
	 True��. ���  � �� �	#FFC7C2C2��  � �� �	#FFF6F1F1��/View/Windows/bigcar.png���� " ��.R�� $	 btn��$��39��.+��� ._��� $ 
Horizontal=�.+��� #���  $
��Left=�$��Center=�$
��Fill=�$��11,0,0,0q��� #��z��$��19(�$��Century Gothic)�$��Center=�$��20,2,0,0q����� " ��.���  � ��
 ���� ��  � �� �#FF0A5d ��  �� $ IsMouseOver�$	 btn�� True.a���  � ��
 � ����� $ IsSelectBtn������ " ��.���  � y�$ Hidden=���  � ��$ 3,0,0,0q���  � �� �#FF0A5d ��  ��  �� $ FindAncestor=�"  ��$ 	IsFocused� True.a���  � y�$ Visible=��� $ 
IsSwipeBtn������ " ��.���  � y�$ Hidden=���  � ��$ 3,0,0,0q���  � �� �#FF0A5d ��  �� $ IsMouseOver�$	 btn�� True.a���  � y�$ Visible=��� $! /View/Windows/bigcar.png���� $!! /View/Windows/bignumber.png���� " ��.���  � ��$ 16(���  � ��$ Roboto)���  � ��$ 35����  � ��$	 250����  � ��
 � �����  � �� �#FF0A5d��  � ��$ 0 5 5 4q���  � ��$ 0 10 0 0q���  �@�Cursor$ IBeam����  � ��$ 1����  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��� $ 	TxtBorder��
��� ���$��2q�$ 5��$
" True��._�� #��z��# �� $��20 ��� $��* �.+��� $$ PART_ContentHost��$|�False��$��5 0 0 0q�$��Hidden=�$��Hidden=�$��1���� 8��  $��0q�$��15��$��15��$��5 0 0 3q�$��Center=�$��Center=�$
% Name��$& Arrow��$��0���� $' 	Watermark��$��Center=�$
��Left=�
��� ���$y�	Collapsed=�$��5 0 20 0q�#��z( $��1�� P�  �@J�IsMouseOver$
	 True��. ��� $
 	TxtBorder�� � �� �#FF0A5dP�  �@J�IsKeyboardFocused$
	 True��. ��� $
 	TxtBorder�� � �� �#FF0A5d�� $
 	TxtBorder�� � ��$ 0.9 0.9 0.9 3q�]� ) �� * � ��$+  ��./��� $
 	Watermark�� � y�$ Visible=��� " ��.���  � ��$ 16(���  � ��$ Roboto)���  � ��$ 35����  � ��$	 250����  � ��
 � �����  � �� �#FF0A5d��  � ��$ 0 5 5 4q���  � ��$ 0 10 0 0q���  �@�Cursor$ IBeam����  � ��$ 1����  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��� $ 	TxtBorder��
��� ���$��2q�$ 5��$
" True��._�� #��z��# �� $��20 ��� $��* �.+��� $$ PART_ContentHost��$|�False��$��5 0 0 0q�$��Hidden=�$��Hidden=�$��1���� 8��  $��0q�$��15��$��18��$��2 0 0 3q�$��Center=�$��Center=�$
% Name��$& Arrow��$��0���� $' 	Watermark��$��Center=�$
��Left=�
��� ���$y�	Collapsed=�$��5 0 20 0q�#��z( $��1�� P�  �@J�IsMouseOver$
	 True��. ��� $
 	TxtBorder�� � �� �#FF0A5dP�  �@J�IsKeyboardFocused$
	 True��. ��� $
 	TxtBorder�� � �� �#FF0A5d�� $
 	TxtBorder�� � ��$ 0.9 0.9 0.9 3q�]� ) �� * � ��$+  ��./��� $
 	Watermark�� � y�$ Visible=��� " ��.���  � ��$ 11(���  � ��$ Roboto)���  � ��$ 35����  � ��$	 250����  � ��
 � �����  � �� �#FF0A5d��  � ��$ 0 5 5 4q���  � ��$ 0 10 0 0q���  �@�Cursor$ IBeam����  � ��$ 1����  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��� $ 	TxtBorder��
��� ���$��2q�$ 5��$
" True��._�� #��z��# �� $��20 ��� $��* �.+��� $$ PART_ContentHost��$|�False��$��5 0 0 0q�$��Hidden=�$��Hidden=�$��1���� $' 	Watermark��$��Center=�$
��Left=�
��� ���$y�	Collapsed=�$��5 0 20 0q�#��z( $��1�� P�  �@J�IsMouseOver$
	 True��. ��� $
 	TxtBorder�� � �� �#FF0A5dP�  �@J�IsKeyboardFocused$
	 True��. ��� $
 	TxtBorder�� � �� �#FF0A5d�� $
 	TxtBorder�� � ��$ 0.9 0.9 0.9 3q�]� ) �� * � ��$+  ��./��� $
 	Watermark�� � y�$ Visible=��� $! /View/Windows/Vector.png���� " ��.���  � ��$ 25����  � ��$ 25����  � ��$ Right=���  � ��$ center=���  �@J�SnapsToDevicePixels$
 True����  � �� �� " ��.R��� $ 	BorderImg��$��0q�8��  �� "  .���  � ��
 �   ���  � �� �	#FFDAD1BD��  � ��
 ���� ��  � ��$ 2q���  � �� �� "  .R��� $, 	PART_Root��$��Center=�.+�  $- PART_CalendarItem��#��z��#��z��#��z��#��z. $��0 5 0 0q��� "  .���  � ��$ 0 10 0 0q���  � ��$ Center=���  � �� �� "  .R�� .+��� $ Border��$��2��$��35��$	��250��$��2q�
��� ���$ 5��
������ ._�� # �� $��* ��� $��35 �.+�  $/ PART_TextBox��8��  $��0q�$��0��$��Roboto)�$��11(����#FF0A5d$��Center=�$��13 4 0 0q��� $0 PART_Button��$��1��8�� $��5 0 5 0q�� $1 
PART_Popup��$
2 True��$��Bottom=�$3 False��$4 17��5 �� $ PART_TextBox���� $' 	Watermark��$��Center=�$
��Left=�
��� ���$y�	Collapsed=�$��7 7 0 0q�#��z( $��Roboto)�$��11(�$��0�� P�  �@J�IsMouseOver$
	 True��. ��� $
 Border�� � �� �#FF0A5dP�  �@J�IsKeyboardFocused$
	 True��. ��� $
 Border�� � �� �#FF0A5d�� $
 Border�� � ��$ 0.9 0.9 0.9 3q�]� ) �� * �@ Text$+  ��./��� $
 	Watermark�� � y�$ Visible=�