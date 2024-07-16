using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.UInt128s;

/// <summary>
/// The <see cref="K_UInt128"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128{K}"/>
/// <seealso cref="K_UInt128Array"/>
public interface K_UInt128
    : K_Unmanaged<UInt128>, K_Integer<UInt128>, K_UnsignedNumber<UInt128>;

/// <summary>
/// The <see cref="K_UInt128{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128, K_UInt128&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128{K}"/>
/// <seealso cref="K_UInt128Array{TSelf}"/>
public interface K_UInt128<TSelf>
    : K_UInt128, IConstTypeArg<UInt128, TSelf>
    where TSelf : K_UInt128<TSelf>;

/// <summary>
/// The <see cref="K_UInt128Array"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128Array{K}"/>
/// <seealso cref="K_UInt128"/>
public interface K_UInt128Array
    : K_Array<UInt128>;

/// <summary>
/// The <see cref="K_UInt128Array{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;K_Uint128[], K_Uint128Array&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128Array{K}"/>
/// <seealso cref="K_UInt128{TSelf}"/>
public interface K_UInt128Array<TSelf>
    : K_UInt128Array, IConstTypeArg<UInt128[], TSelf>
    where TSelf : K_UInt128Array<TSelf>;

/// <summary>
/// The <see cref="UInt128{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.UInt128">
/// System.UInt128</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_UInt128"/>
/// <seealso cref="K_UInt128{TSelf}"/>
/// <seealso cref="UInt128Array{K}"/>
public class UInt128<K> : K<UInt128, K>, K_UInt128
    where K : K_UInt128
{ public static UInt128 Value => K.Value; }

/// <summary>
/// The <see cref="UInt128Array{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.UInt128">
/// System.UInt128</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_UInt128"/>
/// <seealso cref="UInt128{K}"/>
public class UInt128Array<K> : K<UInt128[], K>, K_UInt128Array
    where K : K_UInt128Array
{ public static UInt128[] Value => K.Value; }
