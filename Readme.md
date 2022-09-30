<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648599/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3127)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Tree List - Bind to Self-Referential Data Structure

This example shows how to create a self-referential data structure and display it in the [TreeListView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView).

![image](https://user-images.githubusercontent.com/65009440/193233902-8038d935-80ff-4482-a14d-66ce42ad82c3.png)

To display this tree structure, your data source should include the following fields of the same data type:

* **Key Field** - This field should contain unique values used to identify nodes. Assign its name to the [TreeListView.KeyFieldName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.KeyFieldName) property.
* **Parent Field** - This field should contain values that indicate parent nodes. Assign its name to the [TreeListView.ParentFieldName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ParentFieldName) property.

Set the [TreeListView.TreeDerivationMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.TreeDerivationMode) property to `Selfreference` to enable the self-referential mode.

## Files to Review

* [Employees.cs](./CS/Bind_to_SelfReferential_Data/Employees.cs) (VB: [Employees.vb](./VB/Bind_to_SelfReferential_Data/Employees.vb))
* [MainWindow.xaml](./CS/Bind_to_SelfReferential_Data/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Bind_to_SelfReferential_Data/MainWindow.xaml))

## Documentation

* [Bind to Self-Referential Data Structure](https://docs.devexpress.com/WPF/9571/controls-and-libraries/data-grid/display-hierarchical-data/bind-to-self-referential-data-structure)
* [Display Hierarchical Data](https://docs.devexpress.com/WPF/9700/controls-and-libraries/data-grid/display-hierarchical-data)
* [TreeListView.KeyFieldName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.KeyFieldName)
* [TreeListView.ParentFieldName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ParentFieldName)

## More Examples

* [WPF Tree List - Use the Child Nodes Selector to Create a Hierarchical Data Structure](https://github.com/DevExpress-Examples/how-to-implement-hierarchical-data-binding-via-child-nodes-selector-e3298)
* [WPF Tree List - Implement the Child Nodes Path](https://github.com/DevExpress-Examples/how-to-implement-childnodespath-t556239)
* [WPF Tree List - Use the Hierarchical Data Template to Build a Tree](https://github.com/DevExpress-Examples/how-to-build-a-tree-via-hierarchicaldatatemplate-e3410)
