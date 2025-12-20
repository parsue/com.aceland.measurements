namespace AceLand.Measurements
{
    public readonly struct Weight
    {
        // Internal storage in Kilograms (SI Base Unit)
        internal Weight(double kilograms) => this.kilograms = kilograms;
        private readonly double kilograms;

        public override string ToString() => $"{kilograms} kg";

        // SI Units
        public double Kilograms => kilograms;
        public double Grams => kilograms * 1_000.0;
        public double Milligrams => kilograms * 1_000_000.0;
        public double Micrograms => kilograms * 1_000_000_000.0;
        
        // Metric Tonne (1,000 kg)
        public double Tonnes => kilograms / 1_000.0;

        // Imperial / US Customary
        // Exact definition: 1 pound = 0.45359237 kg
        private const double KG_PER_POUND = 0.45359237;
        private const double KG_PER_OUNCE = KG_PER_POUND / 16.0;        // 1 lb = 16 oz
        private const double KG_PER_STONE = KG_PER_POUND * 14.0;        // 1 stone = 14 lbs
        private const double KG_PER_SHORT_TON = KG_PER_POUND * 2_000.0; // US Ton
        private const double KG_PER_LONG_TON = KG_PER_POUND * 2_240.0;  // Imperial Ton

        public double Pounds => kilograms / KG_PER_POUND;
        public double Ounces => kilograms / KG_PER_OUNCE;
        public double Stones => kilograms / KG_PER_STONE;
        public double ShortTons => kilograms / KG_PER_SHORT_TON; // US
        public double LongTons => kilograms / KG_PER_LONG_TON;   // UK

        // Aliases / Spelling variants
        public double MetricTonnes => Tonnes;
        public double MetricTons => Tonnes;
        
        public static Weight operator +(Weight a, Weight b) => new(a.kilograms + b.kilograms);
        public static Weight operator -(Weight a, Weight b) => new(a.kilograms - b.kilograms);
    }
}