   M S B A M L   `   `   `  ����E  AProjektyMG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjektyMG
ProjektyMG  5   	       ProjektyMG.AdminPanel   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjektyMG     5   	     � Title$  
AdminPanel��5   	   $	��566��6   $	��800��6)   .��5	      � .+�5
   
   �� ���#2e3137 �� CornerRadius$ 100 100 0 0��6&   $��
20,20,20,0q�6A   ._�5      �� .+�5      �� $��Specification Bike��6   $��Center=�65   
�������$��20(�6e   6u   �� 5      -   5        $��	ModelList��5      $��50 30 q�6,   $	��211��6<   
����������	#FFBDBDBD � ContextMenu 5      �� 5      .@�5      m� -   5        $��Clear��5   (   67   5       �� View 5      �� 5      .P�5      �� $��Id��6-    �� Width$ 30��69    �� DisplayMemberBinding 6E   �� *ID+�� 5      $
��Mark��6-   $	 150��6;    6G   �� *Mark+�� 5      $��
WheeleSize��6-   $	 150��6A    6M   �� *	WheelSize+�� 5      $��
NumberGear��6-   $	 150��6A    6M   �� *NumberGears+5      5      � 5      -   5         �Name$ EditGrid��5      .+�5       �� $
��Mark��6   $
��Left=�6,   
�������$	��Top=�6[   �� 5!      $��	WheleSize��6   $
��Left=�60   
�������$	��Top=�6_   $��0,31,0,0q�6w   �� 5"      $��
NumberGear��6   $
��Left=�61   
�������$	��Top=�6`   $��0,62,0,0q�6x   �� 5#      -   5         ��Name$ MarkTextBox��5#      $
��Left=�6~   $	��150��6�   $��26��6�   $	��Top=�6�   $��	100,0,0,0q�6�   
����������	#FFBDBDBD��65   �� *SelectedItem.Mark+ �� ElementName$ 	ModelList��	 �� Mode$	 OneWay=�6�   �� 5$      -   5        $ WheleSizeTextBox��5$      $
��Left=�6�   $	��150��6�   $��26��6�   $	��Top=�6�   $��
100,31,0,0q�6  
����������	#FFBDBDBD��6j   �� *SelectedItem.WheelSize+$ 	ModelList��$	 OneWay=�6*  �� 5%      -   5        $ NumberGearTextBox��5%      $
��Left=�6�   $	��150��6�   $��26��6�   $	��Top=�6�   $��
100,62,0,0q�6  
����������	#FFBDBDBD��6j   �� *SelectedItem.NumberGears+$ 	ModelList��$	 OneWay=�6,  5&      � 5(      $��20q�6   .+�5)      �� -   5        
 ��Name$
 CreateButton��5)      $
��Left=�63   $	��100��6i   $��	230,0,0,0q�6u   .��5*      ��  �� Orientation$ 
Horizontal=�6%   .+�5+      �� $��Create��6$   5,      5-      �� 5/      -   5        $
 UpdateButton��5/      $
��Left=�63   $	��100��6i   $��	116,0,0,0q�6u   .��50      �� $ 
Horizontal=�6%   .+�51      �� $��Update��6$   52      53      �� 55      -	   5        $
 DeleteButton��55      $
��Left=�63   $	��100��6O   .��56      �� $ 
Horizontal=�6%   .+�57      �� $��Delete��6$   58      59      �� 5;      -
   5        $
 LogOut��5;      $
��Left=�6-   ���#adafff$	��228��6]   $��482,10,0,-52q�6~   .��5<      �� $ 
Horizontal=�6%   .+�5=      �� $��LogOut��6$   5>      5?      5A      5C      5D      5E      5F      