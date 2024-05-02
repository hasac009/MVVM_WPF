
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private Office drivers;
        public AddWindowDrivers(Office drivers)
        {
            InitializeComponent();
            this.drivers = drivers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Driver driver = new Driver();
            if (string.IsNullOrWhiteSpace(DriverName.Text))
            {
                MessageBox.Show("Enter the driver's name.");
                return; 
            }
            driver.name = DriverName.Text;
            
            if (DriverPhone.Text.Length < 11 || DriverPhone.Text.Length > 13)
            {
                MessageBox.Show("The length of the phone number is incorrect. Must be between 10 and 12 digits.");
                return; 
            }

            driver.phone = DriverPhone.Text;
            drivers.Add(driver);
            drivers.GetAll();
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
