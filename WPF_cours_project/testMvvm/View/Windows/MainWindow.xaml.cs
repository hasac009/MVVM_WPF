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
using testMvvm.View;
using testMvvm.View.Windows;
using testMvvm.ViewModels;

namespace testMvvm
{

    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window w in Application.Current.Windows)
            {
                if (w != this)
                    w.Close();
            }

            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
