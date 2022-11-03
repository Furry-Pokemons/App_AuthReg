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
using App_AuthReg.Windows;

namespace App_AuthReg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<int> Auth = AppData.Context.Database.SqlQuery<int>($"select [dbo].[Auth]('{Login_TB.Text}', '{Password_TB.Password}') as Info");
            int Auth_Result = int.Parse(Auth.ToList()[0].ToString());
            if (Auth_Result == 1)
            {
                WorkPlace workPlace = new WorkPlace();
                workPlace.Show();
                this.Close();
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
