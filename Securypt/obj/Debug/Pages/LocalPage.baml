   M S B A M L   `   `   `  ����C  ?Securypt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SecuryptSecurypt  5          Securypt.LocalPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Securypt     5        N� Title$  	LocalPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         J� 	AllowDrop . .+�5      �� -   5         ��Name$ MyBorderedButton��5      $��2q�6/   $��0��6C   $��0��6P   $��2��6`   $��6��6t   ��5      !� 5       !� Visual 5       �� 5!       �� StrokeDashArray$	 4 2R�6(   
���   �$��2��5#       �� RadiusX 5$      ��  �� RelativeSource �� 	 �� AncestorType"	 ��
 �� Path$
 CornerRadius.TopRight� �� RadiusY 5%      ��  �� "	 ��$
 CornerRadius.BottomLeft���5&      ��  �� "	 ��$
 ActualWidth���5'      ��  �� "	 ��$
 ActualHeight�5)      ._�5-      �� $��Center=�5.      $��Center=�5/      Drag Files Here51      52      53      �� 56   
    �� 
IsEditable .  �� 
IsReadOnly .  $��2��68   $��0��6H   $��Center=�6U   $	��Top=�6r    �� Text$ File Destination��57      �� 58   
    .  .  $��2��68   $��1��6H   $��Center=�6U   $	��Top=�6r   $ Encrypt or Decrypt��59      �� 5:   
    .  .  $��2��68   $��2��6H   $��Center=�6U   $	��Top=�6r   $ Local or Server��5;      �� 5>   
   $��5��6   $��2��6"   $
��10,0q�62   .+�5?      �� $��Ok��6   $	��8,3q�6"   �� 5@      $��Clear��6   $	��8,3q�6%   5A      �� 5C   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��3��6K   $��2��6X   $��2��6h   .+�5D      �� -   5        $��EncryptTest��5D      $	��4,3q�6+   $��4q�68   $��Center=�6D   6_   �� 5E      -   5        $��DecryptTest��5E      $	��4,3q�6+   $��4q�68   $��Center=�6D   6_   �� 5F      -   5        $��Server��5F      $	��4,3q�6&   $��4q�63   $��Center=�6?   6Z   5G      5I      5J      