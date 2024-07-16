using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Ulongs;

/// <summary>
/// The <see cref="K_Ulong"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="Ulong{K}"/>
/// <seealso cref="K_UlongArray"/>
public interface K_Ulong
    : K_Unmanaged<ulong>, K_Integer<ulong>, K_UnsignedNumber<ulong>;

/// <summary>
/// The <see cref="K_Ulong{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong, K_Ulong&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="Ulong{K}"/>
/// <seealso cref="K_UlongArray{TSelf}"/>
public interface K_Ulong<TSelf>
    : K_Ulong, IConstTypeArg<ulong, TSelf>
    where TSelf : K_Ulong<TSelf>;

/// <summary>
/// The <see cref="K_UlongArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="UlongArray{K}"/>
/// <seealso cref="K_Ulong"/>
public interface K_UlongArray
    : K_Array<ulong>;

/// <summary>
/// The <see cref="K_UlongArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong[], K_UlongArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="UlongArray{K}"/>
/// <seealso cref="K_Ulong{TSelf}"/>
public interface K_UlongArray<TSelf>
    : K_UlongArray, IConstTypeArg<ulong[], TSelf>
    where TSelf : K_UlongArray<TSelf>;

/// <summary>
/// The <see cref="Ulong{K}"/> class provides a const argument provider that
/// wraps the <see langword="ulong"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="UlongArray{K}"/>
/// <seealso cref="K_Ulong"/>
/// <seealso cref="K_Ulong{TSelf}"/>
public class Ulong<K> : K<ulong, K>, K_Ulong
    where K : K_Ulong
{ public static ulong Value => K.Value; }

/// <summary>
/// The <see cref="UlongArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="ulong"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Ulong{K}"/>
/// <seealso cref="K_Ulong"/>
public class UlongArray<K> : K<ulong[], K>, K_UlongArray
    where K : K_UlongArray
{ public static ulong[] Value => K.Value; }
