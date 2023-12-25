using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using testMvvm.Model;

namespace testMvvm.View
{
    public static class DataStorag
    {
        public static ObservableCollection<Car> Cars { get; } = new ObservableCollection<Car>();
        public static ObservableCollection<Driver> Drivers { get; } = new ObservableCollection<Driver>();
        public static ObservableCollection<SparePart> SpareParts { get; } = new ObservableCollection<SparePart>();

        public static void Clear()
        {
            Cars.Clear();
        }

        public static void  ClearDrivers()
        {
            Drivers.Clear();
        }

        public static void ClearSP()
        {
            SpareParts.Clear();
        }
    }
}
