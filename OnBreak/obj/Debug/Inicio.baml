   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak 5	   	      OnBreak.Inicio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      !localclr-namespace:OnBreak  5	   	     � Title$  OnBreak: Inicio��5   	   $	��600��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   (   "MahApps.Metro.Controls.MetroWindow   UseNoneWindowStyle .  � WindowStyle$
 None=�6�   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0.182Q�6-   � 5      $ 	#FF0C059C��6   $ 0.766Q�61   5      .+�5   
   �� -   5        	 ��Name$	 image��5      $
��Left=�6   $	��256��6:   $��
271,10,0,0q�6G   $	��Top=�6[   $	��262��6s   $4��.Imagenes/white_logo_transparent_background.png��6   �� 5   
   -   5        
 ��Name$
 groupBox��5      $��CLIENTE��6%   $
��Left=�66   $��127,357,0,0q�6Q   $	��Top=�6f   $	��168��6~   $	��181��6�   ���	#CC050A21���	#CC8DC2D8.��5      � $
��Left=�6   $	��124��6.   $��
10,10,-2,0q�6;   $	��Top=�6O   $	��161��6g   .+�5      �� -   5         ��Name$ btnAgregarCl��5      $��Administrar��6/   $
��Left=�6E   $��	32,10,0,0q�6`   $	��Top=�6s   $��98��6�   $��42��6�    � Cursor$
 Hand��6�   ���	#FF7DB8E06�   �� 5      -   5        $ btnListarCl��5      $��Listar��6.   $
��Left=�6?   $��	32,72,0,0q�6Z   $	��Top=�6m   $��98��6�   $��42��6�   $
 Hand��6�   ���	#FF7DB8E06�   5      5      �� 5   
   -   5        $
 	groupBox1��5      $��CONTRATO��6&   $
��Left=�68   $��505,357,0,0q�6S   $	��Top=�6h   $	��168��6�   $	��181��6�    J� OpacityMask �	#FF060340���	#CC92C6DC���	#CC070521.��5      � $	��124��6   $��	0,10,-2,0q�6    $	��Top=�63    J� RenderTransformOrigin$ 
0.55,0.492&�6K   .+�5      �� -   5        $ btnAgregarCon��5      $��Administrar��60   $
��Left=�6F   $��	39,10,0,0q�6a   $	��Top=�6t   $	��100��6�   $��42��6�   $
 Hand��6�   ���	#FF7DB8E06�   �� 5      -   5        $ btnListarCon��5      $��Listar��6/   $
��Left=�6@   $��	39,78,0,0q�6[   $	��Top=�6n   $	��100��6�   $��42��6�   $
 Hand��6�   ���	#FF7DB8E06�   5      5       !   MahApps.Metro.Controls.Tile  5!   
   -   5        $��669,27,32,451q�5!   '   $
��Auto��6>   $
��Auto��6L   ��6Y   Z� .��5"      � .+�5#      �� $��imagenes/Off.png��6   $��70��62   $��70��6=   6K   �� 5$      $��Center=�6   $��Salir��65   $��28,70,-28,-44q�6E   $��70��6\   $ 	0.5,1.411&�6g   ���	#FFD4C4C46�   5%      5&      �� 5'   
   $
��Left=�6   $��67��6+   $��127,290,0,0q�67   $	��Top=�6L   $��67��6d   $��Imagenes/user.png��6o   �� 5(   
   $
��Left=�6   $��81��6+   $��505,290,0,0q�67   $	��Top=�6L   $��67��6d   $��Imagenes/contrat.png��6o   5*      5+      