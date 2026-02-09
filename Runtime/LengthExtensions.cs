using AceLand.Measurements.Calculators;

namespace AceLand.Measurements
{
    public static class LengthExtensions
    {
        // Length (double)
        public static Length Kilometers(this double value) => new(value * 1_000.0);
        public static Length Meters(this double value) => new(value);
        public static Length Centimeters(this double value) => new(value / 100.0);
        public static Length Millimeters(this double value) => new(value / 1_000.0);
        public static Length Micrometers(this double value) => new(value / 1_000_000.0);
        public static Length Nanometers(this double value) => new(value / 1_000_000_000.0);

        public static Length Inches(this double value) => new(value * 0.0254);
        public static Length Feet(this double value) => new(value * 0.3048);
        public static Length Yards(this double value) => new(value * 0.9144);
        public static Length Miles(this double value) => new(value * 1_609.344);
        public static Length NauticalMiles(this double value) => new(value * 1_852.0);

        // Length (int)
        public static Length Kilometers(this int value) => new(value * 1_000.0);
        public static Length Meters(this int value) => new(value);
        public static Length Centimeters(this int value) => new(value / 100.0);
        public static Length Millimeters(this int value) => new(value / 1_000.0);
        public static Length Micrometers(this int value) => new(value / 1_000_000.0);
        public static Length Nanometers(this int value) => new(value / 1_000_000_000.0);

        public static Length Inches(this int value) => new(value * 0.0254);
        public static Length Feet(this int value) => new(value * 0.3048);
        public static Length Yards(this int value) => new(value * 0.9144);
        public static Length Miles(this int value) => new(value * 1_609.344);
        public static Length NauticalMiles(this int value) => new(value * 1_852.0);

        // Hydrostatics Calculations
        public static Pressure FromFreshWaterDepth(this Length freshWaterDepth) =>
            Hydrostatics.FromFreshWaterDepth(freshWaterDepth.Meters);
        public static Pressure FromSaltWaterDepth(this Length saltWaterDepth) =>
            Hydrostatics.FromSaltWaterDepth(saltWaterDepth.Meters);
    }
}