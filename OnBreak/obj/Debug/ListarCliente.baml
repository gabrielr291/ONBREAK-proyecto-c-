   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak 5	   	      OnBreak.ListarCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      !localclr-namespace:OnBreak  5	   	   (   "MahApps.Metro.Controls.MetroWindow    UseNoneWindowStyle  .  � WindowStyle$
 None=�5   r    � Title$ ListarCliente��5   	   $	��600��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF020115��6    � Offset$ 0.274Q�61   � 5      $ 	#FF0E06A8��6   $ 0.642Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dgrListarCli��5      $
��Left=�6)   $��
10,181,0,0q�6D   $	��Top=�6X   $	��255��6p   $	��763��6}   
   
IsReadOnly
 . 6�   �� 5   
   -   5         ��Name$ cmbActividad��5      $
��Left=�6)   $��
476,60,0,0q�6D   $	��Top=�6X   $	��120��6p   6|   �� 5   
   -   5         ��Name$ 	btnBusRut��5      $��Buscar��6$   $
��Left=�65   $��
625,56,0,0q�6P   $	��Top=�6d   $	��148��6|   $��30��6�    � Cursor$
 Hand��6�   6�   �� 5   
   -   5        $ cmbTipo��5      $
��Left=�6$   $��
476,94,0,0q�6?   $	��Top=�6S   $	��120��6k   6w   �� 5   
   -   5        $ 
btnBusTipo��5      $��Buscar��6%   $
��Left=�66   $��
625,58,0,0q�6Q   $	��Top=�6e   $	��148��6}   $
 Hand��6�   6�   �� 5   
   -   5        $ 
btnBusActi��5      $��Buscar��6%   $
��Left=�66   $��
625,58,0,0q�6Q   $	��Top=�6e   $	��148��6}   $��30��6�   $
 Hand��6�   6�   �� 5   
   $4��.Imagenes/white_logo_transparent_background.png��6   $
��Left=�6I   $	��138��6d   $��	30,13,0,0q�6q   $	��Top=�6�   $	��191��6�   �� 5   
   -   5        $ btnModificar��5      $��	Modificar��6'   $
��Left=�6;   $��557,521,0,0q�6V   $	��Top=�6k   $��95��6�   6�   �� 5   
   -   5        $ btnEliminar��5      $��Eliminar��6&   $
��Left=�69   $��666,521,0,0q�6T   $	��Top=�6i   $��95��6�   6�   !   MahApps.Metro.Controls.Tile  5   
   -	   5        $��0,441,701,37q�5   '   $
��Auto��6=   $
��Auto��6K   ��6X   Z� .��5      � .+�5      �� $��imagenes/flechita.png��6   $��70��67   $��70��6B   6P   �� 5      $��Center=�6   $��Volver��65   $��10,70,-10,-44q�6F   $��70��6]    J� RenderTransformOrigin$ 	0.5,1.411&�6h   ���	#FFD4C4C46�   5       5!      �� 5"   
   -
   5         ��Name$ label��5"      $��RUT Cliente:��6   $
��Left=�66   $��
392,24,0,0q�6Q   $	��Top=�6e   
�������6}   �� 5#   
   -   5        $ label1��5#      $��
Actividad:��6    $
��Left=�65   $��
406,63,0,0q�6P   $	��Top=�6d   $ -0.219,-0.687&�6|   
�������$��30��6�   $��70��6�   �� 5$   
   -   5        $ label2��5$      $��Tipo:��6    $
��Left=�60   $��426,100,0,0q�6K   $	��Top=�6`   
�������6x   �� 5%   
   -   5         ��Name$ txtRut��5%      $
��Left=�6"   $��23��6=   $��
476,27,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   6�   �� 5&   
   -   5        $ button��5&      $��Seleccionar��6!   $
��Left=�67   $��342,521,0,0q�6R   $	��Top=�6g   $��75��6   6�   5)      5*      