#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="SystemOfUnits"/> record is used to identify a system of units,
/// such as the International System of Units (SI) or the Imperial System.
/// </summary>
public record SystemOfUnits
{
    #region Systems

    /// <summary>
    /// Represents an unknown, non-existent, or otherwise unspecified system of units.
    /// </summary>
    public static readonly SystemOfUnits None = new()
    {
        Name = "None",
        Abbreviation = string.Empty
    };

    /// <summary>
    /// The International System of Units (SI) is the modern form of the metric system
    /// and is the most widely used system of measurement in the world.
    /// </summary>
    public static readonly SystemOfUnits SI = new()
    {
        Name = "International System of Units",
        Abbreviation = "SI"
    };

    /// <summary>
    /// The Imperial System is a system of units that was used in the United Kingdom
    /// and is still used in some countries, including the United States.
    /// </summary>
    public static readonly SystemOfUnits Imperial = new()
    {
        Name = "Imperial System",
        Abbreviation = "Imperial"
    };

    #endregion Systems

    /// <summary>
    /// Required. Gets &amp; inits the system's name.
    /// </summary>
    /// <value>
    /// The system's name.
    /// </value>
    /// <seealso cref="Abbreviation"/>
    public required string Name { get; init; }

    /// <summary>
    /// Required. Gets &amp; inits an abbreviation for the system of units
    /// or, if not available, an empty string.
    /// </summary>
    /// <value>
    /// The system's abbreviation or, if not available, an empty string.
    /// </value>
    /// <seealso cref="Name"/>
    public required string Abbreviation { get; init; }
}
