Imports System.Windows

Namespace Connecting_to_Hierarchical_Data

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetStaff()
            Me.treeListView1.ExpandAllNodes()
        End Sub
    End Class
End Namespace
