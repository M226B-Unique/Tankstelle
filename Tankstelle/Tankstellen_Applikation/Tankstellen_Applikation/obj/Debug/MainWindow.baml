   M S B A M L   `   `   `  ����R  NTankstellen_Applikation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Tankstellen_ApplikationTankstellen_Applikation  5   	   (    "Tankstellen_Applikation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Tankstellen_Applikation     5   	     � Title$  
MainWindow��5   	   $
��1080��6   $
��1920��6*    � WindowStartupLocation$ CenterOwner=�67    � WindowState$ 	Maximized=�6[    � 
ResizeMode$ NoResize=�6s    � WindowStyle$
 None=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   �  5      �� 5      6"   �� 5      6"   .+�5      �� $��30(�6   $
��Bold"�6"   $��5q�64   .��6?   Tankstellenapplikation6W   �� 5       �� Orientation$ 
Horizontal=�6   $��1��62   .+�5      �� $��20(�6   .��6&   $"Aktueller Benzinpreis: XX.XX CHF |6J   �� 5      $��20(�6   .��6&   *(Aktueller Super-Benzinpreis: XX.XX CHF |6P   �� 5      $��20(�6   .��6&   $"Aktueller Dieselpreis: XX.XX CHF |6J   5      5      � 5   
   $��1��6   .+�5"      �� $ 
Horizontal=�6   .+�5#       � -   5        $��Zapfsäule_0��5#      $��5q�6+     � NavigationUIVisibility$ Hidden=�6?    � 5$      -   5        $��Zapfsäule_1��5$      $��5q�6+   $ Hidden=�6?    � 5%      -   5        $��Zapfsäule_2��5%      $��5q�6+   $ Hidden=�6?    � 5&      -   5        $��Zapfsäule_3��5&      $��5q�6+   $ Hidden=�6?    � 5'      -   5        $��Zapfsäule_4��5'      $��5q�6+   $ Hidden=�6?    � 5(      -   5        $��Zapfsäule_5��5(      $��5q�6+   $ Hidden=�6?    � 5)      -   5        $��Zapfsäule_6��5)      $��5q�6+   $ Hidden=�6?    � 5*      -   5        $��Zapfsäule_7��5*      $��5q�6+   $ Hidden=�6?    � 5+      -	   5        $��Zapfsäule_8��5+      $��5q�6+   $ Hidden=�6?    � 5,      -
   5        $��Zapfsäule_9��5,      $��5q�6+   $ Hidden=�6?   5-      5/      51      52      