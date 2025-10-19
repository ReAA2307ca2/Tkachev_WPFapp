using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Tkachev_WPFapp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public Client Client { get; set; }
        public Operator Operator { get; set; }
        private Context _context;

        public AuthWindow(Context Context)
        {
            _context = Context;
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void bt_signInUser_Click(object sender, RoutedEventArgs e)
        {
            string loginTrim = tbox_login.Text.Trim();
            string passwordTrim = tbox_password.Text.Trim();
            if (!string.IsNullOrEmpty(loginTrim)
                || !string.IsNullOrEmpty(passwordTrim))
            {
                Client? client = _context.Clients.Where(c => c.Login == loginTrim && c.Password == passwordTrim).FirstOrDefault();
                if (client != null)
                {
                    Client = client;
                    DialogResult = true;
                    return;
                }
                Operator? oper = _context.Operators.Where(c => c.Login == loginTrim && c.Password == passwordTrim).FirstOrDefault();
                if (oper != null)
                {
                    Operator = oper;
                    DialogResult = true;
                    return;
                }
                else { MessageBox.Show("Invalid login or password"); }
            }
        }


    }
}
