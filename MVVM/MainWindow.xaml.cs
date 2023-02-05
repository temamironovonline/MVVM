using System.Windows;

namespace MVVM
{
    public partial class MainWindow : Window
    {
        ViewModel VM = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = VM;
            CommandBindings.Add(VM.bind);
        }
    }
}
