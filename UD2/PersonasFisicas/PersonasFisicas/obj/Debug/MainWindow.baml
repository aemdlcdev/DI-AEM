   M S B A M L   `   `   `  ����J  FPersonasFisicas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PersonasFisicasPersonasFisicas  5   	        PersonasFisicas.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PersonasFisicas     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblProfesón��5
      $��
Profesión��6%   $
��Left=�69   $��105,114,0,0q�6T   $	��Top=�6i   �� 5   
   -   5         ��Name$ txtProfesion��5      $
��Left=�6(   $��210,118,0,0q�6C    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��165��6�   �� 5   
   -   5        $ lblHermanos��5      $��Nº Hermanos��6%   $
��Left=�6;   $��105,145,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $ txtNumHermanos��5      $
��Left=�6*   $��210,149,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $��55��6�   �� 5   
   -   5        $ lblEdadHermanos��5      $
��Edad��6)   $
��Left=�68   $��270,145,0,0q�6S   $	��Top=�6h   �� 5   
   $
��Left=�6   $��311,147,0,0q�6.   $	��Top=�6C   $��64��6[   .@�5      m� $��
De 15 a 18��6   m� 5      $��
De 19 a 30��6   m� 5      $��
De 31 a 60��6   5      �� 5   
   -   5        $ lblHermanos_Copiar��5      $
��Sexo��6,   $
��Left=�6;   $��105,176,0,0q�6V   $	��Top=�6k   	� 5   
   -   5         	�Name$ rbtMasculino��5      $��	Masculino��6,   $
��Left=�6@   $��210,187,0,0q�6[   $	��Top=�6p   	� 5   
   -   5        $ rbtFemenino��5      $��Femenino��6+   $
��Left=�6>   $��302,187,0,0q�6Y   $	��Top=�6n   �� 5   
   -	   5         ��Name$ 
chbDeporte��5      $'��!Practica algún deporte. ¿Cúal?��6'   $
��Left=�6P   $��105,217,0,0q�6k   $	��Top=�6�   �� 5   
   -
   5        $��105,240,425,105q�5      .@�5      �� $��Fútbol��6   �� 5      $��Tenis��6   �� 5      $��Piragüismo��6   �� 5      $��
Baloncesto��6   �� 5      $��Boxeo��6   5      �� 5   
   -   5        $ lblGrado��5      $0��*Marque del 1 al 10 su grado de afición a:��6"   $
��Left=�6V   $��467,114,0,0q�6q   $	��Top=�6�   $	��228��6�   �� 5    
   -   5        $ 
lblCompras��5       $
��Left=�6$   $��467,145,0,0q�6?   $	��Top=�6T   $	��228��6l   $��Compras��6x   �� 5!   
   -   5         ��Name$ 
sliCompras��5!      $
��Left=�6%   $��475,180,0,0q�6@   $	��Top=�6U   $	��220��6m   �� 5"   
   -   5        $ lblTelevision��5"      $
��Left=�6'   $��	467,0,0,0q�6B   $��Center=�6U   $	��228��6p   $��Ver la televisión��6|   �� 5#   
   -   5        $ sliTelevision��5#      $
��Left=�6(   $��475,240,0,0q�6C   $	��Top=�6X   $	��220��6p   �� 5$   
   -   5        $ lblCine��5$      $
��Left=�6!   $��467,276,0,0q�6<   $	��Top=�6Q   $	��228��6i   $��
Ir al cine��6u   �� 5%   
   -   5        $ sliCine��5%      $
��Left=�6"   $��475,311,0,0q�6=   $	��Top=�6R   $	��220��6j   �� 5&   
   -   5         ��Name$ btnRegistrar��5&      $��	Registrar��6'   $
��Left=�6;   $��105,354,0,0q�6V   $	��Top=�6k   $��45��6�   $	��114��6�   �� 5'   
   -   5        $ btnSalir��5'      $��Salir��6#   $
��Left=�63   $��581,354,0,0q�6N   $	��Top=�6c   $��45��6{   $	��114��6�   6�   5)      5*      