using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MarkdownPlayground.ViewModel;

namespace MarkdownPlayground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        private void OnLostForcus(object? sender, EventArgs e)
        {
            Console.WriteLine();
        }
        private void OnWindowActivated(object? sender, EventArgs e)
        {
            MainWindowVM vm = (MainWindowVM)DataContext;
            vm.ReadMdFile();
        }
    }
}