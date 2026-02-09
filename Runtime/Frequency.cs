using System;

namespace AceLand.Measurements
{
    public readonly struct Frequency
    {
        // Internal storage in Hertz
        internal Frequency(double hertz) => this.hertz = hertz;
        private readonly double hertz;

        public override string ToString() => $"{hertz} Hz";

        // --- Standard SI ---
        public double Hertz => hertz;

        // --- Metric Prefixes ---
        public double Kilohertz => hertz / 1_000.0;       // Audio / Radio
        public double Megahertz => hertz / 1_000_000.0;   // FM Radio / CPU
        public double Gigahertz => hertz / 1_000_000_000.0; // WiFi / CPU
        public double Terahertz => hertz / 1_000_000_000_000.0; // Light / Infrared

        // --- Mechanical ---
        // 1 Hz = 60 RPM (Revolutions Per Minute)
        public double RPM => hertz * 60.0;

        // --- Physics / Engineering (Angular Frequency) ---
        // Used in electronics and rotational physics
        // Radians/sec = 2 * PI * Hz
        public double RadiansPerSecond => hertz * 2.0 * Math.PI;

        public static Frequency operator +(Frequency a, Frequency b) => new(a.hertz + b.hertz);
        public static Frequency operator -(Frequency a, Frequency b) => new(a.hertz - b.hertz);
    }
}