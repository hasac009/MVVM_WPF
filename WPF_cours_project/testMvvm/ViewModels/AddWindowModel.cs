using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using testMvvm.ViewModels.Base;

namespace testMvvm.ViewModels
{
    internal class AddWindowModel : ViewModel
    {
        private string imagePath = string.Empty;

        private DbTools db;
        AddWindowModel(DbTools _db) {

            db = _db;

        }




    }
}
