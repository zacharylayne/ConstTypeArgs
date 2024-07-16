using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Int128s;

/// <summary>
/// The <see cref="K_Int128"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// Int128</seealso>
/// <seealso cref="Int128{K}"/>
/// <seealso cref="K_Int128Array"/>
public interface K_Int128
    : K_Unmanaged<Int128>, K_Integer<Int128>, K_SignedNumber<Int128>;

/// <summary>
/// The <see cref="K_Int128{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128, K_Int128&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// Int128</seealso>
/// <seealso cref="Int128{K}"/>
/// <seealso cref="K_Int128Array{TSelf}"/>
public interface K_Int128<TSelf>
    : K_Int128, IConstTypeArg<Int128, TSelf>
    where TSelf : K_Int128<TSelf>;

/// <summary>
/// The <see cref="K_Int128Array"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// Int128</seealso>
/// <seealso cref="Int128Array{K}"/>
/// <seealso cref="K_Int128"/>
public interface K_Int128Array
    : K_Array<Int128>;

/// <summary>
/// The <see cref="K_Int128Array{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128[], K_Int128Array&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// Int128</seealso>
/// <seealso cref="Int128Array{K}"/>
/// <seealso cref="K_Int128{TSelf}"/>
public interface K_Int128Array<TSelf>
    : K_Int128Array, IConstTypeArg<Int128[], TSelf>
    where TSelf : K_Int128Array<TSelf>;

/// <summary>
/// The <see cref="Int128{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.Int128">
/// System.Int128</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Int128"/>
/// <seealso cref="K_Int128{TSelf}"/>
/// <seealso cref="Int128Array{K}"/>
public class Int128<K> : K<Int128, K>, K_Int128
    where K : K_Int128
{ public static Int128 Value => K.Value; }

/// <summary>
/// The <see cref="Int128Array{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.Int128">
/// System.Int128</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Int128"/>
/// <seealso cref="Int128{K}"/>
public class Int128Array<K> : K<Int128[], K>, K_Int128Array
    where K : K_Int128Array
{ public static Int128[] Value => K.Value; }
