   M S B A M L   `   `   `  ����P  LWPF_LibraryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPF_LibraryManagementWPF_LibraryManagement  5   	   3    -WPF_LibraryManagement.InsertDeleteUpdateBooks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WPF_LibraryManagement     5   	     � Title$  InsertDeleteUpdateBooks��5   	   $	��450��6)   $	��800��66   .��5	      � .+�5
   
   �� -   5         ��Name$ UserAuthorisation��5
      $y�Hidden=�6+   �� 5   
   -   5        $ UserID��5      $y�Hidden=�6    &   System.Windows.Controls.DataGrid  5   
   -   5        $��DGrid��5         AutoGenerateColumns .  $��10,28,18,146q�6T   ��6    ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        BookName��,  &System.Windows.Controls.DataGridColumn   Header$ 	Book Name��5   U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	book_name+6U     5      $ Author��6@    6%   �� *author+6@     5      $ 	Book Page��6C    6%   �� *	book_page+6C     5      $ Book Details��6E    6%   �� *book_detail+6E   5      �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $��146,292,0,0q�6=   $	��Top=�6R   $��75��6j    J� RenderTransformOrigin$ 0.599,-0.483&�6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $��286,292,0,0q�6=   $	��Top=�6R   $��75��6j   $ 1.185,0.618&�6u   6�   �� 5   
   -   5        $��Insert��5      $
��Left=�6"   $��
10,292,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   5      5      