namespace AceLand.Measurements
{
    public static class AreaExtensions
    {
        // Area (float)
        public static Area SquareKilometers(this float value) => new(value * 1_000_000f);
        public static Area SquareMeters(this float value) => new(value);
        public static Area SquareCentimeters(this float value) => new(value / 10_000f);
        public static Area SquareMillimeters(this float value) => new(value / 1_000_000f);
        public static Area SquareMicrometers(this float value) => new(value / 1_000_000_000_000f);
        public static Area SquareNanometers(this float value) => new(value / 1_000_000_000_000_000_000f);

        public static Area SquareInches(this float value) => new(value * 0.00064516f);      // 1 in² = 0.00064516 m²
        public static Area SquareFeet(this float value) => new(value * 0.09290304f);       // 1 ft² = 0.09290304 m²
        public static Area SquareYards(this float value) => new(value * 0.83612736f);      // 1 yd² = 0.83612736 m²
        public static Area SquareMiles(this float value) => new(value * 2_589_988.110336f);// 1 mi² = 2,589,988.110336 m²
        public static Area SquareNauticalMiles(this float value) => new(value * 3_429_904f); // 1 nmi² = (1852 m)²

        public static Area Acres(this float value) => new(value * 4_046.8564224f);         // 1 acre = 4046.8564224 m²
        public static Area Ares(this float value) => new(value * 100f);                  // 1 are = 100 m²
        public static Area Hectares(this float value) => new(value * 10_000f);           // 1 ha = 10,000 m²
    }
}