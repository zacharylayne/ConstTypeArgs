#pragma warning disable RCS1130 // Bitwise operation on enum without Flags attribute

namespace ConstTypeArgs.Reflection.Attributes;

/// <summary>
/// The <see cref="AttributeArgumentTypes"/> enumeration provides values that represent
/// the valid types for an attribute's named &amp; positional arguments.
/// </summary>
public enum AttributeArgumentTypes
{
    /// <summary>
    /// The argument type is undefined.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// The argument is a <see cref="bool"/> value.
    /// </summary>
    Bool        = 1 << 1,

    /// <summary>
    /// The argument is a <see cref="byte"/> value.
    /// </summary>
    Byte        = 1 << 2,

    /// <summary>
    /// The argument is a <see cref="char"/> value.
    /// </summary>
    Char        = 1 << 3,

    /// <summary>
    /// The argument is a <see cref="double"/> value.
    /// </summary>
    Double      = 1 << 4,

    /// <summary>
    /// The argument is a <see cref="float"/> value.
    /// </summary>
    Float       = 1 << 5,

    /// <summary>
    /// The argument is an <see cref="int"/> value.
    /// </summary>
    Int         = 1 << 6,

    /// <summary>
    /// The argument is a <see cref="long"/> value.
    /// </summary>
    Long        = 1 << 7,

    /// <summary>
    /// The argument is a <see cref="short"/> value.
    /// </summary>
    Short       = 1 << 8,

    /// <summary>
    /// The argument is a <see cref="string"/> value.
    /// </summary>
    String      = 1 << 9,

    /// <summary>
    /// The argument is a <see cref="Type"/> value.
    /// </summary>
    Type        = 1 << 10,

    /// <summary>
    /// The argument is an enumeration value.
    /// </summary>
    Enum        = 1 << 11,

    /// <summary>
    /// The argument is an array.
    /// </summary>
    Array       = 1 << 12,

    /// <summary>
    /// The argument is a <see cref="bool"/> array.
    /// </summary>
    ByteArray   = Byte | Array,

    /// <summary>
    /// The argument is a <see cref="char"/> array.
    /// </summary>
    CharArray   = Char | Array,

    /// <summary>
    /// The argument is a <see cref="double"/> array.
    /// </summary>
    DoubleArray = Double | Array,

    /// <summary>
    /// The argument is a <see cref="float"/> array.
    /// </summary>
    FloatArray  = Float | Array,

    /// <summary>
    /// The argument is an <see cref="int"/> array.
    /// </summary>
    IntArray    = Int | Array,

    /// <summary>
    /// The argument is a <see cref="long"/> array.
    /// </summary>
    LongArray   = Long | Array,

    /// <summary>
    /// The argument is a <see cref="short"/> array.
    /// </summary>
    ShortArray  = Short | Array,

    /// <summary>
    /// The argument is a <see cref="string"/> array.
    /// </summary>
    StringArray = String | Array,

    /// <summary>
    /// The argument is a <see cref="Type"/> array.
    /// </summary>
    TypeArray   = Type | Array,

    /// <summary>
    /// The argument is an array of enumeration values.
    /// </summary>
    EnumArray   = Enum | Array,
}
