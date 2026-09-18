namespace AceLand.Measurements
{
    public static class TemperatureExtensions
    {
        public static Temperature Celsius(this float value) => new(value);
        
        public static Temperature Fahrenheit(this float value) 
            => new((value - 32f) * 5f / 9f);
            
        public static Temperature Kelvin(this float value) 
            => new(value - 273.15f);
    }
}