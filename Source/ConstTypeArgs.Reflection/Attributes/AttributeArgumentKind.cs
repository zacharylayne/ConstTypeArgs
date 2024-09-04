namespace ConstTypeArgs.Reflection.Attributes;

/// <summary>
/// The <see cref="AttributeArgumentKind"/> enumeration provides values that specify the kind of argument
/// a custom attribute argument is <em>(i.e. named or positional)</em>.
/// </summary>
public enum AttributeArgumentKind
{
    /// <summary>
    /// No argument kind specified.
    /// </summary>
    None = 0,

    /// <summary>
    /// The argument is a named attribute argument.
    /// </summary>
    Named = 1 << 1,

    /// <summary>
    /// The argument is a positional attribute argument.
    /// </summary>
    Positional = 1 << 2,
}
