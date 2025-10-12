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
using Tkachev_WPFapp.Data;

namespace Tkachev_WPFapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Context _context { get; set; } = new Context();

        public MainWindow()
        {
            AuthWindow authWindow = new AuthWindow(_context);
            authWindow.ShowDialog();
            InitializeComponent();
        }
    }
}