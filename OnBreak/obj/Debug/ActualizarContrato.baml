   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak 5	   	       OnBreak.ActualizarContrato   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      !localclr-namespace:OnBreak  5	   	     � Title$  ActualizarContrato��5   	   $	��600��6$   $	��800��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S   .��5      � 
�������.+�5   
   �� -   5         ��Name$ btnCrear��5      $��Crear��6#   $
��Left=�63   $��	0,360,0,0q�6N   $	��Top=�6a   $	��213��6y   $��39��6�    � Cursor$
 Hand��6�   �� 5   
   -   5         ��Name$ groupBox��5      $��CONTRATO��6%   $
��Left=�67   $��
213,70,0,0q�6R   $	��Top=�6f   $	��462��6~   $	��551��6�   .��5      � $
��Left=�6   $	��394��6.   $��
10,10,-2,0q�6;   $	��Top=�6O   $	��481��6g   .+�5      �� -   5         ��Name$ label8��5      $��Observaciones��6(   $
��Left=�6@   $��337,123,0,0q�6[   $	��Top=�6p   �� 5      -   5         ��Name$ txtObs��5      $
��Left=�6*   $	��116��6E   $��298,157,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��173��6�   �� 5      -   5        $ btnActualizar��5      $��
Actualizar��60   $
��Left=�6E   $��337,355,0,0q�6`   $	��Top=�6u   $��87��6�   $
 Hand��6�   6�   �� 5      -   5        $ txtContrato��5      $
��Left=�6/   $��23��6J   $��
147,33,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   {�.  6�   �� 5      -   5        $ txtCreacion��5      $
��Left=�6/   $��23��6J   $��
147,64,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   {�.  6�   �� 5      -   5        $ 
txtTermino��5      $
��Left=�6.   $��23��6I   $��
147,95,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5      -	   5        $ txtFIn��5      $
��Left=�6*   $��23��6E   $��147,126,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5      -
   5        	 ��Name$	 	cboRutAso��5      $
��Left=�6.   $��
337,46,0,0q�6I   $	��Top=�6]   $	��120��6u   6�   �� 5      -   5        $ txtMonto��5      $
��Left=�6,   $��23��6G   $��147,289,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   {�.  6�   �� 5      -   5        $ 
txtTerEven��5      $
��Left=�6.   $��23��6I   $��147,157,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5      -   5        $ label��5      $��Numero De Contrato��6'   $
��Left=�6D   $��	10,30,0,0q�6_   $	��Top=�6r   �� 5      -   5        $ label1��5      $��Creacion��6(   $
��Left=�6;   $��	10,61,0,0q�6V   $	��Top=�6i   
 J� RenderTransformOrigin$
 0.527,-0.269&�6�   �� 5      -   5        $ label2��5      $��Termino��6(   $
��Left=�6:   $��	10,92,0,0q�6U   $	��Top=�6h   $
 
-1.5,-0.75&�6�   �� 5      -   5        $ label3��5      $��Fecha de Inicio ��6(   $
��Left=�6C   $��
10,123,0,0q�6^   $	��Top=�6r   �� 5      -   5        $ label4��5      $��Fecha de Termino��6(   $
��Left=�6C   $��
10,154,0,0q�6^   $	��Top=�6r   $
 -0.658,-1.385&�6�   �� 5      -   5        $ label5��5      $��	Modalidad��6(   $
��Left=�6<   $��
15,219,0,0q�6W   $	��Top=�6k   $
 
1.41,0.837&�6�   �� 5       -   5        $ lblrutCliente��5       $��Rut Asociado��6/   $
��Left=�6F   $��
344,15,0,0q�6a   $	��Top=�6u   �� 5!      -   5        $ label6��5!      $��Total��6(   $
��Left=�68   $��
22,289,0,0q�6S   $	��Top=�6g   $��80��6   �� 5"      -   5        $	 cboxModalidades��5"      $
��Left=�64   $��147,219,0,0q�6O   $	��Top=�6d   $	��120��6|   $
 
1.11,1.092&�6�   6�   �� 5#      -   5        $ label5_Copy��5#      $��
Asistentes��6-   $
��Left=�6B   $��
15,188,0,0q�6]   $	��Top=�6q   �� 5$      -   5        $ txtAsistentes��5$      $
��Left=�61   $��23��6L   $��147,188,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5%      -   5        $ txtPersonalAdic��5%      $
��Left=�63   $��23��6N   $��147,258,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5&      -   5        $ label5_Copy1��5&      $��Personal Adicional��6.   $
��Left=�6K   $��
15,258,0,0q�6f   $	��Top=�6z   $
 
1.41,0.837&�6�   5'      5(      �� 5)   
   -   5        $ btnReg��5)      $��Regresar��6!   $
��Left=�64   $��	0,461,0,0q�6O   $	��Top=�6b   $	��213��6z   $��40��6�   $
 Hand��6�   �� 5*   
   $$��Imagenes/Document-Settings.png��6   $��0,70,581,333q�68   �� 5+   
   -   5        $ lblAcCon��5+      $��Actualizar Contrato��6"   $
��Left=�6@   $��
50,199,0,0q�6[   $	��Top=�6o   $
 -0.645,0.183&�6�   5-      5.      