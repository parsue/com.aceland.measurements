namespace AceLand.Measurements
{
    public readonly struct Pressure
    {
        // Internal storage in Pascals
        internal Pressure(double pascals) => this.pascals = pascals;
        private readonly double pascals;

        public override string ToString() => $"{pascals} Pa";

        // --- Standard SI ---
        public double Pascals => pascals;
        public double Kilopascals => pascals / 1_000.0;
        public double Megapascals => pascals / 1_000_000.0;

        // --- Common Air Units ---
        public double Bars => pascals / 100_000.0;
        public double Atmospheres => pascals / 101_325.0;
        public double PSI => pascals / 6_894.757293168;

        // --- Water / Hydraulic Units (Head) ---
        
        // Meters of Water Column (mH2O)
        // Defined at 4°C, standard gravity. 1 mH2O = 9806.65 Pa
        private const double PASCAL_PER_METER_WATER = 9_806.65;
        public double MetersOfWater => pascals / PASCAL_PER_METER_WATER;

        // Feet of Head (ftH2O)
        // 1 ftH2O = 2,989.0669 Pa
        private const double PASCAL_PER_FOOT_HEAD = 2_989.0669;
        public double FeetOfHead => pascals / PASCAL_PER_FOOT_HEAD;

        public static Pressure operator +(Pressure a, Pressure b) => new(a.pascals + b.pascals);
        public static Pressure operator -(Pressure a, Pressure b) => new(a.pascals - b.pascals);
    }
}