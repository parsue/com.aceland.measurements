namespace AceLand.Measurements
{
    public static class VolumeExtensions
    {
        // SI
        public static Volume CubicMeters(this float value) => new(value);
        public static Volume CubicCentimeters(this float value) => new(value / 1_000_000f);
        public static Volume Liters(this float value) => new(value / 1_000f);
        public static Volume Milliliters(this float value) => new(value / 1_000_000f);

        // Imperial / US
        // Note: We calculate the multiplier based on the constants defined in the struct logic
        // 1 inch = 0.0254m -> 1 cubic inch = 0.0254^3 m^3
        public static Volume CubicInches(this float value) => new(value * 0.000016387064f); 
        public static Volume CubicFeet(this float value) => new(value * 0.028316846592f);
        
        // 1 Gallon = 231 cubic inches
        public static Volume USGallons(this float value) => new(value * 231f * 0.000016387064f);
        public static Volume USFluidOunces(this float value) => new((value / 128f) * 231f * 0.000016387064f);
    }
}