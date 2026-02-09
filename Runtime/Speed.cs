namespace AceLand.Measurements
{
    public readonly struct Speed
    {
        // Internal storage in Meters Per Second
        internal Speed(double metersPerSecond) => this.metersPerSecond = metersPerSecond;
        private readonly double metersPerSecond;

        public override string ToString() => $"{metersPerSecond} m/s";

        // Base SI
        public double MetersPerSecond => metersPerSecond;

        // Metric
        public double KilometersPerHour => metersPerSecond * 3.6; // Exact: 3600s / 1000m

        // Imperial / US
        // 1 mph = 1.609344 km/h = 0.44704 m/s (exact)
        private const double MPS_PER_MPH = 0.44704;
        public double MilesPerHour => metersPerSecond / MPS_PER_MPH;
        
        public double FeetPerSecond => metersPerSecond * 3.280839895;

        // Nautical
        // 1 knot = 1.852 km/h (exact) = 0.514444... m/s
        private const double MPS_PER_KNOT = 1.852 / 3.6;
        public double Knots => metersPerSecond / MPS_PER_KNOT;

        // Mach (Approximate standard at sea level, 15°C)
        // Note: Real Mach depends on temperature/pressure. This is a standard constant.
        private const double MPS_PER_MACH = 340.29; 
        public double Mach => metersPerSecond / MPS_PER_MACH;

        public static Speed operator +(Speed a, Speed b) => new(a.metersPerSecond + b.metersPerSecond);
        public static Speed operator -(Speed a, Speed b) => new(a.metersPerSecond - b.metersPerSecond);
    }
}