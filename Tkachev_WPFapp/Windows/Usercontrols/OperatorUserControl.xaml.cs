using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using Tkachev_WPFapp.Models;

namespace Tkachev_WPFapp.Windows.Usercontrols
{
    /// <summary>
    /// Логика взаимодействия для OperatorUserControl.xaml
    /// </summary>
    public partial class OperatorUserControl : UserControl
    {
        public List<Request> RequestsList { get; set; }

        private Context _context;
        public OperatorUserControl(Context context)
        {
            DataContext = this;
            _context = context;
            RequestsList = _context.Requests.ToList();

            InitializeComponent();
        }

        private void bt_createNew_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
