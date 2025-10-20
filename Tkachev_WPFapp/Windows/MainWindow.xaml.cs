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
//using Tkachev_WPFapp.Data;
using Tkachev_WPFapp.Windows.Usercontrols;

namespace Tkachev_WPFapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Context _context = new Context();

        public MainWindow()
        {
            //AuthWindow authWindow = new AuthWindow(_context);
            //authWindow.ShowDialog();
            InitializeComponent();

            //if (authWindow.DialogResult == true)
            //{
            //    if (authWindow.Client != null)
            //    {

            //    }

            //    if (authWindow.Operator != null)
            //    {
            //        cc_main.Content = new OperatorUserControl(_context);
            //    }
            //}
            //else
            //{
            //    this.Close();
            //}
        }
    }
}