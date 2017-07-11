namespace OOP.Abstraction
{
    public class Cabbage : Vegetable
    {
        public override bool DoINeedIrrigationNow(float landTemperature, float airHumidity, float landHumidity)
        {
            if (landTemperature > 36 && airHumidity < 55 && landHumidity < 65)
            {
                return true;
            }
            return false;
        }

        public override string GetVegetableName()
        {
            return "Cabbage";
        }
    }
}
