using System;

namespace AceLand.Measurements
{
    public static class AngleExtensions
    {
        public static Angle Degrees(this double value) => new(value);
        public static Angle Radians(this double value) => new(value * (180.0 / Math.PI));
        public static Angle Gradians(this double value) => new(value * 0.9);
    }
}