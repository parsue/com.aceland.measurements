namespace AceLand.Measurements
{
    public static class WeightExtensions
    {
        // --- Weight (float) ---

        // SI
        public static Weight Kilograms(this float value) => new(value);
        public static Weight Grams(this float value) => new(value / 1_000f);
        public static Weight Milligrams(this float value) => new(value / 1_000_000f);
        public static Weight Micrograms(this float value) => new(value / 1_000_000_000f);
        public static Weight Tonnes(this float value) => new(value * 1_000f);

        // Imperial / US
        // 1 lb = 0.45359237 kg
        public static Weight Pounds(this float value) => new(value * 0.45359237f);
        public static Weight Ounces(this float value) => new(value * (0.45359237f / 16f));
        public static Weight Stones(this float value) => new(value * (0.45359237f * 14f));
        public static Weight ShortTons(this float value) => new(value * (0.45359237f * 2_000f));
        public static Weight LongTons(this float value) => new(value * (0.45359237f * 2_240f));

        // --- Weight (int) ---

        // SI
        public static Weight Kilograms(this int value) => new(value);
        public static Weight Grams(this int value) => new(value / 1_000f);
        public static Weight Milligrams(this int value) => new(value / 1_000_000f);
        public static Weight Tonnes(this int value) => new(value * 1_000f);

        // Imperial / US
        public static Weight Pounds(this int value) => new(value * 0.45359237f);
        public static Weight Ounces(this int value) => new(value * (0.45359237f / 16f));
        public static Weight Stones(this int value) => new(value * (0.45359237f * 14f));
        public static Weight ShortTons(this int value) => new(value * (0.45359237f * 2_000f));
    }
}