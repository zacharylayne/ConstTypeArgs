using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Longs;

/// <summary>
/// The <see cref="K_Long"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="K_LongArray"/>
public interface K_Long
    : K_Unmanaged<long>, K_Integer<long>, K_SignedNumber<long>;

/// <summary>
/// The <see cref="K_Long{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long, K_Long&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="K_LongArray{TSelf}"/>
public interface K_Long<TSelf>
    : K_Long, IConstTypeArg<long, TSelf>
    where TSelf : K_Long<TSelf>;

/// <summary>
/// The <see cref="K_LongArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="K_Long"/>
public interface K_LongArray
    : K_Array<long>;

/// <summary>
/// The <see cref="K_LongArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long[], K_LongArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="K_Long{TSelf}"/>
public interface K_LongArray<TSelf>
    : K_LongArray, IConstTypeArg<long[], TSelf>
    where TSelf : K_LongArray<TSelf>;

/// <summary>
/// The <see cref="Long{K}"/> class provides a const argument provider that
/// wraps the <see langword="long"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Long"/>
/// <seealso cref="K_Long{TSelf}"/>
/// <seealso cref="LongArray{K}"/>
public class Long<K> : K<long, K>, K_Long
    where K : K_Long
{ public static long Value => K.Value; }

/// <summary>
/// The <see cref="LongArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="Long"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Long"/>
/// <seealso cref="Long{K}"/>
public class LongArray<K> : K<long[], K>, K_LongArray
    where K : K_LongArray
{ public static long[] Value => K.Value; }
