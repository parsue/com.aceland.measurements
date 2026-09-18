namespace AceLand.Measurements
{
    public readonly struct DataVolume
    {
        // Internal storage in Bytes
        internal DataVolume(float bytes) => this._bytes = bytes;
        private readonly float _bytes;

        public override string ToString() => $"{_bytes} B";

        // Base Unit
        public float Bytes => _bytes;
        
        // Bits (1 Byte = 8 Bits)
        public float Bits => _bytes * 8f;
        public float Kilobits => Bits / 1_000f;
        public float Megabits => Bits / 1_000_000f;
        public float Gigabit => Bits / 1_000_000_000f;

        // ---------------------------------------------------------
        // Decimal / SI Standards (Powers of 10)
        // Used by: Hard Drive manufacturers, Network speeds, macOS
        // ---------------------------------------------------------
        public float Kilobytes => _bytes / 1_000f;             // 1 kB = 1,000 B
        public float Megabytes => _bytes / 1_000_000f;         // 1 MB = 1,000,000 B
        public float Gigabytes => _bytes / 1_000_000_000f;     // 1 GB = 10^9 B
        public float Terabytes => _bytes / 1_000_000_000_000f; // 1 TB = 10^12 B
        public float Petabytes => _bytes / 1_000_000_000_000_000f;

        // ---------------------------------------------------------
        // Binary / IEC Standards (Powers of 2)
        // Used by: RAM, Windows File Explorer
        // ---------------------------------------------------------
        private const float BYTES_PER_KIB = 1024f;
        private const float BYTES_PER_MIB = 1024f * 1024f;                   // 1,048,576
        private const float BYTES_PER_GIB = 1024f * 1024f * 1024f;          // 1,073,741,824
        private const float BYTES_PER_TIB = 1024f * 1024f * 1024f * 1024f; // 1,099,511,627,776

        public float Kibibytes => _bytes / BYTES_PER_KIB; // 1 KiB = 1024 B
        public float Mebibytes => _bytes / BYTES_PER_MIB; // 1 MiB = 1024 KiB
        public float Gibibytes => _bytes / BYTES_PER_GIB; // 1 GiB = 1024 MiB
        public float Tebibytes => _bytes / BYTES_PER_TIB; // 1 TiB = 1024 GiB

        // Operators
        public static DataVolume operator +(DataVolume a, DataVolume b) => new(a._bytes + b._bytes);
        public static DataVolume operator -(DataVolume a, DataVolume b) => new(a._bytes - b._bytes);
    }
}