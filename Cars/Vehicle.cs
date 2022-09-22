using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car
    {
        public DateOnly model { get; set; }
        public string type { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public string wheels { get; set; }
        public string color { get; set; }

        public Car createcar(DateOnly year, string brand, string wheels, string color, string description, string type)
        {
            Car carPert = new Car();
            carPert.model = year;
            carPert.brand = brand;
            carPert.wheels = wheels;
            carPert.color = color;
            carPert.description = description;
            carPert.type = type;

            return carPert;
        

        }
        
    }
}