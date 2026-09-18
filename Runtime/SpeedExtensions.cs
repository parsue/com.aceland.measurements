namespace AceLand.Measurements
{
    public static class SpeedExtensions
    {
        public static Speed MetersPerSecond(this float value) => new(value);
        public static Speed KilometersPerHour(this float value) => new(value / 3.6f);
        public static Speed MilesPerHour(this float value) => new(value * 0.44704f);
        public static Speed Knots(this float value) => new(value * (1.852f / 3.6f));
        public static Speed Mach(this float value) => new(value * 340.29f);
    }
}