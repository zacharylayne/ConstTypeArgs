using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Decimals;

/// <summary>
/// The <see cref="K_Decimal"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal&gt;</c> derived type.
/// </summary>
/// <seealso cref="Decimal{K}"/>
/// <seealso cref="K_DecimalArray"/>
public interface K_Decimal
    : K_Unmanaged<decimal>, K_FloatingPoint<decimal>, K_SignedNumber<decimal>;

/// <summary>
/// The <see cref="K_Decimal{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal, K_Decimal&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso cref="Decimal{K}"/>
/// <seealso cref="K_DecimalArray{TSelf}"/>
public interface K_Decimal<TSelf>
    : K_Decimal, IConstTypeArg<decimal, TSelf>
    where TSelf : K_Decimal<TSelf>;

/// <summary>
/// The <see cref="K_DecimalArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal[]&gt;</c> type.
/// </summary>
/// <seealso cref="DecimalArray{K}"/>
/// <seealso cref="K_Decimal"/>
public interface K_DecimalArray
    : K_Array<decimal>;

/// <summary>
/// The <see cref="K_DecimalArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;decimal[], K_DecimalArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso cref="DecimalArray{K}"/>
/// <seealso cref="K_Decimal{TSelf}"/>
public interface K_DecimalArray<TSelf>
    : K_DecimalArray, IConstTypeArg<decimal[], TSelf>
    where TSelf : K_DecimalArray<TSelf>;

/// <summary>
/// The <see cref="Decimal{K}"/> class provides a const argument provider that
/// wraps the <see langword="decimal"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="DecimalArray{K}"/>
/// <seealso cref="K_Decimal"/>
/// <seealso cref="K_Decimal{TSelf}"/>
public class Decimal<K> : K<decimal, K>, K_Decimal
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
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Decimal{K}"/>
/// <seealso cref="K_Decimal"/>
public class DecimalArray<K> : K<decimal[], K>, K_DecimalArray
    where K : K_DecimalArray
{ public static decimal[] Value => K.Value; }
