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
            int countParts = int.Parse(countBox.Text);
            
            SparePart sp = (SparePart)ListBoxSP.SelectedItem;
            if(countParts < sp.count)
            {
                storage.InsertSparePartOnCar(sp.Id, car.Id, countParts);
                sp.count -= countParts;
                storage.UpdateSparePart(sp);
                this.Close();
            }
            else
            {
                LableEror.Content = "Not enough parts in stock";
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
    }
}
