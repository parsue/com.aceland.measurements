using Unity.Mathematics;

namespace AceLand.Measurements
{
    public static class FrequencyExtensions
    {
        public static Frequency Hertz(this float value) => new(value);
        public static Frequency Kilohertz(this float value) => new(value * 1_000f);
        public static Frequency Megahertz(this float value) => new(value * 1_000_000f);
        public static Frequency Gigahertz(this float value) => new(value * 1_000_000_000f);
        public static Frequency Terahertz(this float value) => new(value * 1_000_000_000_000f);

        public static Frequency RPM(this float value) => new(value / 60f);
        
        public static Frequency RadiansPerSecond(this float value) => new(value / (2f * math.PI));
    }
}