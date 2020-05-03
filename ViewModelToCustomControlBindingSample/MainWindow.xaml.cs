using System.Windows;
using System.Windows.Data;

namespace ViewModelToCustomControlBindingSample
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
        }

        private void OnSetUpBindings(object sender, RoutedEventArgs e)
        {
            SetUpBindings();
        }

        private void SetUpBindings()
        {
            // Bind ViewModel property : new Binding("TitleVM") with property path "TitleVM"
            // To CustomControl instance (MyCustomControl1) dependency property (MyCustomControl.TitleProperty)
            MyCustomControl1.SetBinding(MyCustomControl.TitleProperty, new Binding("TitleVM"));
        }

        private void OnUpdateTitle(object sender, RoutedEventArgs e)
        {
            viewModel.TitleVM += "!";
        }
    }
}
