namespace AceLand.Measurements
{
    public readonly struct Pressure
    {
        // Internal storage in Pascals
        internal Pressure(float pascals) => this._pascals = pascals;
        private readonly float _pascals;

        public override string ToString() => $"{_pascals} Pa";

        // --- Standard SI ---
        public float Pascals => _pascals;
        public float Kilopascals => _pascals / 1_000f;
        public float Megapascals => _pascals / 1_000_000f;

        // --- Common Air Units ---
        public float Bars => _pascals / 100_000f;
        public float Atmospheres => _pascals / 101_325f;
        public float PSI => _pascals / 6_894.757293168f;

        // --- Water / Hydraulic Units (Head) ---
        
        // Meters of Water Column (mH2O)
        // Defined at 4°C, standard gravity. 1 mH2O = 9806.65 Pa
        private const float PASCAL_PER_METER_WATER = 9_806.65f;
        public float MetersOfWater => _pascals / PASCAL_PER_METER_WATER;

        // Feet of Head (ftH2O)
        // 1 ftH2O = 2,989.0669 Pa
        private const float PASCAL_PER_FOOT_HEAD = 2_989.0669f;
        public float FeetOfHead => _pascals / PASCAL_PER_FOOT_HEAD;

        public static Pressure operator +(Pressure a, Pressure b) => new(a._pascals + b._pascals);
        public static Pressure operator -(Pressure a, Pressure b) => new(a._pascals - b._pascals);
    }
}