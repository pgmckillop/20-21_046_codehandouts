   M S B A M L   `   `   `  ����M  IFlooringCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FlooringCalculatorFlooringCalculator  5          FlooringCalculator.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2local clr-namespace:FlooringCalculator     5        �� 	Resources  5         ControlLabelStyle �� 
TargetType �� Property �� Value  PageHeaderStyle  SingleColumnLabelStyle  ValueTextBox  
FormButton  NumbersTextBox  ComboBox  SummaryDataTextBlock  RoundButtonStyle �� 
TargetType �� CornerRadius��%�
  &	        &	     &	     &	     &	     &	 �    &	     &	 �    &	     �� 5	   
   " ��6*   .�5
      ��  � ��
 ��  �6+   �� 5       � ��$ 	TW Cen MT)�6+   �� 5       � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�62   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��6(   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 48(�6)   �� 5       � ��$ 	TW Cen MT)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ��  �6+   �� 5       � ��$ 10,20,10,10q�6'   5      �� 5   
   " ��6/   .�5      ��  � ��
 ��  �6+   �� 5       � ��$ 	TW Cen MT)�6+   �� 5       � ��$ Italic$�6*   �� 5       � ��$ 24(�6)   �� 5        � ��$
 Bold"�6+   �� 5!       � ��$ Center=�62   �� 5"       �@��Padding$	 0,5q�6(   �� 5#       � ��$ 10q�6'   5$      �� 5&   
   " ��6%   .�5'      ��  � ��$ 14(�6)   �� 5(       � ��$ 12q�6'   �� 5)       � ��$
 5,10q�6(   5*      �� 5,   
   " ��6#   .�5-      ��  � ��$ Center=�62   �� 5.       � ��$ 10q�6'   �� 5/       � ��$ 24(�6)   �� 50       � ��$ 5q�6(   �� 51       � ��$	 150��6&   52      �� 54   
   " ��6'   .�55      ��  � ��$ 10q�6'   �� 56       � ��$
 5,10q�6(   �� 57       �@�
InputScope$ Number��6+   �� 58       � ��$ 24(�6)   �� 59       � ��$ 	TW Cen MT)�6+   �� 5:       �@��TextAlignment$ Right=�6.   5;      �� 5>   
   " ��6!   .�5?      ��  � ��$ 10q�6'   �� 5@       � ��$ 5q�6(   �� 5A       � ��$ 	TW Cen MT)�6+   �� 5B       � ��$ 24(�6)   �� 5C       � ��$ Center=�62   5D      �� 5F   
   " ��6-   .�5G      ��  � ��$
 10,5q�6'   �� 5H       � ��
 ��  �6+   �� 5I       � ��$ Center=�64   �� 5J       �@��Padding$ 2q�6(   �� 5K       � ��$ 	TW Cen MT)�6+   �� 5L       � ��$ 24(�6)   5M      �� 5O   
   " ��6)   .�5P      ��  � ��
 ��� �6+   �� 5Q       � ��
 �����6+   �� 5R       � ��$
 Bold"�6+   �� 5S       � ��$ 24(�6)   �� 5T       � ��$ 	TW Cen MT)�6+   �� 5U       � ��$ 75��6&   �� 5V       � ��$ 35��6'   �� 5W       � ��$ 	0,10,10,0q�6'   �� 5X       � �� 5Y      �� 5Z      " ��6&   .R�5[      �� #��z��5\      $��0q�5]      $ 6��5^      ._�5_      �� $��Center=�6/   $��Center=�6L   5`      5a      5c      5d      5g      5h      