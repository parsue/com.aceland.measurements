namespace AceLand.Measurements
{
    public readonly struct Volume
    {
        // Internal storage in Cubic Meters
        internal Volume(double cubicMeters) => this.cubicMeters = cubicMeters;
        private readonly double cubicMeters;

        public override string ToString() => $"{cubicMeters} m³";

        // --- SI Cubic Units ---
        public double CubicMeters => cubicMeters;
        public double CubicKilometers => cubicMeters / 1_000_000_000.0;
        public double CubicCentimeters => cubicMeters * 1_000_000.0; // Same as Milliliter
        public double CubicMillimeters => cubicMeters * 1_000_000_000.0;

        // --- SI Liquid Units ---
        // 1 Liter = 0.001 cubic meters (1 cubic decimeter)
        public double Liters => cubicMeters * 1_000.0;
        public double Milliliters => cubicMeters * 1_000_000.0;

        // --- Imperial / US Cubic Units ---
        // Based on 1 inch = 0.0254 m
        private const double METER_PER_INCH = 0.0254;
        private const double METER_PER_FOOT = 0.3048;
        private const double METER_PER_YARD = 0.9144;

        private const double CUBIC_METER_PER_CUBIC_INCH = METER_PER_INCH * METER_PER_INCH * METER_PER_INCH; // ~0.000016387
        private const double CUBIC_METER_PER_CUBIC_FOOT = METER_PER_FOOT * METER_PER_FOOT * METER_PER_FOOT; // ~0.0283168
        private const double CUBIC_METER_PER_CUBIC_YARD = METER_PER_YARD * METER_PER_YARD * METER_PER_YARD; // ~0.76455

        public double CubicInches => cubicMeters / CUBIC_METER_PER_CUBIC_INCH;
        public double CubicFeet => cubicMeters / CUBIC_METER_PER_CUBIC_FOOT;
        public double CubicYards => cubicMeters / CUBIC_METER_PER_CUBIC_YARD;

        // --- US Liquid Units ---
        // 1 US Gallon = 231 cubic inches (exact definition)
        private const double CUBIC_INCHES_PER_GALLON = 231.0;
        private const double CUBIC_METER_PER_GALLON = CUBIC_INCHES_PER_GALLON * CUBIC_METER_PER_CUBIC_INCH;

        public double USGallons => cubicMeters / CUBIC_METER_PER_GALLON;
        
        // 1 Gallon = 4 Quarts = 8 Pints = 128 Fluid Ounces
        public double USQuarts => USGallons * 4.0;
        public double USPints => USGallons * 8.0;
        public double USFluidOunces => USGallons * 128.0;

        // --- Math Operators ---
        public static Volume operator +(Volume a, Volume b) => new(a.cubicMeters + b.cubicMeters);
        public static Volume operator -(Volume a, Volume b) => new(a.cubicMeters - b.cubicMeters);
    }
}