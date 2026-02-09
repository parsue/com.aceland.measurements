namespace AceLand.Measurements
{
    public static class TemperatureExtensions
    {
        public static Temperature Celsius(this double value) => new(value);
        
        public static Temperature Fahrenheit(this double value) 
            => new((value - 32.0) * 5.0 / 9.0);
            
        public static Temperature Kelvin(this double value) 
            => new(value - 273.15);
    }
}