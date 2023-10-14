namespace BAGG
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrentheit(double celsius)
        {
            double fahrentheit = (celsius * 9 / 5) + 32;
            return fahrentheit;
        }

        public double FahrentheitToCelsius(double fahrentheit)
        {
            double celsius = (fahrentheit - 32) * 5 / 9;
            return celsius;
        }
    }
}