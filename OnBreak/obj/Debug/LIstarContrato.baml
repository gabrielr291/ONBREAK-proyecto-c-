   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak 5	   	      OnBreak.LIstarContrato   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      !localclr-namespace:OnBreak  5	   	     � Title$  Listar Contrato��5   	   $	��600��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   (   "MahApps.Metro.Controls.MetroWindow   UseNoneWindowStyle .  � WindowStyle$
 None=�6�   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0.241Q�6-   � 5      $ 	#FF0C0080��6   $ 0.646Q�61   5      	 � ColumnDefinitions	 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 dtgContratos��5      $
��Left=�6)   $��
35,191,0,0q�6D   $	��Top=�6X   $	��245��6p   $	��723��6}      
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ cboxRut��5      $
��Left=�6$   $��
324,46,0,0q�6?   $	��Top=�6S   $	��120��6k   6w   �� 5   
   -   5         ��Name$ btnBuscarRut��5      $��Buscar��6'   $
��Left=�68   $��
484,58,0,0q�6S   $	��Top=�6g   $��95��6   $��40��6�    J� RenderTransformOrigin$ 	0.558,0.5&�6�    � Cursor$
 Hand��6�   6�   �� 5   
   -   5        $ btnBaja��5      $��Dar de baja��6"   $
��Left=�68   $��
628,95,0,0q�6S   $	��Top=�6g   $	��130��6   $ 
2.16,4.448&�6�   $��49��6�   6�   �� 5   
   -   5        $ btnModificar��5      $��	Modificar��6'   $
��Left=�6;   $��484,103,0,0q�6V   $	��Top=�6k   $��95��6�   $��41��6�   6�   �� 5   
   -   5        $ btnBuscarModalidad��5      $��Buscar��6-   $
��Left=�6>   $��
484,58,0,0q�6Y   $	��Top=�6m   $��95��6�   $��40��6�   $ 	0.558,0.5&�6�   $
 Hand��6�   6�   �� 5   
   -   5        $ btnBuscarTipo��5      $��Buscar��6(   $
��Left=�69   $��
484,58,0,0q�6T   $	��Top=�6h   $��95��6�   $��40��6�   6�   �� 5   
   -   5        $ cboxModalidades��5      $
��Left=�6,   $��
324,83,0,0q�6G   $	��Top=�6[   $	��120��6s   6   �� 5   
   -	   5        $ cboxTipo��5      $
��Left=�6%   $��324,118,0,0q�6@   $	��Top=�6U   $	��120��6m   6y   �� 5   
   $4��.Imagenes/white_logo_transparent_background.png��6   $
��Left=�6I   $	��176��6d   $��	10,10,0,0q�6q   $	��Top=�6�   $	��173��6�   !   MahApps.Metro.Controls.Tile  5    
   -
   5        $��0,441,701,37q�5    '   $
��Auto��6=   $
��Auto��6K   ��6X   Z� .��5!      � .+�5"      �� $��imagenes/flechita.png��6   $��70��67   $��70��6B   6P   �� 5#      $��Center=�6   $��Volver��65   $��10,70,-10,-44q�6F   $��70��6]   $ 	0.5,1.411&�6h   ���	#FFD4C4C46�   5$      5%      5'      5(      