Reusuable DLLs Sample
=========================================

Common.Library - This library is for classes to be used in any application
AdventureWorks.EntityLayer - Entity classes for the AdventureWorks application are in this library
AdventureWorks - This is a WPF application that references the other two libraries

NOTES: Remove the Namespace statement from classes in DLL since the DLL name is the Namespace

- Build AdventureWorks WPF application
- Build Common.Library
	Bring in CommonBase03 and rename
	Remove Namespace
- Build AdventureWorks.EntityLayer
	Bring in Product03, Customer03 and rename
	Remove Namespace
	Add Color, Size and Weight properties to Product class
- Add menu to MainWindow
- Add ProductDetailControl and CustomerDetailControl
- Build screens to display a product and a customer
