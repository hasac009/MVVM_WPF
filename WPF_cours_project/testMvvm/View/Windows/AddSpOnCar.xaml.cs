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
using System.Windows.Shapes;
using testMvvm.Model;
using testMvvm.ViewModels;

namespace testMvvm.View.Windows
{
   
    public partial class AddSpOnCar : Window
    {
        Car car;
        public AddSpOnCar(Car car)
        {
            InitializeComponent();
            ListBoxSP.ItemsSource = DataStorag.SpareParts;
            this.car = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(DataStorag.SpareParts.Count);
            SparePart sp = (SparePart)ListBoxSP.SelectedItem;
            sp.car_id = car.Id;
            sp.count-=1;
            DbTools.UpdateSparePartInDatabase(sp);

            this.Close();





        }
    }
}
