using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMvvm.Model
{
    public  class Car
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string ImagePathCar { get; set; }
        public string? driver { get; set; }
        public string? dataTO { get; set; }
        public string? dataTOnext { get; set; }
        public string? dataCT { get; set; }
        public string? dataCTnext { get; set; }

    }
}
