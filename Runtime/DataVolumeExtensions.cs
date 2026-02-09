namespace AceLand.Measurements
{
    public static class DataVolumeExtensions
    {
        // Base
        public static DataVolume Bytes(this double value) => new(value);
        public static DataVolume Bytes(this int value) => new(value);
        public static DataVolume Bytes(this long value) => new(value);

        // Bits (Networking)
        public static DataVolume Bits(this double value) => new(value / 8.0);
        public static DataVolume Kilobits(this double value) => new((value * 1_000.0) / 8.0);
        public static DataVolume Megabits(this double value) => new((value * 1_000_000.0) / 8.0);
        public static DataVolume Gigabits(this double value) => new((value * 1_000_000_000.0) / 8.0);

        // Decimal / SI (1 KB = 1000 B)
        public static DataVolume Kilobytes(this double value) => new(value * 1_000.0);
        public static DataVolume Megabytes(this double value) => new(value * 1_000_000.0);
        public static DataVolume Gigabytes(this double value) => new(value * 1_000_000_000.0);
        public static DataVolume Terabytes(this double value) => new(value * 1_000_000_000_000.0);

        // Binary / IEC (1 KiB = 1024 B)
        public static DataVolume Kibibytes(this double value) => new(value * 1024.0);
        public static DataVolume Mebibytes(this double value) => new(value * 1_048_576.0);
        public static DataVolume Gibibytes(this double value) => new(value * 1_073_741_824.0);
        public static DataVolume Tebibytes(this double value) => new(value * 1_099_511_627_776.0);
    }
}