using ConstTypeArgs.Core;

#pragma warning disable RCS1154 // Sort enum members

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="WellKnownConstTypes"/> enumeration provides flags to identify what
/// kind of well-known const type a type may be, derive from, or implement.
/// </summary>
/// <seealso cref="FrameworkKinds"/>
[Flags]
public enum WellKnownConstTypes
    : long
{
    /// <summary>
    /// The type is not a well-known const type.
    /// </summary>
    None                = 0,

    /// <summary>
    /// The type is <c>K_Bool</c> type.
    /// </summary>
    K_Bool              = 1L << 0,

    /// <summary>
    /// The type is <c>K_Byte</c> type.
    /// </summary>
    K_Byte              = 1L << 1,

    /// <summary>
    /// The type is <c>K_Char</c> type.
    /// </summary>
    K_Char              = 1L << 2,

    /// <summary>
    /// The type is <c>K_Decimal</c> type.
    /// </summary>
    K_Decimal           = 1L << 3,

    /// <summary>
    /// The type is <c>K_Double</c> type.
    /// </summary>
    K_Double            = 1L << 4,

    /// <summary>
    /// The type is <c>K_Float</c> type.
    /// </summary>
    K_Float             = 1L << 5,

    /// <summary>
    /// The type is <c>K_Half</c> type.
    /// </summary>
    K_Half              = 1L << 6,

    /// <summary>
    /// The type is <c>K_Int</c> type.
    /// </summary>
    K_Int               = 1L << 7,

    /// <summary>
    /// The type is <c>K_Int128</c> type.
    /// </summary>
    K_Int128            = 1L << 8,

    /// <summary>
    /// The type is <c>K_Long</c> type.
    /// </summary>
    K_Long              = 1L << 9,

    /// <summary>
    /// The type is <c>K_Nint</c> type.
    /// </summary>
    K_Nint              = 1L << 10,

    /// <summary>
    /// The type is <c>K_Nuint</c> type.
    /// </summary>
    K_Nuint             = 1L << 11,

    /// <summary>
    /// The type is <c>K_Sbyte</c> type.
    /// </summary>
    K_Sbyte             = 1L << 12,

    /// <summary>
    /// The type is <c>K_Short</c> type.
    /// </summary>
    K_Short             = 1L << 13,

    /// <summary>
    /// The type is <c>K_String</c> type.
    /// </summary>
    K_String            = 1L << 14,

    /// <summary>
    /// The type is <c>K_Type</c> type.
    /// </summary>
    K_Type              = 1L << 15,

    /// <summary>
    /// The type is <c>K_Uint</c> type.
    /// </summary>
    K_Uint              = 1L << 16,

    /// <summary>
    /// The type is <c>K_UInt128</c> type.
    /// </summary>
    K_UInt128           = 1L << 17,

    /// <summary>
    /// The type is <c>K_Ulong</c> type.
    /// </summary>
    K_Ulong             = 1L << 18,

    /// <summary>
    /// The type is <c>K_Ushort</c>.
    /// </summary>
    K_Ushort            = 1L << 19,

    /// <summary>
    /// The type is a <c>IConstTypeArg</c> type.
    /// </summary>
    /// <seealso cref="IConstTypeArg{T}"/>
    /// <seealso cref="IConstTypeArg{T, TSelf}"/>
    /// <seealso cref="ConstTypeArgs.IConstTypeArg"/>
    IConstTypeArg       = 1L << 62,

    /// <summary>
    /// The type is a <c>K_Array</c> type.
    /// </summary>
    /// <seealso cref="K_Array{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Array"/>
    K_Array             = 1L << 31,

    /// <summary>
    /// The type is a <c>K_Class</c> type.
    /// </summary>
    /// <seealso cref="K_Class{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Class"/>
    K_Class             = 1L << 32,

    /// <summary>
    /// The type is a <c>K_Delegate</c> type.
    /// </summary>
    /// <seealso cref="K_Delegate{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Delegate"/>
    K_Delegate          = 1L << 33,

    /// <summary>
    /// The type is a <c>K_Enum</c> type.
    /// </summary>
    /// <seealso cref="K_Enum{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Enum"/>
    K_Enum              = 1L << 34,

    /// <summary>
    /// The type is a <c>K_FloatingPoint</c> type.
    /// </summary>
    /// <seealso cref="K_FloatingPoint{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_FloatingPoint"/>
    K_FloatingPoint     = 1L << 35,

    /// <summary>
    /// The type is a <c>K_Integer</c> type.
    /// </summary>
    /// <seealso cref="K_Integer{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Integer"/>
    K_Integer           = 1L << 36,

    /// <summary>
    /// The type is a <c>K_MulticastDelegate</c> type.
    /// </summary>
    /// <seealso cref="K_MulticastDelegate{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_MulticastDelegate"/>
    K_MulticastDelegate = 1L << 37,

    /// <summary>
    /// The type is a <c>K_Number</c> type.
    /// </summary>
    /// <seealso cref="K_Number{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Number"/>
    K_Number            = 1L << 38,

    /// <summary>
    /// The type is a <c>K_ReadOnlyMemory</c> type.
    /// </summary>
    /// <seealso cref="K_ReadOnlyMemory{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_ReadOnlyMemory"/>
    K_ReadOnlyMemory    = 1L << 39,

    /// <summary>
    /// The type is a <c>K_SignedNumber</c> type.
    /// </summary>
    /// <seealso cref="K_SignedNumber{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_SignedNumber"/>
    K_SignedNumber      = 1L << 40,

    /// <summary>
    /// The type is a <c>K_Struct</c> type.
    /// </summary>
    /// <seealso cref="K_Struct{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Struct"/>
    K_Struct            = 1L << 41,

    /// <summary>
    /// The type is a <c>K_Array</c> type.
    /// </summary>
    /// <seealso cref="K_Unmanaged{T}"/>
    /// <seealso cref="ConstTypeArgs.Core.K_Unmanaged"/>
    K_Unmanaged         = 1L << 42,

    /// <summary>
    /// The type is a <c>K</c> type <em>(i.e. const type argument holder)</em>.
    /// </summary>
    /// <seealso cref="K{TArg}"/>
    /// <seealso cref="K{T, TArg}"/>
    /// <seealso cref="ConstTypeArgs.K"/>
    K                   = 1L << 43,

    /// <summary>
    /// The type is a <c>__</c> type <em>(i.e. discard type)</em>.
    /// </summary>
    /// <seealso cref="ConstTypeArgs.Core.__"/>
    __                  = 1L << 44,

    /// <summary>
    /// Identifies all well-known types that are part of the ConstTypeArgs.Core library.
    /// </summary>
    Core                = IConstTypeArg | K_Array | K_Class | K_Delegate | K_Enum | K_FloatingPoint | K_Integer
                        | K_MulticastDelegate | K_Number | K_ReadOnlyMemory | K_SignedNumber | K_Struct | K_Unmanaged
                        | K | __,

    /// <summary>
    /// Identifies all interfaces that are the most-derived from <see cref="IConstTypeArg{T}"/>.
    /// These interfaces are directly implemented by const type arguments.
    /// </summary>
    MostDerived         = K_Bool | K_Byte | K_Char | K_Decimal | K_Double | K_Float | K_Half | K_Int | K_Int128
                        | K_Long | K_Nint | K_Nuint | K_Sbyte | K_Short | K_String | K_Type | K_Uint | K_UInt128
                        | K_Ulong | K_Ushort,

    /// <summary>
    /// Identifies well-known types primarily used to provide text values.
    /// </summary>
    Text                = K_Char | K_String,

    /// <summary>
    /// Identifies well-known types with delegate values.
    /// </summary>
    /// <seealso cref="K_Delegate{T}"/>
    /// <seealso cref="K_MulticastDelegate{T}"/>
    Delegate            = K_Delegate | K_MulticastDelegate,

    /// <summary>
    /// Identifies well-known types with collections of values, such as an array or
    /// <see href="https://learn.microsoft.com/dotnet/api/system.readonlymemory-1">
    /// ReadOnlyMemory&lt;T&gt;</see>.
    /// </summary>
    Collection          = K_Array | K_ReadOnlyMemory,

    /// <summary>
    /// Identifies all well-known types that provide numeric values.
    /// </summary>
    Number              = IntegerNumber | FloatingPointNumber,

    /// <summary>
    /// Identifies all well-known types that provide integer values.
    /// </summary>
    IntegerNumber       = K_Byte | K_Int | K_Int128 | K_Long | K_Nint | K_Nuint | K_Sbyte | K_Short | K_Uint
                        | K_UInt128 | K_Ulong | K_Ushort | K_Integer,

    /// <summary>
    /// Identifies all well-known types that provide floating-point values.
    /// </summary>
    FloatingPointNumber = K_Decimal | K_Double | K_Float | K_Half | K_FloatingPoint,

    /// <summary>
    /// Identifies all well-known types that provide signed numeric values.
    /// </summary>
    SignedNumber        = K_Decimal | K_Double | K_Float | K_Half | K_Int | K_Int128 | K_Long | K_Nint | K_Sbyte
                        | K_Short,

    /// <summary>
    /// Identifies all types that provide unsigned numeric values.
    /// </summary>
    UnsignedNumber      = K_Byte | K_Uint | K_UInt128 | K_Ulong | K_Ushort,

    /// <summary>
    /// Identifies all types that provide values of built-in C# data types.
    /// </summary>
    BuiltIn             = K_Bool | K_Byte | K_Char | K_Decimal | K_Double | K_Float | K_Int | K_Uint
                        | K_Nint | K_Nuint | K_Long | K_Ulong | K_Short | K_Ushort | K_String,

    /// <summary>
    /// Identifies all types that provide values that are primitives.
    /// </summary>
    Primitive          = K_Bool | K_Byte | K_Char | K_Decimal | K_Double | K_Float | K_Int | K_Uint
                       | K_Nint | K_Nuint | K_Long | K_Ulong | K_Short | K_Ushort,

    /// <summary>
    /// Identifies all types that provide values that are CLS-compliant.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///     <strong>NOTE:</strong> Other types, such as arrays, may be CLS-compliant if they do not target any
    ///     types that are not CLS-compliant.
    ///     </para>
    /// </remarks>
    ClsCompliant        = K_Bool | K_Byte | K_Char | K_Decimal | K_Double | K_Float | K_Half | K_Int | K_Nint
                        | K_Long | K_Short | K_String,

    /// <summary>
    /// Identifies all well-known types.
    /// </summary>
    All                 = MostDerived | Core,
}

/// <summary>
/// The <see cref="WellKnownConstTypesExtensions"/> class provides <see cref="WellKnownConstTypes"/>
/// extension methods.
/// </summary>
/// <seealso cref="WellKnownConstTypes"/>
public static class WellKnownConstTypesExtensions
{
    /// <summary>
    /// Returns whether or not this is a well-known type is a core const type
    /// <em>(i.e. a type contained in the ConstTypeArgs.Core library)</em>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is a core const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    public static bool IsWellKnownCoreType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.Core) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known most-derived const type, such as <c>K_Bool</c>, <c>K_Int</c>,
    /// or <c>K_String</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is a well-known most-derived const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    public static bool IsWellKnownMostDerivedType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.MostDerived) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known text-like const type, such as <c>K_Char</c> or <c>K_String</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is a well-known text-like const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownNumericType(WellKnownConstTypes)"/>
    public static bool IsWellKnownTextType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.Text) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known delegate const type, such as <c>K_Delegate</c>
    /// or <c>K_MultiCastDelegate</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known delegate const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    public static bool IsWellKnownDelegateType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.Delegate) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known collection const type, such as <c>K_Array</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known collection const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    public static bool IsWellKnownCollectionType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.Collection) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known numeric const type, such as <c>K_Byte</c>,
    /// <c>K_Int</c>, or <c>K_Ulong</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known numeric const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownTextType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownIntegerType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownFloatingPointType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownSignedType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownUnsignedType(WellKnownConstTypes)"/>
    public static bool IsWellKnownNumericType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.Number) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known integer numeric const type, such as <c>K_Int</c>
    /// or <c>K_Nuint</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is a well-known integer numeric const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownTextType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownNumericType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownFloatingPointType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownSignedType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownUnsignedType(WellKnownConstTypes)"/>
    public static bool IsWellKnownIntegerType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.IntegerNumber) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known floating point numeric const type,
    /// such as <c>K_Double</c> or <c>K_Decimal</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known floating point numeric const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownTextType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownNumericType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownIntegerType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownSignedType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownUnsignedType(WellKnownConstTypes)"/>
    public static bool IsWellKnownFloatingPointType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.FloatingPointNumber) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known signed numeric const type,
    /// such as <c>K_Sbyte</c>, <c>K_Short</c>, or <c>K_Int128</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known signed numeric const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownTextType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownNumericType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownIntegerType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownFloatingPointType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownUnsignedType(WellKnownConstTypes)"/>
    public static bool IsWellKnownSignedType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.SignedNumber) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known unsigned numeric const type,
    /// such as <c>K_Byte</c> or <c>K_Ushort</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known unsigned numeric const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownTextType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownNumericType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownFloatingPointType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownIntegerType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownSignedType(WellKnownConstTypes)"/>
    public static bool IsWellKnownUnsignedType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.UnsignedNumber) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known const type representing a built-in native type,
    /// such as <c>K_Char</c> or <c>K_String</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is a well-known type representing a built-in native type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownPrimitiveType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownClsCompliantType(WellKnownConstTypes)"/>
    public static bool IsWellKnownBuiltInType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.BuiltIn) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known primitive const type, such as
    /// <c>K_Bool</c> or <c>K_Nint</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is a well-known primitive const type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownBuiltInType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownClsCompliantType(WellKnownConstTypes)"/>
    public static bool IsWellKnownPrimitiveType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.Primitive) != WellKnownConstTypes.None;

    /// <summary>
    /// Returns whether or not this is a well-known const type representing a CLS-compliant type,
    /// such as <c>K_Short</c> or <c>K_String</c>.
    /// </summary>
    /// <param name="type">
    /// This object.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this is well-known const type representing a CLS-compliant type;
    /// a value of <see langword="false"/> if otherwise.
    /// </returns>
    /// <seealso cref="IsWellKnownBuiltInType(WellKnownConstTypes)"/>
    /// <seealso cref="IsWellKnownPrimitiveType(WellKnownConstTypes)"/>
    public static bool IsWellKnownClsCompliantType(this WellKnownConstTypes type)
        => (type & WellKnownConstTypes.ClsCompliant) != WellKnownConstTypes.None;
}
