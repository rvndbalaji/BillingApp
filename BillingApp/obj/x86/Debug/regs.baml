   M S B A M L   `   `   `  ����  
BillingApp    BillingApp.regs   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$	  reg��5   	    � Title$ Institution Registration��5       � Icon$ Images/note1.ico��6&    � WindowStartupLocation$ CenterScreen=�6>    � WindowState$ 	Maximized=�6c   $
��1366��6{   $	��740��6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��684* �6   �� 5      $
��337* �6   �� 5	      $
��338* �6   .+�5   
   �� -   5         ��Name$ logo1��5   K   $��57��6   $
��Left=�6   $��
482,10,0,0q�67    J� OpacityMask
 �   �$��Images/note1.ico��6n   $��Uniform=�6�   $	��Top=�6�   $��60��6�   �� 5   
   -   5         ��Name$ title��5   �   $��Institution Registration��6   $��Gabriola)�63   $��45(�6I   $��Normal"�6W   $
��Left=�6k   $��547,0,0,602q�6�   $	��332��6�   $��2��6�   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ 	#FF003A8D��6#    � Offset$ 0.623Q�65   � 5      $ 	#FF00CFD9��6#   5      5      �� 5   
   -   5         ��Name$	 add��5      $��Add Instituition��6   $
��Left=�69   $��37��6T   $��
10,130,0,0q�6`   $	��Top=�6t   $	��201��6�   $��18(�6�    � Cursor$
 Hand��6�   $��2��6�   ���	#FFC39D37$��1��6�    �� 	IsDefault . ���	#6BC357376  �� 5   
   -   5         ��Name$
 inst��5      $��10,172,0,10q�6    $��Visible=�65   $��17(�6h    �� SelectionMode$ Extended=�6v   �� 5   
   -   5         ��Name$	 nme��5      $
��Left=�6   $��37��6:   $��
10,130,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��674��6�   $��20(�6�   $��Italic$�6�   $��1��6�   �� 5   
   -   5        $ remove��5      $��Remove Instituition��6!   $
��Left=�6?   $��37��6Z   $��
10,172,0,0q�6f   $	��Top=�6z   $	��201��6�   $��18(�6�   $
 Hand��6�   $��41��6�   ���	#FFC39D37$��1��6�   ���	#6BC357376	  �� 5   
   -   5        $ 
title_Copy��5   �   $!��Add or Remove Instituitions��6   $��Gabriola)�66   $��35(�6L   $��Normal"�6Z   $
��Left=�6n   $��10,76,0,579q�6�   $	��313��6�   ��5      �� 5      $	 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67   $
 0.5,0&�6[   .��5      � $ Black��6#   $ 1Q�61   � 5      $ DimGray��6#   $ 0Q�63   5      5      �� 5    
   -	   5        $
 save��5       $��Save Register��6   $��Right=�67   $��54��6S   $��0,266,175,0q�6_   $	��Top=�6t   $	��325��6�   $��18(�6�   $
 Hand��6�   $��41��6�   ���	#FF00AF06$��1��6�    . $��2��6�   ��5!      �� 5"      $	 0.5,1&�6&   $
 0.5,0&�67   .��5#      � $ 	#FF00AF6F��6#   $ 1Q�65   � 5$      5%      5'      �� 5(   
   $��1��6   $
��Left=�6#   $	��184��6>   $��
64,384,0,0q�6K   $	��Top=�6_   $	��546��6w   
���   �$��16(�6�   $��Normal"�6�   $��Normal$�6�   $��Segoe Print)�6�   $��2��6�   ��6�   Z� ��5)      �� 5*      $	 0.5,1&�6&   $
 0.5,0&�67   .��5+      � $ 	#FFC37037��6#   $ 0Q�65   � 5,      $ White��6#   $ 1Q�61   5-      .��5/      � $��Stretch=�6   $��Stretch=�61    50      �� 51      $	��49* �6'   �� 52      $
��360* �6'   .+�54      �� -
   5         ��Name$ nm��54   C   $��39��6   $
��Left=�6(   $��Register Stats��6O   $��Center=�6e   $	��559��6�    �� TextAlignment$ Center=�6�   $��18(�6�   $��2��6�   $��-14,1,-11,138q�6�   ��55      �� 56      $	 0.5,1&�6.   $
 0.5,0&�6?   .��57      � $ White��6+   $ 0Q�69   � 58      $ Transparent��6+   $ 1Q�6?   59      5:   .   �� 5;      -   5        $ nm_Copy��5;   E   $��32��6   $��Center=�6(   $��Regd. Institutions :��6V   $��Center=�6r   $	��151��6�   $��16(�6�   $��2��6�   $��0,44,383,102q�6�   �� 5<      -   5        $ no��5<   E   $��31��6   $��Center=�6(   $��Center=�6Q   $	��151��6l   $��18(�6x   $��95,45,224,102q�6�   $��1��6�   $��0��6�   $
��Bold"�6�   $��Palatino Linotype)�6�   ��6�   Z� 6�   �� 5=      -   5        $ nm_Copy1��5=   E   $��32��6   $��Center=�6(   $��Total Orders :��6W   $��Center=�6m   $	��151��6�   $��16(�6�   $��2��6�   $��0,75,383,71q�6�   �� 5>      -   5        $
 bill��5>   E   $��31��6   $��Center=�6(   $��Center=�6S   $	��151��6n   $��18(�6z   $��95,76,224,71q�6�   $��1��6�   $��0��6�   $
��Bold"�6�   $��Palatino Linotype)�6�   ��6�   Z� 6�   �� 5?      -   5        $ nm_Copy2��5?   E   $��32��6   $��Center=�6(   $��Last Updated :��6W   $��Center=�6m   $	��151��6�   $��16(�6�   $��2��6�   $��0,107,383,39q�6�   �� 5@      -   5        $
 time��5@   E   $��31��6   $��Center=�6(   $��Center=�6S   $	��250��6n   $��18(�6z   $��95,107,125,40q�6�   $��1��6�   $
��Bold"�6�   $��Palatino Linotype)�6�   ��6�   Z� 6�   5A      5B      5D      ��5E      �� 5F   
   $	 0.5,1&�6   $
 0.5,0&�6/   .��5G      � $ White��6   $ 0.797Q�6)   � 5H      $ 	#FF57CAA0��6   $ 1Q�6-   � 5I      $ 	#FF57CAA0��6   $ 0Q�6-   � 5J      $ White��6   $ 0.174Q�6)   � 5K      $ White��6   $ 0.543Q�6)   5L      5N      