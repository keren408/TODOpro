   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	       PL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��800��6)   .��5	      �  � 	Resources 5
   
      AddButtonImageBrush �� ImageSource j� Stretch  DeleteButtonImageBrush  UpdateButtonImageBrush  dateSearchButtonImageBrush ! regularSearchButtonImageBrush��%�  &	        &	 P     &	 �     &	 �     &	 L    �� 5      $# /PL;component/images/addP.jpg��65   $ UniformToFill=�6a   �� 5      $&  /PL;component/images/deleteP.jpg��68   $ UniformToFill=�6g   �� 5      $&  /PL;component/images/updateP.jpg��68   $ UniformToFill=�6g   �� 5      $) #/PL;component/images/dateSearch.jpg��6<   $ UniformToFill=�6n   �� 5      $, &/PL;component/images/regularSearch.jpg��6?   $ UniformToFill=�6t   5      ��5   
   �� 5      $ UniformToFill=�6   $% /PL;component/images/backgr.jpg��61    � ColumnDefinitions 5   
   �� 5      $
��109* �6   �� 5      $
��410* �6   .+�5   
    � -   5          �Name$ 	mainFrame��5      $��1��6C   ��6#   �� *CurrentPage+6C   �� 5   
   
������ 
������ $
��Left=�5      $��	10,12,0,0q�6,   $	��Top=�6?   $��88��6W   $��96��6b   ��5   E   �� *UpdateTodoCommand+.��5      �� .��5      �� $&�� /PL;component/images/updateP.jpg��6   $��81��6B   $��75��6N   5      5      �� 5    
   
������ 
������ $
��Left=�5!      $��
10,118,0,0q�6,   $	��Top=�6@   $��88��6X   $��75��6c   ��5    D   �� *DeleteTodoCommand+.��5"      �� .��5#      �� $&�� /PL;component/images/deleteP.jpg��6   $��92��6B   $��91��6N   5$      5%      �� 5&   
   
������ 
������ $
��Left=�5'   1   $��
10,320,0,0q�6L   $	��Top=�6`   $��88��5(      $��77��6   ��5'      �� *DateCommand+.��5)      �� .��5*      �� $)��#/PL;component/images/dateSearch.jpg��6   5+      5,      �� 5-   
   
������ 
������ $
��Left=�6e   $��
10,416,0,0q�5.      $	��Top=�6%   $��88��6=   $��83��6H   ��5-   D   �� *TopicCommand+.��5/      �� .��50      �� $,��&/PL;component/images/regularSearch.jpg��6   51      52      �� 53   
   
������ 
������ $
��Left=�6D   $��
10,211,0,0q�6_   $	��Top=�54      $��88��6)   $��92��64   ��6@   �� *NewTodoCommand+.��55      �� .��56      �� $#��/PL;component/images/addP.jpg��6   $��93��6?   $��89��6K   57      58      �� 59   
   
������ 
������ $
��Left=�6E   $��74��6`   $��-10,536,-50,0q�5:      $	��Top=�6(   $	��123��6@   ��59   l   �� *ViewAllTodoCommand+.��5;      �� .��5<      �� $$��/PL;component/images/house.jpg��6   $��59��6@   $��42��6L    J� RenderTransformOrigin$ -0.405,0.829&�6W   5=      5>      5?      5A      