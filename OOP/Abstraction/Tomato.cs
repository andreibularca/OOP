using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public class Tomato : Vegetable
    {
        public override bool DoINeedIrrigationNow(float landTemperature, float airHumidity, float landHumidity)
        {
            if(landTemperature > 30 && airHumidity < 50 && landHumidity < 45)
            {
                return true;
            }
            return false;
        }

        public override string GetVegetableName()
        {
            return "Tomato";
        }
    }
}
