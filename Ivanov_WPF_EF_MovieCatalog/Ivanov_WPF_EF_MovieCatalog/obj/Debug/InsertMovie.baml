   M S B A M L   `   `   `  ����U  QIvanov_WPF_EF_MovieCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Ivanov_WPF_EF_MovieCatalogIvanov_WPF_EF_MovieCatalog  5   	   ,    &Ivanov_WPF_EF_MovieCatalog.InsertMovie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Ivanov_WPF_EF_MovieCatalog     5   	   -   5          �Name$  AddMovieWindow��5   	    � Title$ Insert movie��5   	   $	��290��6   $	��415��6+    � WindowStartupLocation$ CenterOwner=�67    � 
ResizeMode$ NoResize=�6[   .��5      � -   5        ���#161523.+�5   
   �� -   5         ��Name$ titleTB��5      $��Bottom=�5      $��161,0,10,210q�5       �� TextWrapping$
 Wrap=�5      $�� Title��5      
����������#211F2E���	#FF434343 � UseLayoutRounding . $��Center=�5      $��30��64   6@   �� 5   
   -   5        $ yearTB��5      $��Bottom=�5      $��160,0,10,172q�5      $
 Wrap=�5      $�� Year��5      
����������#211F2E���	#FF434343 . $��Center=�5       $��30��64   6@   �� 5!   
   -   5        $ budgetTB��5!      $��Bottom=�5"      $��160,0,10,135q�5#      $
 Wrap=�5$      $�� Budget��5%      
����������#211F2E���	#FF434343 . $��Center=�5*      $��30��64   6@   �� 5+   
   -   5        $ 	countryTB��5+      $��Bottom=�5,      $��160,0,10,98q�5-      $
 Wrap=�5.      $�� Country��5/      
����������#211F2E���	#FF434343 . $��Center=�54      $��30��64   6@   �� 55   
   -   5        $ descriptionTB��55      $��Bottom=�56      $��160,0,10,60q�57      $
 Wrap=�58      $�� Description��59      
����������#211F2E���	#FF434343 . $��Center=�5>      $��30��64   6@   �� 5@   
   -   5         ��Name$ insertB��5@      $��Bottom=�5A      $��Insert��5B      $��	18,0,0,16q�5C      ���#938FBD   roundedButtonForDialogs#���   5E      $��30��5F      $
��Left=�6   $	��110��68   6D   �� 5G   
   -	   5        $ clearB��5G      $��Bottom=�5H      $��Clear��5I      $��
146,0,0,16q�5J      ���#938FBD#���   5L      $��30��5M      $
��Left=�6   $	��110��68   6D   �� 5N   
   -
   5        $ cancelB��5N      $��Bottom=�5O      $��Cancel��5P      $��
274,0,0,16q�5Q      ���#938FBD#���   5S      $��30��5T      $
��Left=�6   $	��110��68   6D   �� 5V   
   -   5         ��Name$ 
movieImage��5V      $��Bottom=�5W      $��13,0,253,60q�5X      $��Icons/picture.png��5Y      	 � IsSharedSizeScope	 . $
��Fill=�5[       . $	��180��5]      
 � Cursor$

 Hand��6   6+   5_      5`      