   M S B A M L   `   `   `  ����E  AWPF_Lab_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_Lab_11
WPF_Lab_11  5   	   ;"clr-namespace:WPF_Lab_11.viewmodelWPF_Lab_11.viewmodel  5   	       WPF_Lab_11.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_Lab_11     5   	   1vm"clr-namespace:WPF_Lab_11.viewmodel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      (   "WPF_Lab_11.viewmodel.MainViewModel  5   
   .��5      �  � UseLayoutRounding .  ���	#FF92DFC0.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ record��5      $
��Left=�6#   $	��374��5      ���	#FFBECFA5
�������   
IsReadOnly .    AutoGenerateColumns .  $��14(�5   /      CanUserAddRows .  ��5   >   �� *	Records+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 62   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *FIO+  5      $ ПРЕДМЕТ��6%   $	 * 66   
 6@   �� *	SUBJECT+  5      $ ДАТА��6%   $	 * 63   
 6=   �� *DATE+  5      $ 
ВРЕМЯ��6%   $	 * 64   
 6>   �� *TIME+  5      $ 
МЕСТО��6%   $	 * 64   
 6>   �� *FREE+5      �� 5   
   -   5         ��Name$ 	addButton��5      $	��ADD��6$   $
��Left=�62   $��65��6M   $��
501,10,0,0q�5      $	��Top=�6%   $	��172��6=   
���   ����	#FFC8E3B2$��18(�5   (   $
��Bold"�66   ���	#FF505050��5      �� *AddToScheduleCommand+��6:   �� *SelectedItem+ �� ElementName$ record��  5   
   -   5        $ schedule��5      $
��Left=�6%   $	��426��5      ���	#FFBECFA5
������� .  .  $��14(�5   )    .  $��374,217,0,-1q�6N   ��5   @   �� *
Schedule+ 5         5!      $ ФИО��6%   $	 * 62   
 6<   �� *FIO+  5"      $ ПРЕДМЕТ��6%   $	 * 66   
 6@   �� *	SUBJECT+  5#      $ ДАТА��6%   $	 * 63   
 6=   �� *DATE+  5$      $ 
ВРЕМЯ��6%   $	 * 64   
 6>   �� *TIME+  5%      $ 
МЕСТО��6%   $	 * 64   
 6>   �� *FREE+5'      �� 5(   
   -   5        $ removeButton��5(      $��REMOVE��6'   $
��Left=�68   $��65��6S   $��
501,98,0,0q�5)      $	��Top=�6!   $	��172��69   
���   ����	#FFC8E3B2$��18(�5*   $   $
��Bold"�62   ���	#FF505050��5+      �� *RemoveFromScheduleCommand+��6;   �� *SelectedItem+$ schedule��5-      5.      