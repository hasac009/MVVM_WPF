using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMvvm.Model
{
   public class Driver
    {
        public int id {  get; set; }
        public string name { get; set; }

        public string phone { get; set; }

        public int car_id { get; set; }

        public bool status { get; set; }
        public override string ToString()
        {
            return name;
        }

    }
}
