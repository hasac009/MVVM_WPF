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
using testMvvm.ViewModels;

namespace testMvvm.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ListCarController.xaml
    /// </summary>
    
    public partial class ListCarController : UserControl
    {
        private Button btn;

        public ListCarController(Gareg g)
        {
            InitializeComponent();

            btn = new Button();
            CarsController.ItemsSource = g.GetAll();
            Console.WriteLine();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            var viewModel = DataContext as MainWindowModel;
            
            viewModel.delCarCommand.Execute(btn);
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            btn = sender as Button;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as MainWindowModel;

            viewModel.upgradeCarCommand.Execute(btn);
        }
    }
}
