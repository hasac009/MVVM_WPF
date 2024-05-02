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
using testMvvm.Model;
using testMvvm.ViewModels;

namespace testMvvm.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для InfoCarWindow.xaml
    /// </summary>
    public partial class InfoCarWindow : Window
    {
        private Car car;
        private Storage storage;
        
        public InfoCarWindow(Car carInput,Storage storage)
        {
            InitializeComponent();
            car = carInput;
            this.storage = storage;
            Display(car.ImagePathCar);
            MyDG.ItemsSource = storage.GetPartsByCarId(car.Id);
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Display(string imagePath)
        {
            try
            {
               
                ImageControl.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(imagePath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }


            LableDriverName.Content = car.driver;

            LableDateTO.Content = car.dataTO;
            LableDateNextTO.Content = car.dataTOnext;

            LableDateCT.Content = car.dataCT;
            LableDateNextCT.Content = car.dataCTnext;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddSpOnCar window = new AddSpOnCar(car, storage);
            window.Closed += (sender, args) =>
            {
                storage.GetAll();
                MyDG.ItemsSource = storage.GetPartsByCarId(car.Id);
            };
            window.Show();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
