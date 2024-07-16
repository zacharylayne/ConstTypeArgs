using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Doubles;

/// <summary>
/// The <see cref="K_Double"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double&gt;</c> derived type.
/// </summary>
/// <seealso cref="Double{K}"/>
/// <seealso cref="K_DoubleArray"/>
public interface K_Double
    : K_Unmanaged<double>, K_FloatingPoint<double>, K_SignedNumber<double>;

/// <summary>
/// The <see cref="K_Double{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double, K_Double&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso cref="Double{K}"/>
/// <seealso cref="K_DoubleArray{TSelf}"/>
public interface K_Double<TSelf>
    : K_Double, IConstTypeArg<double, TSelf>
    where TSelf : K_Double<TSelf>;

/// <summary>
/// The <see cref="K_DoubleArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double[]&gt;</c> type.
/// </summary>
/// <seealso cref="DoubleArray{K}"/>
/// <seealso cref="K_Double"/>
public interface K_DoubleArray
    : K_Array<double>;

/// <summary>
/// The <see cref="K_DoubleArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;double[], K_DoubleArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso cref="DoubleArray{K}"/>
/// <seealso cref="K_Double{TSelf}"/>
public interface K_DoubleArray<TSelf>
    : K_DoubleArray, IConstTypeArg<double[], TSelf>
    where TSelf : K_DoubleArray<TSelf>;

/// <summary>
/// The <see cref="Double{K}"/> class provides a const argument provider that
/// wraps the <see langword="double"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="DoubleArray{K}"/>
/// <seealso cref="K_Double"/>
/// <seealso cref="K_Double{TSelf}"/>
public class Double<K> : K<double, K>, K_Double
    where K : K_Double
{ public static double Value => K.Value; }

/// <summary>
/// The <see cref="DoubleArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="Double"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Double{K}"/>
/// <seealso cref="K_Double"/>
public class DoubleArray<K> : K<double[], K>, K_DoubleArray
    where K : K_DoubleArray
{ public static double[] Value => K.Value; }
