using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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
   
    public partial class AddSpOnCar : Window
    {
        Car car;
        Storage storage;
        public AddSpOnCar(Car car, Storage storage)
        {
            InitializeComponent();
            ListBoxSP.ItemsSource = storage.GetAll();
            this.car = car;
            this.storage = storage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countBox.Text))
            {
                MessageBox.Show("Enter the count.");
                return;
            }
            int countParts = int.Parse(countBox.Text);
            
            SparePart sp = (SparePart)ListBoxSP.SelectedItem;
            if (countParts <= 0)
            {
                LableEror.Content = "The value cannot be negative or zero.";
            }
            else if(countParts <= sp.count)
            {
                storage.InsertSparePartOnCar(sp.Id, car.Id, countParts);
                sp.count -= countParts;
                storage.UpdateSparePart(sp);
                if(sp.count == 0)
                {
                    storage.del(sp);
                }
                
                this.Close();
            }
            else
            {
                LableEror.Content = "Not enough parts in stock.";
            }
            
           
        }
        
        private void ListBoxSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxSP.SelectedItem != null)
            {
                
                SparePart selectedSparePart = ListBoxSP.SelectedItem as SparePart;

               
                string partType = selectedSparePart.type_sp;


                LableType.Content = partType;
            }
            else
            {

                LableType.Content = "";
            }
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
    }
}
