   M S B A M L   `   `   `  ???? T  PDocumentsStorageWPFClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DocumentsStorageWPFClientDocumentsStorageWPFClient  *    $DocumentsStorageWPFClient.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:DocumentsStorageWPFClient       ? Title$  
MainWindow??$	??864??$
??1152??.???  ? ColumnDefinitions ?? $??* ??? $	??900 ? ? RowDefinitions ?? $??60 ??? $	??120 ??? $??* ?.+??? -    ??Name$ ConnectionAdressField??$??1??$
??Left=?$??25(?$??40??$??	10,10,0,0q? ?? TextWrapping$
 Wrap=?$?? ??$	??Top=?$	??880???? $
??Left=?$??25(?$??	10,10,0,0q?$
??Wrap=?$??Connection Adress:??$	??Top=?$??40??$	??224???? -    ??Name$ ConnectionButton??$??Get contracts??$??25(?$
??Left=?$??	10,10,0,0q?$??1??$	??Top=?$	??224??$??42??&   System.Windows.Controls.DataGrid  -     Name$ DocumentsGrid??   CanUserAddRows .     CanUserDeleteRows .  	   AutoGenerateColumns	 .  $??20(?$??1??$
??Left=?$	??633??$??	10,10,0,0q?$??2??$	??Top=?$	??880??
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id??   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding ??  ?? Path$ Id?  $
 Name??$	 200  ?? $
 Name?  $ Created Data??$ *  .  ?? $ CreatedDate? ?? StringFormat$ {0:d}??  $ Actualization Data??$ *  .  ?? $ ActualizationDate?$ {0:d}??4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Actual??$	 100  .  ?? $ Actual??? -   $ 
MessageBox??$??16(?$??1??$
??Left=?$	??100??$??	10,10,0,0q?$??1??$
 Wrap=?$	??Top=?$	??880??