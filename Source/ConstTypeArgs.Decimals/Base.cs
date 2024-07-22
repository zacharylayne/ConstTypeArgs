using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Decimals;

/// <summary>
/// The <see cref="K_Decimal"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="decimal"/> const type arguments
/// rather than <see cref="K_Unmanaged{T}">K_Unmanaged&lt;decimal&gt;</see>,
/// <see cref="K_FloatingPoint{T}">K_FloatingPoint&lt;decimal&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_SignedNumber&lt;decimal&gt;</see>,
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;decimal&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Decimal{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.decimal">
/// System.Decimal</seealso>
/// <seealso cref="Decimal{K}"/>
/// <seealso cref="K_DecimalArray"/>
/// <seealso cref="__"/>
public interface K_Decimal
    : K_Unmanaged<decimal>, K_FloatingPoint<decimal>, K_SignedNumber<decimal>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Decimal, IConstTypeArg<decimal?>;
}

/// <summary>
/// The <see cref="K_Decimal{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal, K_Decimal&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="decimal"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Decimal"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.decimal">
/// System.Decimal</seealso>
/// <seealso cref="Decimal{K}"/>
/// <seealso cref="K_DecimalArray{TSelf}"/>
public interface K_Decimal<TSelf> : K_Decimal, IConstTypeArg<decimal, TSelf>
    where TSelf : K_Decimal<TSelf>;

/// <summary>
/// The <see cref="K_DecimalArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="decimal[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;decimal&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;decimal[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_DecimalArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.decimal">
/// System.Decimal</seealso>
/// <seealso cref="DecimalArray{K}"/>
/// <seealso cref="K_Decimal"/>
/// <seealso cref="__"/>
public interface K_DecimalArray : K_Array<decimal>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_DecimalArray;
}

/// <summary>
/// The <see cref="K_DecimalArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal[], K_DecimalArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="decimal[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_DecimalArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.decimal">
/// System.Decimal</seealso>
/// <seealso cref="DecimalArray{K}"/>
/// <seealso cref="K_Decimal{TSelf}"/>
public interface K_DecimalArray<TSelf> : K_DecimalArray, IConstTypeArg<decimal[], TSelf>
    where TSelf : K_DecimalArray<TSelf>;

/// <summary>
/// The <see cref="Decimal{K}"/> class provides a const argument provider that
/// wraps the <see langword="decimal"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Decimal"/>
/// <seealso cref="DecimalArray{K}"/>
public abstract class Decimal<K> : K<decimal, K>, K_Decimal
    where K : K_Decimal
{ public static decimal Value => K.Value; }

/// <summary>
/// The <see cref="DecimalArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="decimal"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_DecimalArray"/>
/// <seealso cref="Decimal{K}"/>
public abstract class DecimalArray<K> : K<decimal[], K>, K_DecimalArray
    where K : K_DecimalArray
{ public static decimal[] Value => K.Value; }
