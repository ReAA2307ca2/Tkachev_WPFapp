using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;
//using Tkachev_WPFapp.Data;
//using Tkachev_WPFapp.Models;

namespace Tkachev_WPFapp.Windows.Usercontrols
{
    /// <summary>
    /// Логика взаимодействия для OperatorUserControl.xaml
    /// </summary>
    public partial class OperatorUserControl : UserControl
    {
        //public ObservableCollection<Request> RequestsList { get; set; }
        //public ObservableCollection<Comment> CommentsList { get; set; }

        //private Context _context;
        //public OperatorUserControl(Context context)
        //{
        //    DataContext = this;
        //    _context = context;
        //    RequestsList = _context.Requests.Local.ToObservableCollection();
        //    foreach(Request request in RequestsList)
        //    {
        //        request.TechModelNavigation = _context.TechModels.Find(request.TechModel);
        //        request.Client = _context.Clients.Find(request.ClientId);
        //        request.StatusNavigation = _context.RequestStatuses.Find(request.Status);
        //    }
        //    InitializeComponent();
        //}

        private void bt_createNew_Click(object sender, RoutedEventArgs e)
        {
            //CreateNewWindow createNewWindow = new(_context);
            //createNewWindow.ShowDialog();
        }

        private void bt_setMaster_Click(object sender, RoutedEventArgs e)
        {
            //if (lv_requests.SelectedItem != null) {
            //    SetMasterWindow newWin = new SetMasterWindow(_context, lv_requests.SelectedItem as Request);
            //    newWin.ShowDialog();

                //if(newWin.DialogResult == true)
                //{
                //    lv_requests.ItemsSource = null;

                //}
            //}
        }
    }
}
