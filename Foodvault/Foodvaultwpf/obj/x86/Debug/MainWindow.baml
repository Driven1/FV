   M S B A M L   `   `   `  ����G  CFoodvaultwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?)clr-namespace:TemplateSelectors;assembly=TemplateSelectors  5   	       Foodvaultwpf.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =TempSel)clr-namespace:TemplateSelectors;assembly=     5   	     � Title$  	Foodvault��5   	   $��Normal&�6   $
��1024��60   $	��800��6=    � Icon$ Media/FV_icon.jpg��6J    � 	Resources 5         	FalseTemp  TrueTemp7  1TemplateSelectors.CustomRowDetailTemplateSelector  RowDetTempSel��%&  &	        &	 k    &	 �    �� 5   
   .R�5      �� .+�5	      �� 
���� ��$-��'Für diese Zutat liegen keine Werte vor��64   $��Center=�6b   $��Segoe UI)�6}   $��10.667(�6�   �� 5
      $��ingSearchBtn��6U   -   5        $��Suche��5
      $
��Left=�6)   $��2,0,0,0q�6D   $��0q�6i   $��Segoe UI Light)�6u   $��10.667(�6�   6�   5      5      5      �� 5   
   .R�5      �� ���	#FFA4F3DA$��Stretch=�5   (   $��Stretch=�6F   ��5   /   �� *	Tooltip+5   F   5        5   
   62   5      .��5      � -   5        $��grid1��5      .+�5   
   �� -   5        $��tabControl1��5   B   $
��Left=�6   $��10,8,0,0q�60   $	��Top=�6U   $	��727��6m   $	��980��6z    �� TabStripPlacement$
 Left=�6�   $��Segoe UI)�6�   $
��Bold"�6�   $��Normal$�6�   $��0q�6�    5       �� 
TargetType �� Property �� Value � LayoutTransform �� Angle��%�   '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      .R�5   "   �� #��z��63    5   &   �� 5   *   $	 270Q�6:   5!   #   5"      5$      5%      5&      .@�5'      �� -   5        $��tabItem1��5'   '   $��Rezepte��6   $��1q�67   $��Normal&�6B   $��8q�6W   ���	#FFB4B4FF.��5(      � -   5        $��grid2��5(      ��5)      �� 5*      	 �� 
StartPoint$	 0,0.5&�6.   
 �� EndPoint$
 1,0.5&�6A   .��5+      �  � Color$ 	#FFB4B4FF��6+    � Offset$ 0Q�6=   � 5,      $ White��6+   $ 1Q�69   5-      .+�5/      �� -   5        $��
recSortBox��5/   Z   $��21��6   $
��Left=�6+   $��
29,131,0,0q�6F   $	��Top=�6l   $	��239��6�    �� 
IsEditable .  �� Text$ sortieren nach...��6�   $��Normal"�6�    �� 
IsReadOnly . .@�50      �� $��Kalorien (aufsteigend)��6'   �� 51      $��Kalorien(absteigend)��6'   �� 52      $��Zeit (aufsteigend)��6'   �� 53      $��Zeit (absteigend)��6'   �� 54      $ ��[NIY] Kosten (aufsteigend)��6'   �� 55      $��[NIY] Kosten (absteigend)��6'   56      �� 57      -   5        $��
recListBox��57   Z   $	��538��6   $
��Left=�6+   $��
29,158,0,0q�6F   $	��Top=�6l   $	��239��6�   6�   �� 58      -   5        $��
recCalText��58   Z   $��29��6   $
��Left=�6*   $��755,215,0,0q�6E   $	��Top=�6l   $	��149��6�    �� 
IsReadOnly . 6�   �� 59      -	   5        $��recTimeText��59   @   $��29��6   $��755,250,30,0q�6*   $	��Top=�6S    . 6k   �� 5:      $
��Auto=�6#   $	��414��6F   $	��545��6S   $��359,285,0,0q�6_   $
��Left=�6t   $	��Top=�6�   .��5;      �� -
   5        $��recPrepTBlock��5;   $   $�� ��69   
�������$
��Wrap=�6V   $��CharacterEllipsis=�6j   5<      �� 5=      $
��Auto=�6#   $	��273��6F   $	��390��6S   $��	359,6,0,0q�6_   $
��Left=�6r   $	��Top=�6�   .��5>      &   System.Windows.Controls.DataGrid  -   5          Name$ recIngDGrid��5>   #   $	��377��6h      AutoGenerateColumns .  !   RowDetailsTemplateSelector# [ 6�      RowStyle 5?      �� 5@   "   )  #System.Windows.Controls.DataGridRow"  6(   .�5A   &   ��  � ��
 �����6C    �� Triggers 5B   &   �� 5C   *    �� Binding 66   �� *	NutActive+ �� Value True6T   .a�5D   .   ��  � ��
 � � �6K   5E   +   5G   #      Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Menge��6P      CanUserReorder .     
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Amount+6v     5K   "   $ Zutat��6N      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]    .   .  65   �� *Name+6~   5M      5N      �� 5O      -   5        $��recSearchBox��5O   Y   $��23��6   $
��Left=�6*   $��
29,102,0,0q�6E   $	��Top=�6m   $	��158��6�   �� 5P      -   5        $��recSearchBtn��5P   i   $��Suche��6   $��23��6-   $
��Left=�69   $��193,101,0,0q�6T   $	��Top=�6}   $��75��6�   6�   �� 5Q      -   5        $��recOpenImportBtn��5Q   w   $��neues Rezept eintragen��6   $��25��6>   $
��Left=�6J   $��29,6,0,0q�6e   $	��Top=�6�   $	��236��6�   6�   5R      5S      �� 5T      $
��Obst��6   $��1q�6$   $��Normal&�6/   $��8q�6D   ���	#FFFF9D00.��5U      �� $
��auto=�6   $
��auto��6B   $
��auto��6O   .��5V      �� -   5        $��image2��5V      $
��Fill=�6*   $+��%/Foodvaultwpf;component/saisonFru.png��69   5W      5X      �� 5Y      $��Gemüse��6   $��1q�6&   $��8q�61   ���	#FF56A10E.��5Z      �� $
��auto=�6   $
��auto��6B   $
��auto��6O   .��5[      �� -   5        $��image1��5[   7   $
��Left=�6   $
��Fill=�6E   $	��Top=�6T   $+��%/Foodvaultwpf;component/saisonVeg.png��6l   5\      5]      5^      5_      5`      