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
//using Tkachev_WPFapp.Data;
//using Tkachev_WPFapp.Models;

namespace Tkachev_WPFapp.Windows
{
    /// <summary>
    /// Логика взаимодействия для CreateNewWindow.xaml
    /// </summary>
    public partial class CreateNewWindow : Window
    {
        //private Context _context;

        //public CreateNewWindow(Context context)
        //{
        //    _context = context;
        //    InitializeComponent();

        //    cb_techType.ItemsSource = _context.TechTypes.ToList();
        //    cb_client.ItemsSource = _context.Clients.ToList();
        //}

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {
            //if (cb_techType.SelectedItem != null
            //    && cb_techModel.SelectedItem != null
            //    && cb_client.SelectedItem != null
            //    && !string.IsNullOrEmpty(tbox_Desc.Text))
            //{
            //    Request newRequest = new()
            //    {
            //        StartDate = DateOnly.FromDateTime(DateTime.Now),
            //        TechModel = ((TechModel)cb_techModel.SelectedItem).Id,
            //        Description = tbox_Desc.Text,
            //        Status = _context.RequestStatuses.Where(r => r.Id == 3).First().Id,
            //        ClientId = ((Client)cb_client.SelectedItem).Id
            //    };

            //    _context.Requests.Add(newRequest);
            //    _context.SaveChanges();
            //    this.Close();
            //}
        }

        private void cb_techType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TechType selectedType = cb_techType.SelectedItem as TechType;
            //cb_techModel.ItemsSource = null;
            //cb_techModel.ItemsSource = _context.TechModels.Where(tm => tm.TechTypeId == selectedType.Id).ToList();
            //if (!cb_techModel.IsEnabled) { cb_techModel.IsEnabled = true; }
        }

        private void bt_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
