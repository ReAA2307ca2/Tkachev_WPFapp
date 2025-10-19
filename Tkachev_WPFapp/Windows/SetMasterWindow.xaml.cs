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
using System.Windows.Shapes;
using Tkachev_WPFapp.Data;
using Tkachev_WPFapp.Models;

namespace Tkachev_WPFapp.Windows
{
    /// <summary>
    /// Логика взаимодействия для SetMasterWindow.xaml
    /// </summary>
    public partial class SetMasterWindow : Window
    {
        private Context _context;
        private Request _request;

        public SetMasterWindow(Context context, Request request)
        {
            _context = context;
            _request = request;
            cb_master.ItemsSource = _context.Masters.ToList();
            if(request.)
            InitializeComponent();
        }

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {
            Master master = cb_master.SelectedItem as Master;
            _context.Comments.Where(c => c.RequestId == _request.Id).First().MasterId = master.Id;
            _context.SaveChanges();
            DialogResult = true;
            return;
        }

        private void bt_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbox_enableMaster_Click(object sender, RoutedEventArgs e)
        {
            cb_master.IsEnabled = ((CheckBox)sender).IsChecked ?? false;
        }
    }
}
