   M S B A M L   `   `   `  ����J  FvrClusterConfig, Version=1.0.3.1, Culture=neutral, PublicKeyToken=null1clr-namespace:vrClusterConfigvrClusterConfig  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   %    vrClusterConfig.InputTypeDialog   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:vrClusterConfig     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   $	��200��5	   	   $	��300��6     � 
ResizeMode$  NoResize=�5
   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  CommonStyle �� 
TargetType  ControlsStyle �� BasedOn	 �� Property
 �� Value��%b  &	        &	 o     &	 �     7  '�� j    7  '�� �    7  S� 5   
   $ GetNames��5      "  6/    5      M� 5      $ local:InputType��6   5      �� 5   
   " �6$   �� 5   
   " ��6&   8   .�5      �� 	 � ��
 �#3F3F466+   �� 5      	 � ��$
 2q�6'   �� 5      	 � ��

 �����6+   �� 5      	 � ��
 6,   Z� �� 5      	 � ��$
 1q�60   5      �� 5   
   " ��6   8   6-   �� 5   
   " ��6   8   .�5      �� 	 � ��$	
 150��6&   �� 5      	 � ��$

 Left=�64   �� 5       	 � ��
 6,   Z� 5!      5"      .��5#      � $	��290��6   ���#2D2D30 � RowDefinitions 5$   
   �� 5%      $	��100 �6   �� 5&      $
��Auto �6   .+�5(   
   �� -   5         ��Name$ inputTypeCb��5(      $��0��6(   $��Center=�65   $��0q�6P    � UseLayoutRounding . $��Center=�6t   $��Center=�6�   $	��150��6�     ComboBoxTemplate#���  6   �� SelectedIndex$ 0��6/  ��6�   ��  �� Source# [  6/  � 5)   
   $��1��6    � ColumnDefinitions 5*      �� 5+      $��* �6#   �� 5,      $��* �6#   .+�5.      �� -   5        $��Ok��5.      $��60��6"   $��0��6-   $
��0,10q�6=    �� 	IsDefault .   ButtonTemplate#���  6q   �� 5/      $��Cancel��6   $��60��6&   $��1��61    �� IsCancel . $
��0,10q�6Q   #���  6`   50      51      52      