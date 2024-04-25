using Microsoft.Win32;
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
using System.Windows.Shapes;
using testMvvm.ViewModels;
using testMvvm.View;
using testMvvm.Model;
using System.Data;

namespace testMvvm.View.Windows
{
    
    public partial class AddWindow : Window
    {
        
        private string imagePath = string.Empty;

        private Gareg cars;
        private Office drivers;
        public AddWindow(Gareg cars, Office drivers)
        {
             InitializeComponent();
             this.cars = cars;
             this.drivers = drivers;
             GetDrivers();




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Car car = new Car();
            car.name = TNameCar.Text;
            car.number = TNumberCar.Text;
            car.dataTO = ConvertDate(DataTO.ToString()).ToString("dd.MM.yyyy");
            car.dataTOnext = ConvertDate(DataTO.ToString()).AddYears(int.Parse(DataNext.Text)).ToString("dd.MM.yyyy");

            car.dataCT = ConvertDate(DataCT.ToString()).ToString("dd.MM.yyyy");
            car.dataCTnext = ConvertDate(DataCT.ToString()).AddYears(int.Parse(DataNext.Text)).ToString("dd.MM.yyyy"); ;
            car.driver = ComboBox1.Text;
            



            string projectDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string imageFileName = System.IO.Path.GetFileName(imagePath);
            string destinationPath = System.IO.Path.Combine(projectDirectory, imageFileName);
            System.IO.File.Copy(imagePath, destinationPath, true);
            car.ImagePathCar = destinationPath; 

           
            cars.Add(car);

            this.Close();
        }

        private DateTime ConvertDate(string date)
        {
            DateTime curDate = DateTime.Parse(date);

            return curDate.Date;
        }

        
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";


            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;

            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void GetDrivers()
        {
            foreach(Driver d in drivers.GetAll())
            {
                ComboBox1.Items.Add(d);
            }
        }
    }
}
