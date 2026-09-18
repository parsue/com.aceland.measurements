using AceLand.Measurements.Calculators;

namespace AceLand.Measurements
{
    public static class LengthExtensions
    {
        // Length (float)
        public static Length Kilometers(this float value) => new(value * 1_000f);
        public static Length Meters(this float value) => new(value);
        public static Length Centimeters(this float value) => new(value / 100f);
        public static Length Millimeters(this float value) => new(value / 1_000f);
        public static Length Micrometers(this float value) => new(value / 1_000_000f);
        public static Length Nanometers(this float value) => new(value / 1_000_000_000f);

        public static Length Inches(this float value) => new(value * 0.0254f);
        public static Length Feet(this float value) => new(value * 0.3048f);
        public static Length Yards(this float value) => new(value * 0.9144f);
        public static Length Miles(this float value) => new(value * 1_609.344f);
        public static Length NauticalMiles(this float value) => new(value * 1_852f);

        // Length (int)
        public static Length Kilometers(this int value) => new(value * 1_000f);
        public static Length Meters(this int value) => new(value);
        public static Length Centimeters(this int value) => new(value / 100f);
        public static Length Millimeters(this int value) => new(value / 1_000f);
        public static Length Micrometers(this int value) => new(value / 1_000_000f);
        public static Length Nanometers(this int value) => new(value / 1_000_000_000f);

        public static Length Inches(this int value) => new(value * 0.0254f);
        public static Length Feet(this int value) => new(value * 0.3048f);
        public static Length Yards(this int value) => new(value * 0.9144f);
        public static Length Miles(this int value) => new(value * 1_609.344f);
        public static Length NauticalMiles(this int value) => new(value * 1_852f);

        // Hydrostatics Calculations
        public static Pressure FromFreshWaterDepth(this Length freshWaterDepth) =>
            Hydrostatics.FromFreshWaterDepth(freshWaterDepth.Meters);
        public static Pressure FromSaltWaterDepth(this Length saltWaterDepth) =>
            Hydrostatics.FromSaltWaterDepth(saltWaterDepth.Meters);
    }
}