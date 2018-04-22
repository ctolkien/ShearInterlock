namespace UnitConversion
{
    public static class Unitless
    {
        public static readonly string Suffix = "";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.UNITLESS;
        public static readonly UnitType UnitType = UnitType.NONE;
        public static readonly UnitSystem unitSystem = UnitSystem.NONE;
    }
    public static class Millimeter
    {
        public static readonly string Suffix = "mm";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.MILLIMETER;
        public static readonly UnitType UnitType = UnitType.LENGTH;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Millimeter(double millimeter) => millimeter;
            public static double Centimeter(double millimeter) => millimeter / 10;
            public static double Meter     (double millimeter) => millimeter / 1000;
            public static double Kilometer (double millimeter) => millimeter / 1000000;
            public static double Inch      (double millimeter) => millimeter / 25.4;
            public static double Foot      (double millimeter) => millimeter / 304.8;
        }
    }
    public static class Square_Millimeter
    {
        public static readonly string Suffix = "mm²";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.SQUARE_MILLIMETER;
        public static readonly UnitType UnitType = UnitType.AREA;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Square_Millimeter(double square_Millimeter) => square_Millimeter;
            public static double Square_Centimeter(double square_Millimeter) => square_Millimeter * 1E-2;
            public static double Square_Meter     (double square_Millimeter) => square_Millimeter * 1e-6;
            public static double Square_Kilometer (double square_Millimeter) => square_Millimeter / 1e-12;
            public static double Square_Inch      (double square_Millimeter) => square_Millimeter * 1.55E-3;
            public static double Square_Foot      (double square_Millimeter) => square_Millimeter / 1.076391E-5;
        }
    }
    public static class Cubic_Millimeter
    {
        public static readonly string Suffix = "mm³";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.CUBIC_MILLIMETER;
        public static readonly UnitType UnitType = UnitType.VOLUME;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Cubic_Millimeter(double cubic_Millimeter) => cubic_Millimeter;
            public static double Cubic_Centimeter(double cubic_Millimeter) => cubic_Millimeter * 1E-3;
            public static double Cubic_Meter     (double cubic_Millimeter) => cubic_Millimeter * 1e-9;
            public static double Cubic_Kilometer (double cubic_Millimeter) => cubic_Millimeter / 1E-18;
            public static double Cubic_Inch      (double cubic_Millimeter) => cubic_Millimeter * 6.10237E-5;
            public static double Cubic_Foot      (double cubic_Millimeter) => cubic_Millimeter / 3.53147E-8;
        }
    }
    public static class Centimeter
    {
        public static readonly string Suffix = "cm";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.CENTIMETER;
        public static readonly UnitType UnitType = UnitType.LENGTH;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Millimeter(double centimeter) => centimeter * 10;
            public static double Centimeter(double centimeter) => centimeter;
            public static double Meter     (double centimeter) => centimeter / 100;
            public static double Kilometer (double centimeter) => centimeter / 100000;
            public static double Inch      (double centimeter) => centimeter / 2.54;
            public static double Foot      (double centimeter) => centimeter / 30.48;
        }
    }
    public static class Square_Centimeter
    {
        public static readonly string Suffix = "cm²";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.SQUARE_CENTIMETER;
        public static readonly UnitType UnitType = UnitType.AREA;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Millimeter(double square_Centimeter) => square_Centimeter * 100;
            public static double Centimeter(double square_Centimeter) => square_Centimeter;
            public static double Meter     (double square_Centimeter) => square_Centimeter * 1E-4;
            public static double Kilometer (double square_Centimeter) => square_Centimeter * 1E-10;
            public static double Inch      (double square_Centimeter) => square_Centimeter * 0.155;
            public static double Foot      (double square_Centimeter) => square_Centimeter * 0.00107639;
        }
    }
    public static class Meter
    {
        public static readonly string Suffix = "m";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.METER;
        public static readonly UnitType UnitType = UnitType.LENGTH;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Millimeter(double meter) => meter * 1000;
            public static double Centimeter(double meter) => meter * 100;
            public static double Meter     (double meter) => meter;
            public static double Kilometer (double meter) => meter / 1000;
            public static double Inch      (double meter) => meter / 0.0254;
            public static double Foot      (double meter) => meter / 0.3048;
        }
    }
    public static class Kilometer
    {
        public static readonly string Suffix = "km";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.KILOMETER;
        public static readonly UnitType UnitType = UnitType.LENGTH;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;
        public static class To
        {
            public static double Millimeter(double kilometer) => kilometer / 1000000;
            public static double Centimeter(double kilometer) => kilometer / 100000;
            public static double Meter     (double kilometer) => kilometer / 1000;
            public static double Kilometer (double kilometer) => kilometer;
            public static double Inch      (double kilometer) => kilometer / 39370.1;
            public static double Foot      (double kilometer) => kilometer / 3280.84;
        }
    }
    public static class Inch
    {
        public static readonly string Suffix = "in";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.INCH;
        public static readonly UnitType UnitType = UnitType.LENGTH;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;
        public static class To
        {
            public static double Millimeter(double inch) => inch * 25.4;
            public static double Centimeter(double inch) => inch * 2.54;
            public static double Meter     (double inch) => inch * 0.0254;
            public static double Kilometer (double inch) => inch * 0.0000254;
            public static double Inch      (double inch) => inch;
            public static double Foot      (double inch) => inch / 12;
        }
    }
    public static class Foot
    {
        public static readonly string Suffix = "ft";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.FOOT;
        public static readonly UnitType UnitType = UnitType.LENGTH;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Millimeter(double foot) => foot * 304.8;
            public static double Centimeter(double foot) => foot * 30.48;
            public static double Meter     (double foot) => foot * 0.3048;
            public static double Kilometer (double foot) => foot * 0.0003048;
            public static double Inch      (double foot) => foot * 12;
            public static double Foot      (double foot) => foot;
        }
    }
    public static class Newton
    {
        public static readonly string Suffix = "N";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.NEWTON;
        public static readonly UnitType UnitType = UnitType.FORCE;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;

        public static class To
        {
            public static double Newton(double newton) => newton;
            public static double Kilonewton(double newton) => newton * 1E-3;
            public static double Meganewton(double newton) => newton * 1E-6;
            public static double Giganewton(double newton) => newton * 1E-9;
            public static double Pound(double newton) => newton * 0.2248089;
            public static double Kip(double newton) => newton * 0.0002248089;
        }
    }
    public static class Kilonewton
    {
        public static readonly string Suffix = "kN";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.KILONEWTON;
        public static readonly UnitType UnitType = UnitType.FORCE;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;

        public static class To
        {
            public static double Newton    (double kilonewton) => kilonewton * 1E3;
            public static double Kilonewton(double kilonewton) => kilonewton;
            public static double Meganewton(double kilonewton) => kilonewton * 1E-3;
            public static double Giganewton(double kilonewton) => kilonewton * 1E-6;
            public static double Pound     (double kilonewton) => kilonewton * 224.8089;
            public static double Kip       (double kilonewton) => kilonewton * 0.2248089;
        }
    }
    public static class Pound
    {
        public static readonly string Suffix = "lb";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.POUND;
        public static readonly UnitType UnitType = UnitType.FORCE;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Newton    (double pound) => pound * 4.448222;
            public static double Kilonewton(double pound) => pound * 0.004448222;
            public static double Meganewton(double pound) => pound * 0.000004448222;
            public static double Giganewton(double pound) => pound * 0.000000004448222;
            public static double Pound     (double pound) => pound;
            public static double Kip       (double pound) => pound * 1E-3;
        }
    }
    public static class Kip
    {
        public static readonly string Suffix = "kip";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.KIP;
        public static readonly UnitType UnitType = UnitType.FORCE;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Newton(double pound) => pound * 4448.222;
            public static double Kilonewton(double pound) => pound * 4.448222;
            public static double Meganewton(double pound) => pound * 0.004448222;
            public static double Giganewton(double pound) => pound * 0.000004448222;
            public static double Pound(double pound) => pound * 1E3;
            public static double Kip(double pound) => pound;
        }
    }
    public static class Pascal
    {
        public static readonly string Suffix = "pa";
        public static readonly bool IsBaseUnit = true;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.PASCAL;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;

        public static class To
        {
            public static double Pascal               (double pascal) => pascal;
            public static double Kilopascal           (double pascal) => pascal * 1E-3;
            public static double Megapascal           (double pascal) => pascal * 1E-6;
            public static double Gigapascal           (double pascal) => pascal * 1E-9;
            public static double Pound_Per_Square_Inch(double pascal) => pascal / 6894.7572931783;
            public static double Kips_Per_Square_Inch (double pascal) => pascal / 6894757.2931783;
            public static double Pound_Per_Square_Foot(double pascal) => pascal / 47.880258888889;
            public static double Kip_Per_Square_Foot  (double pascal) => pascal / 47880.258888889;
        }
    }
    public static class Kilopascal
    {
        public static readonly string Suffix = "kpa";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.KILOPASCAL;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;

        public static class To
        {
            public static double Pascal                (double kilopascal) => kilopascal * 1E3;
            public static double Kilopascal            (double kilopascal) => kilopascal;
            public static double Megapascal            (double kilopascal) => kilopascal * 1E-3;
            public static double Gigapascal            (double kilopascal) => kilopascal * 1E-6;
            public static double Pounds_Per_Square_Inch(double kilopascal) => kilopascal / 6.8947572931783;
            public static double Kips_Per_Square_Inch  (double kilopascal) => kilopascal / 6894.7572931783;
            public static double Pounds_Per_Square_Foot(double kilopascal) => kilopascal / 0.047880258888889;
            public static double Kips_Per_Square_Foot  (double kilopascal) => kilopascal / 47.880258888889;
        }
    }
    public static class Megapascal
    {
        public static readonly string Suffix = "mpa";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.MEGAPASCAL;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;

        public static class To
        {
            public static double Pascal                (double megapascal) => megapascal * 1E6;
            public static double Kilopascal            (double megapascal) => megapascal * 1E3;
            public static double Megapascal            (double megapascal) => megapascal;
            public static double Gigapascal            (double megapascal) => megapascal * 1E-3;
            public static double Pounds_Per_Square_Inch(double megapascal) => megapascal * 145.0377;
            public static double Kips_Per_Square_Inch  (double megapascal) => megapascal * 0.1450377;
            public static double Pounds_Per_Square_Foot(double megapascal) => megapascal * 20885.43;
            public static double Kips_Per_Square_Foot  (double megapascal) => megapascal / 20.88543;
        }
    }
    public static class Gigapascal
    {
        public static readonly string Suffix = "gpa";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.GIGAPASCAL;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.METRIC;

        public static class To
        {
            public static double Pascal                (double gigapascal) => gigapascal;
            public static double Kilopascal            (double gigapascal) => gigapascal * 1E6;
            public static double Megapascal            (double gigapascal) => gigapascal * 1E3;
            public static double Gigapascal            (double gigapascal) => gigapascal;
            public static double Pounds_Per_Square_Inch(double gigapascal) => gigapascal / 145038;
            public static double Kips_Per_Square_Inch  (double gigapascal) => gigapascal / 145.038;
            public static double Pounds_Per_Square_Foot(double gigapascal) => gigapascal / 20885434.2730;
            public static double Kips_Per_Square_Foot  (double gigapascal) => gigapascal / 20885.4342730;
        }
    }
    public static class Pound_Per_Square_Inch
    {
        public static readonly string Suffix = "psi";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.POUND_PER_SQUARE_INCH;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Pascal                (double pounds_Per_Square_Inch) => pounds_Per_Square_Inch * 6894.7572932;
            public static double Kilopascal            (double pounds_Per_Square_Inch) => pounds_Per_Square_Inch * 6.8947572932;
            public static double Megapascal            (double pounds_Per_Square_Inch) => pounds_Per_Square_Inch * 0.0068947572932;
            public static double Gigapascal            (double pounds_Per_Square_Inch) => pounds_Per_Square_Inch * 0.0000068947572932;
            public static double Pounds_Per_Square_Inch(double pounds_Per_Square_Inch) => pounds_Per_Square_Inch;
            public static double Kips_Per_Square_Inch  (double pounds_Per_Square_Inch) => pounds_Per_Square_Inch / 1000;
            public static double Pounds_Per_Square_Foot(double pounds_Per_Square_Inch) => pounds_Per_Square_Inch * 144;
            public static double Kips_Per_Square_Foot  (double pounds_Per_Square_Inch) => pounds_Per_Square_Inch * 144000;
        }
    }
    public static class Kip_Per_Square_Inch
    {
        public static readonly string Suffix = "ksi";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.KIP_PER_SQUARE_INCH;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Pascal                (double kips_Per_Square_Inch) => kips_Per_Square_Inch * 6894757.2932;
            public static double Kilopascal            (double kips_Per_Square_Inch) => kips_Per_Square_Inch * 6894.7572932;
            public static double Megapascal            (double kips_Per_Square_Inch) => kips_Per_Square_Inch * 6.8947572932;
            public static double Gigapascal            (double kips_Per_Square_Inch) => kips_Per_Square_Inch * 0.0068947572932;
            public static double Pounds_Per_Square_Inch(double kips_Per_Square_Inch) => kips_Per_Square_Inch / 1000;
            public static double Kips_Per_Square_Inch  (double kips_Per_Square_Inch) => kips_Per_Square_Inch;
            public static double Pounds_Per_Square_Foot(double kips_Per_Square_Inch) => kips_Per_Square_Inch * 144000;
            public static double Kips_Per_Square_Foot  (double kips_Per_Square_Inch) => kips_Per_Square_Inch * 144;
        }
    }
    public static class Pound_Per_Square_Foot
    {
        public static readonly string Suffix = "psf";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.POUND_PER_SQUARE_FOOT;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Pascal                (double pounds_Per_Square_Foot) => pounds_Per_Square_Foot * 47.88026;
            public static double Kilopascal            (double pounds_Per_Square_Foot) => pounds_Per_Square_Foot * 0.04788026;
            public static double Megapascal            (double pounds_Per_Square_Foot) => pounds_Per_Square_Foot * 0.00004788026;
            public static double Gigapascal            (double pounds_Per_Square_Foot) => pounds_Per_Square_Foot * 0.00000004788026;
            public static double Pounds_Per_Square_Inch(double pounds_Per_Square_Foot) => pounds_Per_Square_Foot * 144;
            public static double Kips_Per_Square_Inch  (double pounds_Per_Square_Foot) => pounds_Per_Square_Foot * 144000;
            public static double Pounds_Per_Square_Foot(double pounds_Per_Square_Foot) => pounds_Per_Square_Foot;
            public static double Kips_Per_Square_Foot  (double pounds_Per_Square_Foot) => pounds_Per_Square_Foot / 1000;
        }
    }
    public static class Kip_Per_Square_Foot
    {
        public static readonly string Suffix = "ksf";
        public static readonly bool IsBaseUnit = false;
        public static readonly DisplayUnit DisplayUnit = DisplayUnit.KIP_PER_SQUARE_FOOT;
        public static readonly UnitType UnitType = UnitType.STRESS;
        public static readonly UnitSystem unitSystem = UnitSystem.IMPERIAL;

        public static class To
        {
            public static double Pascal                (double kips_Per_Square_Foot) => kips_Per_Square_Foot * 47880.26;
            public static double Kilopascal            (double kips_Per_Square_Foot) => kips_Per_Square_Foot * 47.88026;
            public static double Megapascal            (double kips_Per_Square_Foot) => kips_Per_Square_Foot * 0.04788026;
            public static double Gigapascal            (double kips_Per_Square_Foot) => kips_Per_Square_Foot * 0.00004788026;
            public static double Pounds_Per_Square_Inch(double kips_Per_Square_Foot) => kips_Per_Square_Foot / 0.144;
            public static double Kips_Per_Square_Inch  (double kips_Per_Square_Foot) => kips_Per_Square_Foot / 144;
            public static double Pounds_Per_Square_Foot(double kips_Per_Square_Foot) => kips_Per_Square_Foot * 1000;
            public static double Kips_Per_Square_Foot  (double kips_Per_Square_Foot) => kips_Per_Square_Foot;
        }
    }
}
