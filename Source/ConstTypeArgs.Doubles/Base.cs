using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Doubles;

/// <summary>
/// The <see cref="K_Double"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="double"/> const type arguments
/// rather than <see cref="K_Unmanaged{T}">K_Unmanaged&lt;double&gt;</see>,
/// <see cref="K_FloatingPoint{T}">K_FloatingPoint&lt;double&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_SignedNumber&lt;double&gt;</see>,
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;double&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Double{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.double">
/// System.Double</seealso>
/// <seealso cref="Double{K}"/>
/// <seealso cref="K_DoubleArray"/>
/// <seealso cref="__"/>
public interface K_Double
    : K_Unmanaged<double>, K_FloatingPoint<double>, K_SignedNumber<double>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Double, IConstTypeArg<double?>;
}

/// <summary>
/// The <see cref="K_Double{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double, K_Double&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="double"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Double"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.double">
/// System.Double</seealso>
/// <seealso cref="Double{K}"/>
/// <seealso cref="K_DoubleArray{TSelf}"/>
public interface K_Double<TSelf> : K_Double, IConstTypeArg<double, TSelf>
    where TSelf : K_Double<TSelf>;

/// <summary>
/// The <see cref="K_DoubleArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="double[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;double&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;double[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_DoubleArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.double">
/// System.Double</seealso>
/// <seealso cref="DoubleArray{K}"/>
/// <seealso cref="K_Double"/>
/// <seealso cref="__"/>
public interface K_DoubleArray : K_Array<double>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_DoubleArray;
}

/// <summary>
/// The <see cref="K_DoubleArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double[], K_DoubleArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="double[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_DoubleArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.double">
/// System.Double</seealso>
/// <seealso cref="DoubleArray{K}"/>
/// <seealso cref="K_Double{TSelf}"/>
public interface K_DoubleArray<TSelf> : K_DoubleArray, IConstTypeArg<double[], TSelf>
    where TSelf : K_DoubleArray<TSelf>;

/// <summary>
/// The <see cref="Double{K}"/> class provides a const argument provider that
/// wraps the <see langword="double"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Double"/>
/// <seealso cref="DoubleArray{K}"/>
public abstract class Double<K> : K<double, K>, K_Double
    where K : K_Double
{ public static double Value => K.Value; }

/// <summary>
/// The <see cref="DoubleArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="double"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_DoubleArray"/>
/// <seealso cref="Double{K}"/>
public abstract class DoubleArray<K> : K<double[], K>, K_DoubleArray
    where K : K_DoubleArray
{ public static double[] Value => K.Value; }
