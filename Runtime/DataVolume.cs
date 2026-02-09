namespace AceLand.Measurements
{
    public readonly struct DataVolume
    {
        // Internal storage in Bytes
        internal DataVolume(double bytes) => this.bytes = bytes;
        private readonly double bytes;

        public override string ToString() => $"{bytes} B";

        // Base Unit
        public double Bytes => bytes;
        
        // Bits (1 Byte = 8 Bits)
        public double Bits => bytes * 8.0;
        public double Kilobits => Bits / 1_000.0;
        public double Megabits => Bits / 1_000_000.0;
        public double Gigabit => Bits / 1_000_000_000.0;

        // ---------------------------------------------------------
        // Decimal / SI Standards (Powers of 10)
        // Used by: Hard Drive manufacturers, Network speeds, macOS
        // ---------------------------------------------------------
        public double Kilobytes => bytes / 1_000.0;             // 1 kB = 1,000 B
        public double Megabytes => bytes / 1_000_000.0;         // 1 MB = 1,000,000 B
        public double Gigabytes => bytes / 1_000_000_000.0;     // 1 GB = 10^9 B
        public double Terabytes => bytes / 1_000_000_000_000.0; // 1 TB = 10^12 B
        public double Petabytes => bytes / 1_000_000_000_000_000.0;

        // ---------------------------------------------------------
        // Binary / IEC Standards (Powers of 2)
        // Used by: RAM, Windows File Explorer
        // ---------------------------------------------------------
        private const double BYTES_PER_KIB = 1024.0;
        private const double BYTES_PER_MIB = 1024.0 * 1024.0;                   // 1,048,576
        private const double BYTES_PER_GIB = 1024.0 * 1024.0 * 1024.0;          // 1,073,741,824
        private const double BYTES_PER_TIB = 1024.0 * 1024.0 * 1024.0 * 1024.0; // 1,099,511,627,776

        public double Kibibytes => bytes / BYTES_PER_KIB; // 1 KiB = 1024 B
        public double Mebibytes => bytes / BYTES_PER_MIB; // 1 MiB = 1024 KiB
        public double Gibibytes => bytes / BYTES_PER_GIB; // 1 GiB = 1024 MiB
        public double Tebibytes => bytes / BYTES_PER_TIB; // 1 TiB = 1024 GiB

        // Operators
        public static DataVolume operator +(DataVolume a, DataVolume b) => new(a.bytes + b.bytes);
        public static DataVolume operator -(DataVolume a, DataVolume b) => new(a.bytes - b.bytes);
    }
}