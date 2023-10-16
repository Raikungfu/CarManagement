using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{
    public class Car
    {
        public string? CarImg { get; set; }
        public int CarID {  get; set; }
        public string CarName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string CarDescription { get; set; }
        public int ReleaseYear { get; set; }
    }
}
