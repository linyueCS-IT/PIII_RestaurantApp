   M S B A M L   `   `   `  ����M  IPIII_RestaurantApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PIII_RestaurantAppPIII_RestaurantApp  5   	   #    PIII_RestaurantApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:PIII_RestaurantApp     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��450��6)   .��5	      � $��20q�6   ��5   
   �� 5       �� ImageSource$" /Images/Dessert/Tiramisu.jpg��6    j� Stretch$ UniformToFill=�6D    �� Opacity$	 0.5Q�6\   .+�5   
   ]� ��.  $��50��6*   $	��Top=�66   
�������.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��Center=�6I   $��10q�6d   .+�5      �� -   5        $��Log in��5      $��5q�6*   65   �� 5      $��Sign up��6   $��5q�6+   �� 5      $��🛒 0��6   $��12(�6/   $��5q�6>   5      5      � 5   
   $��Center=�6    � RowDefinitions 5      �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    .+�5%      �� $��Delivered to your door��6   $��28(�66   $
��Bold"�6D   $��Center=�5&      $
��0,10q�65    �� Padding$ 20q�5'      $��1��5(      
���   �6%   � 5+      $��2��6    � ColumnDefinitions 5,      �� 5-      $
��Auto �6'   �� 5.      $��10 �6'   �� 5/      $
��Auto �6'   .+�51      �� $��0��6   
�������$	��250��53      $��20,0,0,0q�54      ._�55      � .+�56      �� -   5         ��Name$ 
txtAddress��56   "   $��10q�57      $��18(�58      $��0q�59      
������ 5:      �� 5;      	 J� IsHitTestVisible	 .  $��Enter your Address��5<      $��Center=�5=      $��20,0,0,0q�5>      
���������5@      �� 5A   "   
 �� 
TargetType"
 ��6(   .�5B   &   ��  �� Property � y� �� Value$ 	Collapsed=�6C    �� Triggers 5C   &   �� 5D   *    �� Binding 66   �� *Text+ �� ElementName$ 
txtAddress�� �� Value  6g   .a�5E   .   ��  � y�$ Visible=�6K   5F   +   5H   #   5J      5K      5L      �� 5M      $��2��6   ._�5N      �� -   5        $��	Order Now��5N      $	��120��61   $��40��6=   
��� � �
�������6o   5O      5P      5Q      5R      5S      