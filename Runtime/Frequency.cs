using Unity.Mathematics;

namespace AceLand.Measurements
{
    public readonly struct Frequency
    {
        // Internal storage in Hertz
        internal Frequency(float hertz) => _hertz = hertz;
        private readonly float _hertz;

        public override string ToString() => $"{_hertz} Hz";

        // --- Standard SI ---
        public float Hertz => _hertz;

        // --- Metric Prefixes ---
        public float Kilohertz => _hertz / 1_000f;       // Audio / Radio
        public float Megahertz => _hertz / 1_000_000f;   // FM Radio / CPU
        public float Gigahertz => _hertz / 1_000_000_000f; // WiFi / CPU
        public float Terahertz => _hertz / 1_000_000_000_000f; // Light / Infrared

        // --- Mechanical ---
        // 1 Hz = 60 RPM (Revolutions Per Minute)
        public float RPM => _hertz * 60f;

        // --- Physics / Engineering (Angular Frequency) ---
        // Used in electronics and rotational physics
        // Radians/sec = 2 * PI * Hz
        public float RadiansPerSecond => _hertz * 2f * math.PI;

        public static Frequency operator +(Frequency a, Frequency b) => new(a._hertz + b._hertz);
        public static Frequency operator -(Frequency a, Frequency b) => new(a._hertz - b._hertz);
    }
}