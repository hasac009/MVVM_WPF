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

        public static void Clear()
        {
            Cars.Clear();
        }
    }
}
