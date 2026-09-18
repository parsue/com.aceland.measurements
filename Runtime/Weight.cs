namespace AceLand.Measurements
{
    public readonly struct Weight
    {
        // Internal storage in Kilograms (SI Base Unit)
        internal Weight(float kilograms) => this.kilograms = kilograms;
        private readonly float kilograms;

        public override string ToString() => $"{kilograms} kg";

        // SI Units
        public float Kilograms => kilograms;
        public float Grams => kilograms * 1_000f;
        public float Milligrams => kilograms * 1_000_000f;
        public float Micrograms => kilograms * 1_000_000_000f;
        
        // Metric Tonne (1,000 kg)
        public float Tonnes => kilograms / 1_000f;

        // Imperial / US Customary
        // Exact definition: 1 pound = 0.45359237 kg
        private const float KG_PER_POUND = 0.45359237f;
        private const float KG_PER_OUNCE = KG_PER_POUND / 16f;        // 1 lb = 16 oz
        private const float KG_PER_STONE = KG_PER_POUND * 14f;        // 1 stone = 14 lbs
        private const float KG_PER_SHORT_TON = KG_PER_POUND * 2_000f; // US Ton
        private const float KG_PER_LONG_TON = KG_PER_POUND * 2_240f;  // Imperial Ton

        public float Pounds => kilograms / KG_PER_POUND;
        public float Ounces => kilograms / KG_PER_OUNCE;
        public float Stones => kilograms / KG_PER_STONE;
        public float ShortTons => kilograms / KG_PER_SHORT_TON; // US
        public float LongTons => kilograms / KG_PER_LONG_TON;   // UK

        // Aliases / Spelling variants
        public float MetricTonnes => Tonnes;
        public float MetricTons => Tonnes;
        
        public static Weight operator +(Weight a, Weight b) => new(a.kilograms + b.kilograms);
        public static Weight operator -(Weight a, Weight b) => new(a.kilograms - b.kilograms);
    }
}