namespace AceLand.Measurements
{
    public readonly struct Area
    {
        // Internal storage in square meters
        internal Area(float squareMeters) => _squareMeters = squareMeters;
        private readonly float _squareMeters;

        public override string ToString() => $"{_squareMeters} m²";

        // Base SI
        public float SquareMeters => _squareMeters;

        // SI multiples/submultiples
        public float SquareKilometers => _squareMeters / 1_000_000f; // 1 km² = 1,000,000 m²
        public float SquareCentimeters => _squareMeters * 10_000f; // 1 m² = 10,000 cm²
        public float SquareMillimeters => _squareMeters * 1_000_000f; // 1 m² = 1,000,000 mm²
        public float SquareMicrometers => _squareMeters * 1_000_000_000_000f; // 1 m² = 10^12 μm²
        public float SquareNanometers => _squareMeters * 1_000_000_000_000_000_000f; // 1 m² = 10^18 nm²

        // Hectare / Are
        public float Hectares => _squareMeters / 10_000f; // 1 ha = 10,000 m²
        public float Ares => _squareMeters / 100f; // 1 a = 100 m²

        // Imperial / US customary (based on exact inch definition)
        private const float METER_PER_INCH = 0.0254f;              // exact
        private const float METER_PER_FOOT = 0.3048f;              // 12 inches
        private const float METER_PER_YARD = 0.9144f;              // 3 feet
        private const float METER_PER_MILE = 1_609.344f;            // 1760 yards
        private const float SQUARE_METER_PER_SQUARE_INCH = METER_PER_INCH * METER_PER_INCH;   // 0.00064516 m²
        private const float SQUARE_METER_PER_SQUARE_FOOT = METER_PER_FOOT * METER_PER_FOOT;   // 0.09290304 m²
        private const float SQUARE_METER_PER_SQUARE_YARD = METER_PER_YARD * METER_PER_YARD;   // 0.83612736 m²
        private const float SQUARE_METER_PER_SQUARE_MILE = METER_PER_MILE * METER_PER_MILE;   // 2,589,988.110336 m²
        public float SquareInches => _squareMeters / SQUARE_METER_PER_SQUARE_INCH;
        public float SquareFeet => _squareMeters / SQUARE_METER_PER_SQUARE_FOOT;
        public float SquareYards => _squareMeters / SQUARE_METER_PER_SQUARE_YARD;
        public float SquareMiles => _squareMeters / SQUARE_METER_PER_SQUARE_MILE;

        // Nautical square miles
        private const float METER_PER_NAUTICAL_MILE = 1_852f;      // exact
        private const float SQUARE_METER_PER_SQUARE_NAUTICAL_MILE = METER_PER_NAUTICAL_MILE * METER_PER_NAUTICAL_MILE; // 3,429,904 m²

        public float SquareNauticalMiles => _squareMeters / SQUARE_METER_PER_SQUARE_NAUTICAL_MILE;

        // Acres
        // 1 international acre = 43,560 ft² = 4046.8564224 m² (exact from inch definition)
        private const float SQUARE_METER_PER_ACRE = 4_046.8564224f;
        public float Acres => _squareMeters / SQUARE_METER_PER_ACRE;

        // Aliases (spelling variants)
        public float SquareMetres => SquareMeters;
        public float SquareKilometres => SquareKilometers;
        
        public static Area operator +(Area a, Area b) => new(a._squareMeters + b._squareMeters);
        public static Area operator -(Area a, Area b) => new(a._squareMeters - b._squareMeters);
        
        // Area * Length = Volume
        public static Volume operator *(Area area, Length length) => 
            new Volume(area._squareMeters * length.Meters);
    }
}