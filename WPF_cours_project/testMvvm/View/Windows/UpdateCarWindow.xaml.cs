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
    
    public partial class UpdateCarWindow : Window
    {
        private Car car;
        private Gareg gareg;
        private Office drivers;
        public UpdateCarWindow(Car car, Gareg gareg , Office drivers)
        {
            InitializeComponent();
            this.car = car;
            this.gareg = gareg;
            this.drivers = drivers;

            TNameCar.Text = car.name;
            TNumberCar.Text = car.number;
            DataTO.Text = car.dataTO;
            DataCT.Text = car.dataCT;
            GetDrivers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            car.name = TNameCar.Text;
            car.number = TNumberCar.Text;
            car.dataTO = ConvertDate(DataTO.ToString()).ToString("dd.MM.yyyy");
            car.dataTOnext = ConvertDate(DataTO.ToString()).AddYears(int.Parse(DataNext.Text)).ToString("dd.MM.yyyy");

            car.dataCT = ConvertDate(DataCT.ToString()).ToString("dd.MM.yyyy");
            car.dataCTnext = ConvertDate(DataCT.ToString()).AddYears(int.Parse(DataNext.Text)).ToString("dd.MM.yyyy"); ;
            car.driver = ComboBox1.Text;

        }

        private DateTime ConvertDate(string date)
        {
            DateTime curDate = DateTime.Parse(date);

            return curDate.Date;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void GetDrivers()
        {
            foreach (Driver d in drivers.GetAll())
            {
                ComboBox1.Items.Add(d);
            }
        }
    }
}
