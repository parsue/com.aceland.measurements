namespace AceLand.Measurements
{
    public readonly struct Volume
    {
        // Internal storage in Cubic Meters
        internal Volume(float cubicMeters) => this._cubicMeters = cubicMeters;
        private readonly float _cubicMeters;

        public override string ToString() => $"{_cubicMeters} m³";

        // --- SI Cubic Units ---
        public float CubicMeters => _cubicMeters;
        public float CubicKilometers => _cubicMeters / 1_000_000_000f;
        public float CubicCentimeters => _cubicMeters * 1_000_000f; // Same as Milliliter
        public float CubicMillimeters => _cubicMeters * 1_000_000_000f;

        // --- SI Liquid Units ---
        // 1 Liter = 0.001 cubic meters (1 cubic decimeter)
        public float Liters => _cubicMeters * 1_000f;
        public float Milliliters => _cubicMeters * 1_000_000f;

        // --- Imperial / US Cubic Units ---
        // Based on 1 inch = 0.0254 m
        private const float METER_PER_INCH = 0.0254f;
        private const float METER_PER_FOOT = 0.3048f;
        private const float METER_PER_YARD = 0.9144f;

        private const float CUBIC_METER_PER_CUBIC_INCH = METER_PER_INCH * METER_PER_INCH * METER_PER_INCH; // ~0.000016387
        private const float CUBIC_METER_PER_CUBIC_FOOT = METER_PER_FOOT * METER_PER_FOOT * METER_PER_FOOT; // ~0.0283168
        private const float CUBIC_METER_PER_CUBIC_YARD = METER_PER_YARD * METER_PER_YARD * METER_PER_YARD; // ~0.76455

        public float CubicInches => _cubicMeters / CUBIC_METER_PER_CUBIC_INCH;
        public float CubicFeet => _cubicMeters / CUBIC_METER_PER_CUBIC_FOOT;
        public float CubicYards => _cubicMeters / CUBIC_METER_PER_CUBIC_YARD;

        // --- US Liquid Units ---
        // 1 US Gallon = 231 cubic inches (exact definition)
        private const float CUBIC_INCHES_PER_GALLON = 231f;
        private const float CUBIC_METER_PER_GALLON = CUBIC_INCHES_PER_GALLON * CUBIC_METER_PER_CUBIC_INCH;

        public float USGallons => _cubicMeters / CUBIC_METER_PER_GALLON;
        
        // 1 Gallon = 4 Quarts = 8 Pints = 128 Fluid Ounces
        public float USQuarts => USGallons * 4f;
        public float USPints => USGallons * 8f;
        public float USFluidOunces => USGallons * 128f;

        // --- Math Operators ---
        public static Volume operator +(Volume a, Volume b) => new(a._cubicMeters + b._cubicMeters);
        public static Volume operator -(Volume a, Volume b) => new(a._cubicMeters - b._cubicMeters);
    }
}