namespace AceLand.Measurements
{
    public readonly struct Length
    {
        // Internal storage in meters
        internal Length(float meters) => this._meters = meters;
        private readonly float _meters;
        
        public override string ToString() => $"{_meters} meters";

        // SI units
        public float Meters => _meters;
        public float Kilometers => _meters / 1_000f;
        public float Centimeters => _meters * 100f;
        public float Millimeters => _meters * 1_000f;
        public float Micrometers => _meters * 1_000_000f;
        public float Nanometers => _meters * 1_000_000_000f;

        // Imperial / US customary
        // Exact: 1 inch = 0.0254 m (international inch)
        private const float METER_PER_INCH = 0.0254f;
        private const float METER_PER_FOOT = 0.3048f;          // 12 inches
        private const float METER_PER_YARD = 0.9144f;          // 3 feet
        private const float METER_PER_MILE = 1_609.344f;        // 1760 yards
        public float Inches => _meters / METER_PER_INCH;
        public float Feet => _meters / METER_PER_FOOT;
        public float Yards => _meters / METER_PER_YARD;
        public float Miles => _meters / METER_PER_MILE;

        // Nautical / astronomical
        private const float METER_PER_NAUTICAL_MILE = 1_852f;  // exact
        private const float METER_PER_ASTRONOMICAL_UNIT = 149_597_870_700f; // IAU 2012, exact
        public float NauticalMiles => _meters / METER_PER_NAUTICAL_MILE;
        public float AstronomicalUnits => _meters / METER_PER_ASTRONOMICAL_UNIT;

        // Convenience aliases (common spellings)
        public float Metres => Meters;
        public float Kilometres => Kilometers;

        public static Length operator +(Length a, Length b) => new(a._meters + b._meters);
        public static Length operator -(Length a, Length b) => new(a._meters - b._meters);
        
        // Area operator remains unchanged
        public static Area operator *(Length width, Length breadth) =>
            (width._meters * breadth._meters).SquareMeters();
        
        // Length * Area = Volume
        public static Volume operator *(Length length, Area area) => 
            new Volume(length._meters * area.SquareMeters);
    }
}