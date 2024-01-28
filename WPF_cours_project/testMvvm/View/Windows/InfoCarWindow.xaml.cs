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

namespace testMvvm.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для InfoCarWindow.xaml
    /// </summary>
    public partial class InfoCarWindow : Window
    {
        private Car car;
        public InfoCarWindow(Car carInput)
        {
            InitializeComponent();
            car = carInput;
            Display(car.ImagePathCar);
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
    }
}
