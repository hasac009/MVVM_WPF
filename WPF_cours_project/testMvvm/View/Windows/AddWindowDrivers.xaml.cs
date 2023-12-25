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
using testMvvm.Model;
using testMvvm.ViewModels;

namespace testMvvm.View.Windows
{
    
    public partial class AddWindowDrivers : Window
    {
        private DbTools db;
        public AddWindowDrivers(DbTools db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Driver driver = new Driver();
            driver.name = DriverName.Text;
            driver.phone = DriverPhone.Text;
            db.InsertDriverIntoTable(driver);
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           this.Close();    
        }
    }
}
