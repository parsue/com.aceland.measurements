namespace AceLand.Measurements
{
    public static class DataVolumeExtensions
    {
        // Base
        public static DataVolume Bytes(this float value) => new(value);
        public static DataVolume Bytes(this int value) => new(value);
        public static DataVolume Bytes(this long value) => new(value);

        // Bits (Networking)
        public static DataVolume Bits(this float value) => new(value / 8f);
        public static DataVolume Kilobits(this float value) => new((value * 1_000f) / 8f);
        public static DataVolume Megabits(this float value) => new((value * 1_000_000f) / 8f);
        public static DataVolume Gigabits(this float value) => new((value * 1_000_000_000f) / 8f);

        // Decimal / SI (1 KB = 1000 B)
        public static DataVolume Kilobytes(this float value) => new(value * 1_000f);
        public static DataVolume Megabytes(this float value) => new(value * 1_000_000f);
        public static DataVolume Gigabytes(this float value) => new(value * 1_000_000_000f);
        public static DataVolume Terabytes(this float value) => new(value * 1_000_000_000_000f);

        // Binary / IEC (1 KiB = 1024 B)
        public static DataVolume Kibibytes(this float value) => new(value * 1024f);
        public static DataVolume Mebibytes(this float value) => new(value * 1_048_576f);
        public static DataVolume Gibibytes(this float value) => new(value * 1_073_741_824f);
        public static DataVolume Tebibytes(this float value) => new(value * 1_099_511_627_776f);
    }
}