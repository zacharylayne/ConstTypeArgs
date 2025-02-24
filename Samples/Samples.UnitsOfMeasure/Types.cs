using ConstTypeArgs.Doubles;

namespace Samples.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_Length"/> interface provides an interface for
/// defining length units.
/// </summary>
public interface K_Length : K_Double;

/// <summary>
/// The <see cref="K_Length{TSelf}"/> interface provides an interface for
/// defining length unit and provides static accessors for the unit's names.
/// </summary>
/// <typeparam name="TSelf">
/// This type.
/// </typeparam>
public interface K_Length<TSelf>
    : K_Length
    where TSelf : K_Length<TSelf>, K_Length
{
    /// <summary>
    /// Gets the name of the unit of length.
    /// </summary>
    static abstract string Name { get; }

    /// <summary>
    /// Gets the plural name of the unit of length.
    /// </summary>
    static abstract string PluralName { get; }

    /// <summary>
    /// Gets the abbreviation of the unit of length.
    /// </summary>
    static abstract string Abbreviation { get; }
}

// Here we define the units of length.
// Each of these is represented by a const type arg with a value equal to
// conversion factor to the base unit (meter).

public readonly struct Meter
    : K_Length<Meter>
{
    public static double Value => 1.0;

    public static string Name => "meter";

    public static string PluralName => "meters";

    public static string Abbreviation => "m";
}

public readonly struct Millimeter
    : K_Length<Millimeter>
{
    public static double Value => 0.001;

    public static string Name => "millimeter";

    public static string PluralName => "millimeters";

    public static string Abbreviation => "mm";
}

public readonly struct Centimeter
    : K_Length<Centimeter>
{
    public static double Value => 0.01;

    public static string Name => "centimeter";

    public static string PluralName => "centimeters";

    public static string Abbreviation => "cm";
}

public readonly struct Kilometer
    : K_Length<Kilometer>
{
    public static double Value => 1000.0;

    public static string Name => "kilometer";

    public static string PluralName => "kilometers";

    public static string Abbreviation => "km";
}

public readonly struct Inch
    : K_Length<Inch>
{
    public static double Value => 0.0254;

    public static string Name => "inch";

    public static string PluralName => "inches";

    public static string Abbreviation => "in";
}

public readonly struct Foot
    : K_Length<Foot>
{
    public static double Value => 0.3048;

    public static string Name => "foot";

    public static string PluralName => "feet";

    public static string Abbreviation => "ft";
}

public readonly struct Yard
    : K_Length<Yard>
{
    public static double Value => 0.9144;

    public static string Name => "yard";

    public static string PluralName => "yards";

    public static string Abbreviation => "yd";
}

public readonly struct Mile
    : K_Length<Mile>
{
    public static double Value => 1609.344;

    public static string Name => "mile";

    public static string PluralName => "miles";

    public static string Abbreviation => "mi";
}

public class Length<UNIT>(double value)
    where UNIT : K_Length<UNIT>, K_Length
{
    public double Value { get; } = value;

    public double ToMeters()
        => Value * UNIT.Value;

    public Length<TARGET_UNIT> ConvertTo<TARGET_UNIT>()
        where TARGET_UNIT : K_Length<TARGET_UNIT>
    {
        double meters = ToMeters();
        double factor = 1.0 / TARGET_UNIT.Value;

        return new Length<TARGET_UNIT>(meters * factor);
    }

    public override string ToString()
    {
        bool isSingular = Math.Abs(Value - 1.0) < double.Epsilon;
        string name = isSingular ? UNIT.Name : UNIT.PluralName;
        return $"{Value} {name} ({UNIT.Abbreviation})";
    }
}
