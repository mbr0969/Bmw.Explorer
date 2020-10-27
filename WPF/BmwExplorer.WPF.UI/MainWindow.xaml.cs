using BmwExplorer.Shared.ViewModels;

namespace BmwExplorer.WPF.UI {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
