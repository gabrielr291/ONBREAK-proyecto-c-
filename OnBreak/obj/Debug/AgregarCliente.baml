   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak 5	   	      OnBreak.AgregarCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      !localclr-namespace:OnBreak  5	   	     � Title$  AgregarCliente��5   	   $	��600��6    $	��800��6-    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O    � ShowInTaskbar .  (   "MahApps.Metro.Controls.MetroWindow   IsCloseButtonEnabled .      IsMaxRestoreButtonEnabled .     IsMinButtonEnabled .     UseNoneWindowStyle .  � WindowStyle$
 None=�6�   	 � ContextMenu	 5      �� 5   
   .��5      � 
 J� RenderTransformOrigin$
 0.5,0.5&�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0.237Q�6-   � 5      $ 	#FF051BAA��6   $ 0.668Q�61   5      .+�5   
   �� -   5         ��Name$ groupBox��5      $��DATOS CLIENTE��6%   $
��Left=�6<   $��
245,16,0,0q�6W   $	��Top=�6k   $	��481��6�   $	��518��6�   ���	#CC000000���	#CCC7EEFF.��5      � $��
10,10,-2,5q�6   .+�5      �� -   5         ��Name$ label��5      $	��RUT��6'   $
��Left=�65   $��	38,42,0,0q�6P   $	��Top=�6c   
�������6{   �� 5      -   5        $ label1��5      $��RAZON SOCIAL
��6(   $
��Left=�6I   $��	38,73,0,0q�6d   $	��Top=�6w   
�������6�   �� 5      -   5        $ label2��5      $��NOMBRE��6(   $
��Left=�69   $��
38,104,0,0q�6T   $	��Top=�6h   
�������6�   �� 5      -   5        $ label3��5      $��CORREO/EMAIL��6(   $
��Left=�6?   $��
38,169,0,0q�6Z   $	��Top=�6n   
�������6�   �� 5      -   5        $ label4��5      $��	DIRECCION��6(   $
��Left=�6<   $��
38,138,0,0q�6W   $	��Top=�6k   
�������6�   �� 5      -   5        $ label5��5      $��TELEFONO��6(   $
��Left=�6;   $��
38,200,0,0q�6V   $	��Top=�6j   $
 -1.553,-0.885&�6�   
�������6�   �� 5      -   5        $ label6��5      $��	ACTIVIDAD��6(   $
��Left=�6<   $��
38,238,0,0q�6W   $	��Top=�6k   
�������6�   �� 5      -	   5        $ label7��5      $
��TIPO��6(   $
��Left=�67   $��
38,272,0,0q�6R   $	��Top=�6f   
�������6~   �� 5       -
   5         ��Name$ txtRut��5       $
��Left=�6*   $��23��6E   $��
200,45,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   6�   �� 5!      -   5        $ txtRazon��5!      $
��Left=�6,   $��23��6G   $��
200,76,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   {�.  6�   �� 5"      -   5        $ 	txtNombre��5"      $
��Left=�6-   $��23��6H   $��200,107,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   {�.  6�   �� 5#      -   5        $ txtDireccion��5#      $
��Left=�60   $��23��6K   $��200,138,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5$      -   5        $ 	txtCorreo��5$      $
��Left=�6-   $��23��6H   $��200,169,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   {�.  6�   �� 5%      -   5        $ txtTelefono��5%      $
��Left=�6/   $��23��6J   $��200,200,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   {�.  *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Ej. 569xxxxxxx��6�   �� 5&      -   5         ��Name$ cmbActividad��5&      $
��Left=�61   $��200,233,0,0q�6L   $	��Top=�6a   $	��120��6y   {�.  6�   �� 5'      -   5        $ cmbTipo��5'      $
��Left=�6,   $��200,269,0,0q�6G   $	��Top=�6\   $	��120��6t   {�.  6�   �� 5(      -   5         ��Name$ 
btnAgregar��5(      $��Agregar��6-   $
��Left=�6?   $��378,380,0,0q�6Z   $	��Top=�6o   $��87��6�   $��33��6�    � Cursor$
 Hand��6�   5)      5*      �� 5+   
   -   5        $ btnActualizar��5+      $��
Actualizar��6(   $
��Left=�6=   $��
28,226,0,0q�6X   $	��Top=�6l   $	��192��6�   $��40��6�   $
 Hand��6�   �� 5,   
   -   5        $ btnEliminar��5,      $��Eliminar��6&   $
��Left=�69   $��
28,271,0,0q�6T   $	��Top=�6h   $	��192��6�   $
 	0.12,0.15&�6�   $��40��6�   $
 Hand��6�   �� 5-   
   $4��.Imagenes/white_logo_transparent_background.png��6   $
 -11.875,-6.1&�6H   $��28,34,555,397q�6m   �� 5.   
   -   5        $ 	btnListar��5.      $��Listar Clientes��6$   $��28,316,580,0q�6>   $	��Top=�6T   $��38��6l   6x   !   MahApps.Metro.Controls.Tile  5/   
   -   5        $��0,441,701,37q�5/   '   $
��Auto��6=   $
��Auto��6K   ��6X   Z� .��50      � .+�51      �� $��imagenes/flechita.png��6   $��70��67   $��70��6B   $	��Top=�6N   6h   �� 52      $��Center=�6   $��Volver��65   $��10,70,-10,-44q�6F   $��70��6]   $
 	0.5,1.411&�6h   ���	#FFD4C4C46�   53      54      55      56      