namespace AceLand.Measurements
{
    public readonly struct Temperature
    {
        // Internal storage in Celsius (Most common middle-ground)
        internal Temperature(float celsius) => this._celsius = celsius;
        private readonly float _celsius;

        public override string ToString() => $"{_celsius} °C";

        // Scales
        public float Celsius => _celsius;
        public float Fahrenheit => (_celsius * 9f / 5f) + 32f;
        public float Kelvin => _celsius + 273.15f;
    }
}