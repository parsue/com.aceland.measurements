namespace AceLand.Measurements
{
    public static class PressureExtensions
    {
        // Standard
        public static Pressure Pascals(this float value) => new(value);
        public static Pressure Kilopascals(this float value) => new(value * 1_000f);
        public static Pressure Bars(this float value) => new(value * 100_000f);
        public static Pressure PSI(this float value) => new(value * 6_894.757293168f);
        public static Pressure Atmospheres(this float value) => new(value * 101_325f);

        // Water / Hydraulic
        public static Pressure MetersOfWater(this float value) => new(value * 9_806.65f);
        public static Pressure FeetOfHead(this float value) => new(value * 2_989.0669f);
    }
}