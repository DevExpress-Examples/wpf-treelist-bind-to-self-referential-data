Imports System.Windows

Namespace Bind_to_SelfReferential_Data

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetStaff()
        End Sub
    End Class
End Namespace
