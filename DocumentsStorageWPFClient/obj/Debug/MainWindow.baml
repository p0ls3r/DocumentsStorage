   M S B A M L   `   `   `  ????T  PDocumentsStorageWPFClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DocumentsStorageWPFClientDocumentsStorageWPFClient  5   	   *    $DocumentsStorageWPFClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:DocumentsStorageWPFClient     5   	     ? Title$  
MainWindow??5   	   $	??864??6   $
??1152??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??* ?6   6+   ?? 5      $	??900 ?6   6-    ? RowDefinitions 5   
   ?? 5      $??60 ?6   6*   ?? 5      $	??120 ?6   6+   ?? 5      $??* ?6   6)   .+?5   
   ?? -   5         ??Name$ ConnectionAdressField??5      $??1??61   $
??Left=?6A   $??25(?6\   $??40??6j   $??	10,10,0,0q?6v    ?? TextWrapping$
 Wrap=?6?   $?? ??6?   $	??Top=?6?   $	??880??6?   ?? 5   
   $
??Left=?6   $??25(?6/   $??	10,10,0,0q?6=   $
??Wrap=?6P   $??Connection Adress:??6d   $	??Top=?6~   $??40??6?   $	??224??6?   ?? 5   
   -   5         ??Name$ ConnectionButton??5      $??Get contracts??6J   $??25(?6b   $
??Left=?6p   $??	10,10,0,0q?6?   $??1??6?   $	??Top=?6?   $	??224??6?   $??42??6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DocumentsGrid??5         CanUserAddRows .     CanUserDeleteRows .  	   AutoGenerateColumns	 .  $??20(?6w   $??1??6?   $
??Left=?6?   $	??633??6?   $??	10,10,0,0q?6?   $??2??6?   $	??Top=?6?   $	??880??6?   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 61      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      ??  ?? Path$ Id?6<     5      $
 Name??6%   $	 200 63    5      ?? $
 Name?6>     5      $ Created Data??6%   $ * 6;    .  5      ?? $ CreatedDate? ?? StringFormat$ {0:d}??6[     5      $ Actualization Data??6%   $ * 6A    .  5      ?? $ ActualizationDate?$ {0:d}??6a   4  .System.Windows.Controls.DataGridCheckBoxColumn  5       $ Actual??6)   $	 100 69    .  5!      ?? $ Actual?6@   5#      ?? 5$   
   -   5        $ 
MessageBox??5$      $??16(?6&   $??1??64   $
??Left=?6D   $	??100??6_   $??	10,10,0,0q?6l   $??1??6   $
 Wrap=?6?   $	??Top=?6?   $	??880??6?   5'      5(      