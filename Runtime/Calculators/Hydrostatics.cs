namespace AceLand.Measurements.Calculators
{
    public static class Hydrostatics
    {
        private const float GRAVITY = 9.80665f; // Standard gravity
        private const float DENSITY_FRESH_WATER = 1000f; // kg/m^3
        private const float DENSITY_SALT_WATER = 1025f;  // kg/m^3

        /// <summary>
        /// Calculates pressure at a specific depth in Fresh Water.
        /// </summary>
        public static Pressure FromFreshWaterDepth(float depthInMeters)
        {
            // P = rho * g * h
            float pascals = DENSITY_FRESH_WATER * GRAVITY * depthInMeters;
            return new Pressure(pascals);
        }

        /// <summary>
        /// Calculates pressure at a specific depth in Salt Water (Ocean).
        /// </summary>
        public static Pressure FromSaltWaterDepth(float depthInMeters)
        {
            float pascals = DENSITY_SALT_WATER * GRAVITY * depthInMeters;
            return new Pressure(pascals);
        }
    }
}