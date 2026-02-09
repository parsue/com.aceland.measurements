namespace AceLand.Measurements
{
    public static class PressureExtensions
    {
        // Standard
        public static Pressure Pascals(this double value) => new(value);
        public static Pressure Kilopascals(this double value) => new(value * 1_000.0);
        public static Pressure Bars(this double value) => new(value * 100_000.0);
        public static Pressure PSI(this double value) => new(value * 6_894.757293168);
        public static Pressure Atmospheres(this double value) => new(value * 101_325.0);

        // Water / Hydraulic
        public static Pressure MetersOfWater(this double value) => new(value * 9_806.65);
        public static Pressure FeetOfHead(this double value) => new(value * 2_989.0669);
    }
}