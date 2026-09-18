using Unity.Mathematics;

namespace AceLand.Measurements
{
    public readonly struct Angle
    {
        // Internal storage in Degrees
        internal Angle(float degrees) => _degrees = degrees;
        private readonly float _degrees;

        public override string ToString() => $"{_degrees}°";

        public float Degrees => _degrees;

        // Radians
        // rad = deg * (PI / 180)
        public float Radians => _degrees * (math.PI / 180);

        // Gradians
        // 90 degrees = 100 gradians
        public float Gradians => _degrees * (10f / 9);

        public static Angle operator +(Angle a, Angle b) => new(a._degrees + b._degrees);
        public static Angle operator -(Angle a, Angle b) => new(a._degrees - b._degrees);
    }
}