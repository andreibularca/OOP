using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class Vegetable
    {
        public abstract string GetVegetableName();

        public abstract bool DoINeedIrrigationNow(float landTemperature, float airHumidity, float landHumidity);

        public void IrrigateMe()
        {
            //here we call irrigation device to give water
            Console.WriteLine("Irrigating...");
        }
    }
}
