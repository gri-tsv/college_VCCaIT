   M S B A M L   `   `   `  ����D  @wpf_my1st, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:wpf_my1st	wpf_my1st  5   	       wpf_my1st.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:wpf_my1st     5   	     � Title$  Login��5	   	   $	��700��6   $	��500��6$   $	��700��60   $	��500��6@    � WindowStartupLocation$ CenterScreen=�6O   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ title��5      $��2��6   $��Login Window��63   $
��Left=�6J   $��	150,0,0,0q�6e   $��Center=�6x   $��Center=�6�   $��Center=�6�   $	��200��6�   $��80��6�   $��Times New Roman)�6  $��23(�6$  $
��Bold"�62  ���	#FF0B1463��6�   Z� 6D  �� 5   
   -   5         ��Name$ login��5      $��1��6!   $��Center=�61   $��1��6N    �� TextWrapping$
 Wrap=�6[   $��email or phone��6o   $��Center=�6�   $	��200��6�   $	��100��6�   $��20(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   G� 5   
   -   5         G�Name$ PasswordHidden��5      $��Center=�6.   $��Center=�6R   $	��200��6t   $��1��6�   $��2��6�   $	��100��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ 
login_text��5      $��Login��6$   $��Center=�64   $��1��6R   $��Center=�6_   $��Center=�6z   $��Center=�6�   $��50��6�   $	��200��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ password_text��5      $��Password��6'   $��Center=�6:   $��2��6W   $��Center=�6d   $	��100��6   $��50��6�   $��16(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ log_in��5      $��Log in��6!   $
��Left=�62   $��4��6M   $��Center=�6Z   ���	#FF09BDF9$	��100��6�   $��50��6�   ���	#FF3BFF06$��RightToLeft=�6�   $��0,0,0,0q�6�   4  .System.Windows.Automation.AutomationProperties	   IsColumnHeader	 . $��	100,0,0,0q�6  �� 5   
   -   5        $ sign_ip��5      $��1��6"   $��Sign Up��62   $��Right=�6D   $��4��6`   $��Center=�6m   $��50��6�   $	��100��6�   ���	#FF13FF00$��	0,0,100,0q�6�   �� 5   
   -   5        
 ��Name$

 logo��5      $
��Left=�6   $	��100��69   $	��Top=�6F   $	��100��6^   $��	/logo.png��6j   �� 5   
   -	   5        $ PasswordUnmask��5      $y�Hidden=�6*   $��2��6>   $��2��6K   $��Center=�6[   $��Center=�6x   $	��100��6�   $	��200��6�   $��20(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��0 0 0 0q�6  �� 5    
   -
   5         ��Name$ ShowPassword��5       $
��SHOW��6*    �� TextAlignment$ Center=�6�   $
��Wrap=�6�   $��Center=�6�   $	��Top=�6  $��70��6  $��35��6$  $��20(�60  $
��Bold"�6>  $��1��6P  $��0,10,0,0q�6`  $��3��6r  5"      5$      