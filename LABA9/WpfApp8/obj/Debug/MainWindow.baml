   M S B A M L   `   `   `  ????B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5   	       WpfApp8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp8     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5
       ?? 
TargetType   NavigationLabel ?? Property ?? Value ?? Triggers P? Property P? Value  HeaderLabel??%*  &	        &	     ?? 5   
   " ??6   .?5      ??  ? ??$ DemiBold"?6+   ?? 5       ?@?Cursor$
 Hand??6'    5      P? 5       ?@J?IsMouseOver . . ?5      ??  ? ??$
 Bold"?63   ?? 5       ? ??$ 12(?61   5      5      ?? 5   
   " ??6   .?5      ??  ? ??$ DemiBold"?6+   ?? 5       ?@?Cursor$
 Hand??6'    5      P? 5       ?@J?IsMouseOver .  . ?5      ??  ? ??$6 0Информация о пользователе??60   5      5      5      .??5!      ?  ? ColumnDefinitions 5"   
   ?? 5#      $??* ?6   	 ? RowDefinitions	 5%   
   ?? 5&      $??60 ?6   ?? 5'      $??* ?6   .+?5*   
   ?? $??0??6   
 ?? Orientation$
 
Horizontal=?6"   .+?5+      ?? -   5         ??Name$ Label1??5+      $%??Привзяка свойств??6$   #??[  6?   $
??Left=?6h   $??10,0,0,0q?6?   $??Center=?6?   $??30??6?   ?? 5,      $)??#Привязка коллекции??6   #??[  62   $
??Left=?6[   $??	100,0,0,0q?6v   $??Center=?6?   5-       ? 5.   
   -   5        $??	MainFrame??5.      $??1??6!   5/      50      