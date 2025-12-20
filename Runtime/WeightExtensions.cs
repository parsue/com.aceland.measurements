namespace AceLand.Measurements
{
    public static class WeightExtensions
    {
        // --- Weight (double) ---

        // SI
        public static Weight Kilograms(this double value) => new(value);
        public static Weight Grams(this double value) => new(value / 1_000.0);
        public static Weight Milligrams(this double value) => new(value / 1_000_000.0);
        public static Weight Micrograms(this double value) => new(value / 1_000_000_000.0);
        public static Weight Tonnes(this double value) => new(value * 1_000.0);

        // Imperial / US
        // 1 lb = 0.45359237 kg
        public static Weight Pounds(this double value) => new(value * 0.45359237);
        public static Weight Ounces(this double value) => new(value * (0.45359237 / 16.0));
        public static Weight Stones(this double value) => new(value * (0.45359237 * 14.0));
        public static Weight ShortTons(this double value) => new(value * (0.45359237 * 2_000.0));
        public static Weight LongTons(this double value) => new(value * (0.45359237 * 2_240.0));

        // --- Weight (int) ---

        // SI
        public static Weight Kilograms(this int value) => new(value);
        public static Weight Grams(this int value) => new(value / 1_000.0);
        public static Weight Milligrams(this int value) => new(value / 1_000_000.0);
        public static Weight Tonnes(this int value) => new(value * 1_000.0);

        // Imperial / US
        public static Weight Pounds(this int value) => new(value * 0.45359237);
        public static Weight Ounces(this int value) => new(value * (0.45359237 / 16.0));
        public static Weight Stones(this int value) => new(value * (0.45359237 * 14.0));
        public static Weight ShortTons(this int value) => new(value * (0.45359237 * 2_000.0));
    }
}