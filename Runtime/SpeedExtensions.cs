namespace AceLand.Measurements
{
    public static class SpeedExtensions
    {
        public static Speed MetersPerSecond(this double value) => new(value);
        public static Speed KilometersPerHour(this double value) => new(value / 3.6);
        public static Speed MilesPerHour(this double value) => new(value * 0.44704);
        public static Speed Knots(this double value) => new(value * (1.852 / 3.6));
        public static Speed Mach(this double value) => new(value * 340.29);
    }
}