﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMvvm.Model
{
    public class SparePart
    {
       public int Id { get; set; }
       public  string name {  get; set; }

       public int count { get; set; }

       public int car_id { get; set; }

       public string? type_sp {  get; set; }

        public bool status { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
