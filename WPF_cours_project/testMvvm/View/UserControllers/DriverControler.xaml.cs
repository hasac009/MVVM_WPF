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
using testMvvm.Model;
using testMvvm.ViewModels;

namespace testMvvm.View.UserControllers
{
    /// <summary>
    /// Логика взаимодействия для DriverControler.xaml
    /// </summary>
    public partial class DriverControler : UserControl
    {
        Office drivers;
        public DriverControler(Office drivers)
        {
            InitializeComponent();
            MyDG.ItemsSource = drivers.GetAll();
            this.drivers = drivers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (MyDG.SelectedItems.Count > 0)
            {
                Driver selectedDriver = MyDG.SelectedItem as Driver;
                drivers.del(selectedDriver);
                MyDG.ItemsSource = drivers.GetAll();
            }
            else
            {
                MessageBox.Show("Select a driver from the list.");
            }
        }
    }
}
