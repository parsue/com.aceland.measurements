namespace AceLand.Measurements
{
    public static class AreaExtensions
    {
        // Area (double)
        public static Area SquareKilometers(this double value) => new(value * 1_000_000.0);
        public static Area SquareMeters(this double value) => new(value);
        public static Area SquareCentimeters(this double value) => new(value / 10_000.0);
        public static Area SquareMillimeters(this double value) => new(value / 1_000_000.0);
        public static Area SquareMicrometers(this double value) => new(value / 1_000_000_000_000.0);
        public static Area SquareNanometers(this double value) => new(value / 1_000_000_000_000_000_000.0);

        public static Area SquareInches(this double value) => new(value * 0.00064516);      // 1 in² = 0.00064516 m²
        public static Area SquareFeet(this double value) => new(value * 0.09290304);       // 1 ft² = 0.09290304 m²
        public static Area SquareYards(this double value) => new(value * 0.83612736);      // 1 yd² = 0.83612736 m²
        public static Area SquareMiles(this double value) => new(value * 2_589_988.110336);// 1 mi² = 2,589,988.110336 m²
        public static Area SquareNauticalMiles(this double value) => new(value * 3_429_904.0); // 1 nmi² = (1852 m)²

        public static Area Acres(this double value) => new(value * 4_046.8564224);         // 1 acre = 4046.8564224 m²
        public static Area Ares(this double value) => new(value * 100.0);                  // 1 are = 100 m²
        public static Area Hectares(this double value) => new(value * 10_000.0);           // 1 ha = 10,000 m²
    }
}