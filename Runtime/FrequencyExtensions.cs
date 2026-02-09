using System;

namespace AceLand.Measurements
{
    public static class FrequencyExtensions
    {
        public static Frequency Hertz(this double value) => new(value);
        public static Frequency Kilohertz(this double value) => new(value * 1_000.0);
        public static Frequency Megahertz(this double value) => new(value * 1_000_000.0);
        public static Frequency Gigahertz(this double value) => new(value * 1_000_000_000.0);
        public static Frequency Terahertz(this double value) => new(value * 1_000_000_000_000.0);

        public static Frequency RPM(this double value) => new(value / 60.0);
        
        public static Frequency RadiansPerSecond(this double value) => new(value / (2.0 * Math.PI));
    }
}