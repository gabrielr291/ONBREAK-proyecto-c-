   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak 5	   	      OnBreak.EliminarCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      !localclr-namespace:OnBreak  5	   	     � Title$  EliminarCliente��5   	   $	��600��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_   .��5      � 
�������.+�5   
   �� -   5         ��Name$ groupBox��5      $��DATOS CLIENTE��6%   $
��Left=�6<   $��
239,52,0,0q�6W   $	��Top=�6k   $	��479��6�   $	��521��6�   .��5      � $
��Left=�6   $	��442��6.   $��
10,10,-2,0q�6;   $	��Top=�6O   $	��501��6g   .+�5      �� -   5         ��Name$ label��5      $	��RUT��6'   $
��Left=�65   $��	38,42,0,0q�6P   $	��Top=�6c   �� 5      -   5        $ label1��5      $��RAZON SOCIAL��6(   $
��Left=�6?   $��	38,73,0,0q�6Z   $	��Top=�6m   �� 5      -   5        $ label2��5      $��NOMBRE��6(   $
��Left=�69   $��
38,104,0,0q�6T   $	��Top=�6h   �� 5      -   5        $ label3��5      $��CORREO/EMAIL��6(   $
��Left=�6?   $��
38,166,0,0q�6Z   $	��Top=�6n   �� 5      -   5        $ label4��5      $��	DIRECCION��6(   $
��Left=�6<   $��
38,135,0,0q�6W   $	��Top=�6k   �� 5      -   5        $ label5��5      $��TELEFONO��6(   $
��Left=�6;   $��
38,197,0,0q�6V   $	��Top=�6j    J� RenderTransformOrigin$ -1.553,-0.885&�6�   �� 5      -   5        $ label6��5      $��	ACTIVIDAD��6(   $
��Left=�6<   $��
38,228,0,0q�6W   $	��Top=�6k   �� 5      -	   5        $ label7��5      $
��TIPO��6(   $
��Left=�67   $��
38,259,0,0q�6R   $	��Top=�6f   �� 5      -
   5         ��Name$ txtRut��5      $
��Left=�6*   $��23��6E   $��
200,45,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5      -   5        $ txtRazon��5      $
��Left=�6,   $��23��6G   $��
200,76,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5      -   5        $ 	txtNombre��5      $
��Left=�6-   $��23��6H   $��200,107,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5      -   5        $ txtDireccion��5      $
��Left=�60   $��23��6K   $��200,138,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ 	txtCorreo��5      $
��Left=�6-   $��23��6H   $��200,169,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5      -   5        $ txtTelefono��5      $
��Left=�6/   $��23��6J   $��200,200,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5      -   5         ��Name$ cmbActividad��5      $
��Left=�61   $��200,232,0,0q�6L   $	��Top=�6a   $	��120��6y   �� 5      -   5        $ cmbTipo��5      $
��Left=�6,   $��200,263,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5      -   5        	 ��Name$	 	btnBuscar��5      $��Buscar��6,   $
��Left=�6=   $��
378,42,0,0q�6X   $	��Top=�6l   $��95��6�   $��40��6�   
 � Cursor$

 Hand��6�   6�   �� 5       -   5        $	 btnEliminar��5       $��Eliminar��6.   $
��Left=�6A   $��378,369,0,0q�6\   $	��Top=�6q   $��95��6�   $��40��6�   $

 Hand��6�   6�   5!      5"      �� 5#   
   -   5        $	 
btnAgregar��5#      $��Agregar��6%   $
��Left=�67   $��	0,248,0,0q�6R   $	��Top=�6e   $	��239��6}   $��40��6�   $

 Hand��6�   �� 5$   
   -   5        $	 btnActualizar��5$      $��
Actualizar��6(   $
��Left=�6=   $��	0,293,0,0q�6X   $	��Top=�6k   $	��239��6�   $ 	0.12,0.15&�6�   $��40��6�   $

 Hand��6�   �� 5%   
   -   5        $	 btnReg��5%      $��Regresar��6!   $
��Left=�64   $��	0,462,0,0q�6O   $	��Top=�6b   $	��239��6z   $��40��6�   $

 Hand��6�   �� 5&   
   $��Imagenes/User-Delete.png��6   $��0,52,555,355q�62   $ -8.762,2.138&�6H   �� 5'   
   -   5        $ label8��5'      $��Eliminar Cliente
��6    $
��Left=�6E   $��
74,174,0,0q�6`   $	��Top=�6t   $	��105��6�   5*      5+      