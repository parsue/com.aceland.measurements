namespace AceLand.Measurements
{
    public static class VolumeExtensions
    {
        // SI
        public static Volume CubicMeters(this double value) => new(value);
        public static Volume CubicCentimeters(this double value) => new(value / 1_000_000.0);
        public static Volume Liters(this double value) => new(value / 1_000.0);
        public static Volume Milliliters(this double value) => new(value / 1_000_000.0);

        // Imperial / US
        // Note: We calculate the multiplier based on the constants defined in the struct logic
        // 1 inch = 0.0254m -> 1 cubic inch = 0.0254^3 m^3
        public static Volume CubicInches(this double value) => new(value * 0.000016387064); 
        public static Volume CubicFeet(this double value) => new(value * 0.028316846592);
        
        // 1 Gallon = 231 cubic inches
        public static Volume USGallons(this double value) => new(value * 231.0 * 0.000016387064);
        public static Volume USFluidOunces(this double value) => new((value / 128.0) * 231.0 * 0.000016387064);
    }
}