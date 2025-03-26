using ConstTypeArgs.Doubles;

namespace Samples.UnitsOfMeasure;

public interface K_Length<TSelf> : K_Double
    where TSelf : K_Length<TSelf>, K_Double
{
    static abstract string Name { get; }
    static abstract string PluralName { get; }
    static abstract string Abbreviation { get; }
}

// Here we define the units of length. Each of these is represented
// by a const type arg with a value equal to conversion factor
// to the base unit (meter). A few more properties are defined
// for each unit to provide a name, plural name, and abbreviation.

public readonly struct Meter : K_Length<Meter>
{
    public static double Value        => 1.0;
    public static string Name         => "meter";
    public static string PluralName   => "meters";
    public static string Abbreviation => "m";
}

public readonly struct Millimeter : K_Length<Millimeter>
{
    public static double Value        => 0.001;
    public static string Name         => "millimeter";
    public static string PluralName   => "millimeters";
    public static string Abbreviation => "mm";
}

public readonly struct Centimeter : K_Length<Centimeter>
{
    public static double Value        => 0.01;
    public static string Name         => "centimeter";
    public static string PluralName   => "centimeters";
    public static string Abbreviation => "cm";
}

public readonly struct Kilometer : K_Length<Kilometer>
{
    public static double Value        => 1000.0;
    public static string Name         => "kilometer";
    public static string PluralName   => "kilometers";
    public static string Abbreviation => "km";
}

public readonly struct Inch : K_Length<Inch>
{
    public static double Value        => 0.0254;
    public static string Name         => "inch";
    public static string PluralName   => "inches";
    public static string Abbreviation => "in";
}

public readonly struct Foot : K_Length<Foot>
{
    public static double Value        => 0.3048;
    public static string Name         => "foot";
    public static string PluralName   => "feet";
    public static string Abbreviation => "ft";
}

public readonly struct Yard : K_Length<Yard>
{
    public static double Value        => 0.9144;
    public static string Name         => "yard";
    public static string PluralName   => "yards";
    public static string Abbreviation => "yd";
}

public readonly struct Mile : K_Length<Mile>
{
    public static double Value        => 1609.344;
    public static string Name         => "mile";
    public static string PluralName   => "miles";
    public static string Abbreviation => "mi";
}

public class Length<UnitArg>(double value)
             where UnitArg : K_Length<UnitArg>
{
    public double Value { get; } = value;

    public double ToMeters() => Value * UnitArg.Value;

    public Length<TargetUnit> ConvertTo<TargetUnit>()
           where TargetUnit : K_Length<TargetUnit>
    {
        double meters = ToMeters();
        double factor = 1.0 / TargetUnit.Value;

        return new Length<TargetUnit>(meters * factor);
    }

    public override string ToString()
    {
        bool isSingular = Math.Abs(Value - 1.0) < double.Epsilon;
        string name = isSingular ? UnitArg.Name : UnitArg.PluralName;
        return $"{Value} {name} ({UnitArg.Abbreviation})";
    }
}
