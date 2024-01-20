using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using testMvvm.View.Windows;
using testMvvm.ViewModels;

namespace testMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для ListCarPage.xaml
    /// </summary>
    public partial class ListCarPage : Page
    {
        public ListCarPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string textButton = sender.ToString();
            
            


            Car car = DbTools.GetCar(ExtractCarNumber(textButton));
            
            InfoCarWindow infoCarWindow = new InfoCarWindow(car);
            infoCarWindow.Show();
        }


        static string ExtractCarNumber(string input)
        {

            string[] parts = input.Split(' ');
            string carNumber = parts[4];
            return carNumber;

        }
    }
}

