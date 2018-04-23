Imports System.Windows

Namespace Connecting_to_Hierarchical_Data
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = Staff.GetStaff()
            treeListView1.ExpandAllNodes()
        End Sub
    End Class
End Namespace
