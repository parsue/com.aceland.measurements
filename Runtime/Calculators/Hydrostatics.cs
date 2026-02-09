namespace AceLand.Measurements.Calculators
{
    public static class Hydrostatics
    {
        private const double GRAVITY = 9.80665; // Standard gravity
        private const double DENSITY_FRESH_WATER = 1000.0; // kg/m^3
        private const double DENSITY_SALT_WATER = 1025.0;  // kg/m^3

        /// <summary>
        /// Calculates pressure at a specific depth in Fresh Water.
        /// </summary>
        public static Pressure FromFreshWaterDepth(double depthInMeters)
        {
            // P = rho * g * h
            double pascals = DENSITY_FRESH_WATER * GRAVITY * depthInMeters;
            return new Pressure(pascals);
        }

        /// <summary>
        /// Calculates pressure at a specific depth in Salt Water (Ocean).
        /// </summary>
        public static Pressure FromSaltWaterDepth(double depthInMeters)
        {
            double pascals = DENSITY_SALT_WATER * GRAVITY * depthInMeters;
            return new Pressure(pascals);
        }
    }
}