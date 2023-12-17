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

namespace testMvvm.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        
        private string imagePath = string.Empty;

        private DbTools db;
        public AddWindow(DbTools _db)
        {
            InitializeComponent();
            db = _db;
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Car car = new Car();
            car.name = TNameCar.Text;
            car.number = TNumberCar.Text;

            string projectDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string imageFileName = System.IO.Path.GetFileName(imagePath);
            string destinationPath = System.IO.Path.Combine(projectDirectory, imageFileName);
            System.IO.File.Copy(imagePath, destinationPath, true);
            car.ImagePathCar = destinationPath; 

            DataStorag.Cars.Add(car);
            db.InsertCarIntoTable(car);

            this.Close();
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
    }
}
