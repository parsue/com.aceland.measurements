namespace AceLand.Measurements
{
    public readonly struct Speed
    {
        // Internal storage in Meters Per Second
        internal Speed(float metersPerSecond) => this._metersPerSecond = metersPerSecond;
        private readonly float _metersPerSecond;

        public override string ToString() => $"{_metersPerSecond} m/s";

        // Base SI
        public float MetersPerSecond => _metersPerSecond;

        // Metric
        public float KilometersPerHour => _metersPerSecond * 3.6f; // Exact: 3600s / 1000m

        // Imperial / US
        // 1 mph = 1.609344 km/h = 0.44704 m/s (exact)
        private const float MPS_PER_MPH = 0.44704f;
        public float MilesPerHour => _metersPerSecond / MPS_PER_MPH;
        
        public float FeetPerSecond => _metersPerSecond * 3.280839895f;

        // Nautical
        // 1 knot = 1.852 km/h (exact) = 0.514444... m/s
        private const float MPS_PER_KNOT = 1.852f / 3.6f;
        public float Knots => _metersPerSecond / MPS_PER_KNOT;

        // Mach (Approximate standard at sea level, 15°C)
        // Note: Real Mach depends on temperature/pressure. This is a standard constant.
        private const float MPS_PER_MACH = 340.29f; 
        public float Mach => _metersPerSecond / MPS_PER_MACH;

        public static Speed operator +(Speed a, Speed b) => new(a._metersPerSecond + b._metersPerSecond);
        public static Speed operator -(Speed a, Speed b) => new(a._metersPerSecond - b._metersPerSecond);
    }
}