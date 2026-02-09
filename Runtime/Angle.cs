using System;

namespace AceLand.Measurements
{
    public readonly struct Angle
    {
        // Internal storage in Degrees
        internal Angle(double degrees) => this.degrees = degrees;
        private readonly double degrees;

        public override string ToString() => $"{degrees}°";

        public double Degrees => degrees;

        // Radians
        // rad = deg * (PI / 180)
        public double Radians => degrees * (Math.PI / 180.0);

        // Gradians
        // 90 degrees = 100 gradians
        public double Gradians => degrees * (10.0 / 9.0);

        public static Angle operator +(Angle a, Angle b) => new(a.degrees + b.degrees);
        public static Angle operator -(Angle a, Angle b) => new(a.degrees - b.degrees);
    }
}