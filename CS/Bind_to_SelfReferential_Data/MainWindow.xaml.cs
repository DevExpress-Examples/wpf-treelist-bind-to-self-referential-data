using System.Windows;

namespace Bind_to_SelfReferential_Data {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Employees.GetStaff();
        }
    }
}
