<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/199044769/20.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802157)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/DataGridEditBySeparateButton/Pages/Index.razor)
<!-- default file list end -->

### Blazor Data Grid - How to edit/delete the selected row by clicking on external buttons

The Data Grid was moved to maintenance support mode. No new features/capabilities will be added to this component. We recommend that you [migrate](https://docs.devexpress.com/Blazor/403162/grid/migrate-from-data-grid-to-grid) to the [Grid](https://docs.devexpress.com/Blazor/403143/grid) component. 

This example illustrates how to start editing/delete the selected row in DxDataGrid programmatically. 
Our Data Grid provides the *StartRowEdit* method, which accepts a data item from the grid's data source. 
It's possible to use this method to edit the selected row when some external button is clicked. 
Also, this method accepts null as an argument to start a new row editing. 
