   M S B A M L   `   `   `  ����P  LWPF_LibraryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPF_LibraryManagementWPF_LibraryManagement  5   	   &     WPF_LibraryManagement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WPF_LibraryManagement     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $��473.92��6   $��795.515��6,   .��5
      � ��5   
   �� 5       �� 
StartPoint$ 0.3,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ #8ec6d6��6    � Offset$ 1Q�6/   6<   � 5      $ #331155��6   $ 0Q�6/   6=   5      .+�5   
   �� $	��385��6   $	��Top=�6    �� CornerRadius$ 
0 0 180 0 ��66   ���#100E17$��	0,0,-18,0q�6e   5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��Images/illus.png��6   $	��617��62   $
��10,0q�6@   5      �� 5      $	��350��6   .+�5      �� $��20 40q�6   .+�5      �� $��
User Login��6    $��20q�62   
������� �� TextAlignment$ Center=�6Q   $��38(�6h   $��Arial)�6v   6�   �� 5      $ 
Horizontal=�6!   $��10q�6:   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   
�������6U   �� 5      -   5        	 ��Name$	 	user_name��5   "   $
��10 0q�66   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Enter Username / Email��6E   
�������$	��250��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush 6�   Z� ��6�   Z� 5      �� 5       $ 
Horizontal=�6!   $��10q�6:   .+�5!        $
 Lock=�62   $��25��6>   $��25��6I   
�������6U   G� 5"      -   5         G�Name$ txtPassword��5"   &   $
��10 0q�6;   $
 ********��6I   
�������$	��250��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD94448��6�   Z� 5#      �� 5$      $��10q�6!   $��Center=�6-   .+�5%      �� -   5         ��Name$ btnLogin��5'   R   $	��100��5%   !   $��40��6-   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5&      $��2q�6H   ���#D94448���#D94448
������� � ToolTip$ Login��5'   B   $��Login��6x   5(      5)      5*      5+      5-      5/      52      