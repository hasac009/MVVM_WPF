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
using testMvvm.ViewModels;

namespace testMvvm.View.Windows
{
   
    public partial class AddWindowStorage : Window
    {
        private Storage SparePart;
        public AddWindowStorage(Storage SparePart)
        {
            InitializeComponent();
            this.SparePart = SparePart;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SparePart sp = new SparePart();
            if (string.IsNullOrWhiteSpace(NameSp.Text))
            {
                MessageBox.Show("Enter the name.");
                return;
            }
            sp.name = NameSp.Text;

           
            if (!int.TryParse(CountSP.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer value for the count field.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }
            sp.count = count;

            ComboBoxItem selectedItem = ComboBox1.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                string selectedContent = selectedItem.Content.ToString();

                
                if (string.IsNullOrWhiteSpace(selectedContent))
                {
                    MessageBox.Show("Please select a type for the SP.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return; 
                }
                sp.type_sp = selectedContent;
            }
            else
            {
               
                MessageBox.Show("Please select a type for the SP.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }
            SparePart.Add(sp);
            SparePart.GetAll();
            this.Close();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
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
