namespace AceLand.Measurements
{
    public readonly struct Temperature
    {
        // Internal storage in Celsius (Most common middle-ground)
        internal Temperature(double celsius) => this.celsius = celsius;
        private readonly double celsius;

        public override string ToString() => $"{celsius} °C";

        // Scales
        public double Celsius => celsius;
        public double Fahrenheit => (celsius * 9.0 / 5.0) + 32.0;
        public double Kelvin => celsius + 273.15;
    }
}