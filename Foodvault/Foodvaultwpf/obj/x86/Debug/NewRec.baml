   M S B A M L   `   `   `  ����  Foodvaultwpf    Foodvaultwpf.NewRec   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Neues Rezept anlegen��5   	   $��663.627��6&   $��939.127��67   .��5      � ���	#FFE8D9D9.+�5   
   �� -   5        $��recImpUriBox��5   L   $��23��6   $
��Left=�6   $��	42,12,0,0q�69   $	��Top=�6`   $	��375��6x   �� 5   
   -   5        $��recImpUriBtn��5   ]   $��Import��6   $��23��6"   $
��Left=�6.   $��
423,12,0,0q�6I   $	��Top=�6q   $��75��6�   6�   �� 5   
   -   5        $��recImpWriteBtn��5   a   $��	Speichern��6   $��24��6%   $
��Left=�61   $��834,594,0,0q�6L   $	��Top=�6w   $��74��6�   6�   �� 5	   
   -   5        $��recImpPrepTB��5	   O   $	��460��6   $
��Left=�6   $��448,119,0,0q�6:   $	��Top=�6c   $	��382��6{    �� AcceptsReturn .  �� 
AcceptsTab .  �� TextWrapping$
 Wrap=�6�   �� 5
   
   -   5        $��label1��5
   \   $��Zutaten��6   $��28��6"   $
��Left=�6.   $��	42,94,0,0q�6I   $	��Top=�6j   $	��170��6�   �� 5   
   -   5        $��label2��5   `   $��	Anleitung��6   $��28��6$   $
��Left=�60   $��448,0,0,511q�6K   $��Bottom=�6n   $	��107��6�   �� 5   
   -   5        $��recImpNameTB��5   N   $��26��6   $��Right=�6   $��
0,57,517,0q�6:   $	��Top=�6b   $	��169��6z   $�� ��6�    .   . 6�   �� 5   
   -   5        $��label3��5   Z   $
��Name��6   $��26��6   $
��Left=�6+   $��
200,57,0,0q�6F   $	��Top=�6h   {�.  6�   �� 5   
   -	   5        $��richTextBox1��5   T   $	��100��6   $
��Left=�6#   $��1154,163,0,0q�6>   $	��Top=�6h   $	��200��6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ recImpIngsDG��5      $
��Left=�6)   $��
42,119,0,0q�6D   $	��Top=�6X   $	��460��6p   $	��293��6}      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Menge��6@      CanUserReorder .  	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Amount+6f     5      $ Zutat��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M    .  	 . 
 6%   �� *Name+6n   5      5      5      