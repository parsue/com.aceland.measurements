using Unity.Mathematics;

namespace AceLand.Measurements
{
    public static class AngleExtensions
    {
        public static Angle Degrees(this float value) => new(value);
        public static Angle Radians(this float value) => new(value * (180f / math.PI));
        public static Angle Gradians(this float value) => new(value * 0.9f);
    }
}