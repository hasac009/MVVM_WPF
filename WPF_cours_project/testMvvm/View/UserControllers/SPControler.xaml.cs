using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
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

namespace testMvvm.View.UserControllers
{
    
    public partial class SPControler : UserControl
    {
        Storage sp;
        public SPControler(Storage sp)
        {
            InitializeComponent();
            MyDG.ItemsSource = sp.GetAll();
            this.sp = sp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MyDG.SelectedItems.Count > 0)
            {
                SparePart selectedSp = MyDG.SelectedItem as SparePart;
                sp.del(selectedSp);
                MyDG.ItemsSource = sp.GetAll();
            }
            else
            {
                MessageBox.Show("Select a part from the list.");
            }
        }
    }
}
