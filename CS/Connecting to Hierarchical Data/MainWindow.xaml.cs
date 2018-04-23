using System.Windows;

namespace Connecting_to_Hierarchical_Data {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Staff.GetStaff();
            treeListView1.ExpandAllNodes();
        }
    }
}
