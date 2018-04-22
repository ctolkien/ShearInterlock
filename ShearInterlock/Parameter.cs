using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace UnitConversion
{
    class Parameter
    {
        public string Name { get; set; }
        public DisplayUnit DisplayUnit { get; set; }
        public UnitType UnitType { get; }
        public double Value { get; set; }

        public Parameter(string Name, DisplayUnit DisplayUnit, UnitType UnitType)
        {
            this.Name = Name;
            this.DisplayUnit = DisplayUnit;
            this.UnitType = UnitType;
            this.Value = 0;
        }

        public bool SetValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            else
            {
                double num;
                string unit;

                //does the string contain a suffix?
                Regex re1 = new Regex(@"([a-zA-Z]{1,})");
                Match m1 = re1.Match(value);
                if (m1.Success)
                {
                    //number with suffix
                    Regex re = new Regex(@"^(\d+\.{0,}\d{0,})\s{0,}(\w+\p{No}{0,1})$");
                    MatchCollection mc = re.Matches(value);

                    foreach (Match m in mc)
                    {
                        if (m.Success)
                        {
                            
                            Debug.Print("Contains Suffix");
                            bool success = double.TryParse(m.Groups[1].Value, out num);
                            unit = m.Groups[2].Value.ToUpper();
                            Debug.Print(string.Format("RegEx found number: " + num));
                            Debug.Print(string.Format("RegEx found this unit: " + unit));
                            if (!success)
                            {
                                Debug.Print("Regex failure");
                            }
                            else
                            {
                                StoreAsBaseUnit(num, GetUnitType(unit));
                                Debug.Print("Storeed as Base Unit");
                            }
                        }
                        else
                        {
                            Debug.Print("Regex failure");
                        }
                    }
                }
                else
                {
                    bool success = double.TryParse(value, out num);

                    StoreAsBaseUnit(num, DisplayUnit);
                    Debug.Print("No Suffix Found");
                }

            }


            return true;
        }

        private void StoreAsBaseUnit(double number, DisplayUnit displayUnit)
        {
            switch (displayUnit)
            {
                case DisplayUnit.MILLIMETER:
                    Value = Millimeter.To.Millimeter(number);
                    break;
                case DisplayUnit.SQUARE_MILLIMETER:
                    Value = Square_Millimeter.To.Square_Millimeter(number);
                    break;
                case DisplayUnit.CENTIMETER:
                    Value = Centimeter.To.Millimeter(number);
                    break;
                case DisplayUnit.METER:
                    Value = Meter.To.Millimeter(number);
                    break;
                case DisplayUnit.INCH:
                    Value = Inch.To.Millimeter(number);
                        break;
                case DisplayUnit.FOOT:
                    Value = Foot.To.Millimeter(number);
                    break;
                case DisplayUnit.PASCAL:
                    Value = Pascal.To.Pascal(number);
                    break;
                case DisplayUnit.KILOPASCAL:
                    Value = Kilopascal.To.Pascal(number);
                    break;
                case DisplayUnit.MEGAPASCAL:
                    Value = Megapascal.To.Pascal(number);
                    break;
                case DisplayUnit.GIGAPASCAL:
                    Value = Gigapascal.To.Pascal(number);
                    break;
                case DisplayUnit.POUND_PER_SQUARE_INCH:
                    Value = Pound_Per_Square_Inch.To.Pascal(number);
                    break;
                case DisplayUnit.KIP_PER_SQUARE_INCH:
                    Value = Kip_Per_Square_Inch.To.Pascal(number);
                    break;
                case DisplayUnit.POUND_PER_SQUARE_FOOT:
                    Value = Pound_Per_Square_Foot.To.Pascal(number);
                    break;
                case DisplayUnit.KIP_PER_SQUARE_FOOT:
                    Value = Kip_Per_Square_Foot.To.Pascal(number);
                    break;
                case DisplayUnit.NEWTON:
                    Value = Newton.To.Newton(number);
                    break;
                case DisplayUnit.KILONEWTON:
                    Value = Kilonewton.To.Newton(number);
                    break;
                case DisplayUnit.POUND:
                    Value = Pound.To.Newton(number);
                    break;
                case DisplayUnit.KIP:
                    Value = Pound.To.Newton(number);
                    break;
                default:
                    Debug.Print("Store As Base Unit Failure");
                    break;

            }
        }

        private DisplayUnit GetUnitType(string unitType)
        {
            unitType = unitType.ToUpper();
            switch (unitType)
            {
                case "MM":
                    if(UnitType == Millimeter.UnitType) { return Millimeter.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "MM2":
                case "MM²":
                    if (UnitType == Square_Millimeter.UnitType) { return Square_Millimeter.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "CM":
                    if (UnitType == Centimeter.UnitType) { return Centimeter.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "M":
                    if (UnitType == Meter.UnitType) { return Meter.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "KM":
                    if (UnitType == Kilometer.UnitType) { return Kilometer.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "IN":
                    if (UnitType == Inch.UnitType) { return Inch.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "FT":
                    if (UnitType == Foot.UnitType) { return Foot.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "PA":
                    if (UnitType == Pascal.UnitType) { return Pascal.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "KPA":
                    if (UnitType == Kilopascal.UnitType) { return Kilopascal.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "MPA":
                    if (UnitType == Megapascal.UnitType) { return Megapascal.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "GPA":
                    if (UnitType == Gigapascal.UnitType) { return Gigapascal.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "PSI":
                    if (UnitType == Pound_Per_Square_Inch.UnitType) { return Pound_Per_Square_Inch.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "KSI":
                    if (UnitType == Kip_Per_Square_Inch.UnitType) { return Kip_Per_Square_Inch.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "PSF":
                    if (UnitType == Pound_Per_Square_Foot.UnitType) { return Pound_Per_Square_Foot.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "KSF":
                    if (UnitType == Kip_Per_Square_Foot.UnitType) { return Kip_Per_Square_Foot.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "N":
                    if (UnitType == Newton.UnitType) { return Newton.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "KN":
                    if (UnitType == Kilonewton.UnitType) { return Kilonewton.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "LB":
                    if (UnitType == Pound.UnitType) { return Pound.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                case "KIP":
                    if (UnitType == Kip.UnitType) { return Kip.DisplayUnit; }
                    else { Debug.Print("Invalid Unit"); return DisplayUnit.INVALID; }
                default:
                    Debug.Print("Failed to get Get Unit Type");
                    return DisplayUnit.INVALID;
            }
        }

        private DisplayUnit GetInternalStorageUnit()
        {
            switch (UnitType)
            {
                case UnitType.LENGTH:
                    return DisplayUnit.MILLIMETER;
                case UnitType.STRESS:
                    return DisplayUnit.PASCAL;
                case UnitType.AREA:
                    return DisplayUnit.SQUARE_MILLIMETER;
                case UnitType.FORCE:
                    return DisplayUnit.NEWTON;
                default:
                    Debug.Print("Failed to get Internal Storage Unit");
                    return DisplayUnit.INVALID;
            }
        }

        public string GetValueString()
        {
            switch (DisplayUnit)
            {
                case DisplayUnit.MILLIMETER:
                    return (Millimeter.To.Millimeter(Value)).ToString() + " " + Millimeter.Suffix;
                case DisplayUnit.SQUARE_MILLIMETER:
                    return (Square_Millimeter.To.Square_Millimeter(Value)).ToString() + " " + Square_Millimeter.Suffix;
                case DisplayUnit.CENTIMETER:
                    return (Millimeter.To.Centimeter(Value)).ToString() + " " + Centimeter.Suffix;
                case DisplayUnit.METER:
                    return (Millimeter.To.Meter(Value)).ToString() + " " + Meter.Suffix;
                case DisplayUnit.KILOMETER:
                    return (Millimeter.To.Kilometer(Value)).ToString() + " " +Kilometer.Suffix;
                case DisplayUnit.INCH:
                    return (Millimeter.To.Inch(Value)).ToString() + " " + Inch.Suffix;
                case DisplayUnit.FOOT:
                    return (Millimeter.To.Foot(Value)).ToString() + " " + Foot.Suffix;
                case DisplayUnit.PASCAL:
                    return (Pascal.To.Pascal(Value)).ToString() + " " + Pascal.Suffix;
                case DisplayUnit.KILOPASCAL:
                    return (Pascal.To.Kilopascal(Value)).ToString() + " " + Kilopascal.Suffix;
                case DisplayUnit.MEGAPASCAL:
                    return (Pascal.To.Megapascal(Value)).ToString() + " " + Megapascal.Suffix;
                case DisplayUnit.GIGAPASCAL:
                    return (Pascal.To.Gigapascal(Value)).ToString() + " " + Gigapascal.Suffix;
                case DisplayUnit.POUND_PER_SQUARE_INCH:
                    return (Pascal.To.Pound_Per_Square_Inch(Value)).ToString() + " " + Pound_Per_Square_Inch.Suffix;
                case DisplayUnit.KIP_PER_SQUARE_INCH:
                    return (Pascal.To.Kips_Per_Square_Inch(Value)).ToString() + " " + Kip_Per_Square_Inch.Suffix;
                case DisplayUnit.POUND_PER_SQUARE_FOOT:
                    return (Pascal.To.Pound_Per_Square_Foot(Value)).ToString() + " " + Pound_Per_Square_Foot.Suffix;
                case DisplayUnit.KIP_PER_SQUARE_FOOT:
                    return (Pascal.To.Kip_Per_Square_Foot(Value)).ToString() + " " + Kip_Per_Square_Foot.Suffix;
                case DisplayUnit.NEWTON:
                    return (Newton.To.Newton(Value)).ToString() + " " + Newton.Suffix;
                case DisplayUnit.KILONEWTON:
                    return (Newton.To.Kilonewton(Value)).ToString() + " " + Kilonewton.Suffix;
                case DisplayUnit.POUND:
                    return (Newton.To.Pound(Value)).ToString() + " " + Pound.Suffix;
                case DisplayUnit.KIP:
                    return (Newton.To.Kip(Value)).ToString() + " " + Kip.Suffix;
                default:
                    return "Failed to get value string.";
            }
        }

    }
}
