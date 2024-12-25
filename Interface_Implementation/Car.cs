using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    public class Car
    {
        public int CarId { get; set; }
        public string MyCar { get; set; }
        public string CarDescription { get; set; }
        public virtual CarAvailability CarAvailability { get; set; } // new SubClass check out Availability Cars

    }
}
