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

using Excel = Microsoft.Office.Interop.Excel;

namespace testMvvm.View.UserControllers
{
   
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh =(Excel.Worksheet)exApp.ActiveSheet;
            for (int j = 0; j < MyDG.Columns.Count; j++)
            {
                wsh.Cells[1, j + 1] = MyDG.Columns[j].Header; 
            }
            for (int i = 0; i < MyDG.Items.Count; i++)
            {
                for (int j = 0; j < MyDG.Columns.Count; j++)
                {
                    
                    var item = MyDG.Items[i];
                    var column = MyDG.Columns[j];

                    var propertyName = column.SortMemberPath; 
                    var propertyInfo = item.GetType().GetProperty(propertyName); 

                    if (propertyInfo != null)
                    {
                        var cellValue = propertyInfo.GetValue(item, null); 
                        wsh.Cells[i + 2, j + 1] = cellValue?.ToString();
                    }
                }
            }
            exApp.Visible = true;

        }
    }
}
