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
        private DbTools db;
        public AddWindowStorage(DbTools db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SparePart sp = new SparePart();
            sp.name = NameSp.Text;
            sp.count = int.Parse(CountSP.Text);
            db.InsertSpIntoTable(sp);
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
