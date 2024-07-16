using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Halfs;

/// <summary>
/// The <see cref="K_Half"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="Half{K}"/>
/// <seealso cref="K_HalfArray"/>
public interface K_Half
    : K_Unmanaged<Half>, K_FloatingPoint<Half>, K_SignedNumber<Half>;

/// <summary>
/// The <see cref="K_Half{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half, K_Half&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="Half{K}"/>
/// <seealso cref="K_HalfArray{TSelf}"/>
public interface K_Half<TSelf>
    : K_Half, IConstTypeArg<Half, TSelf>
    where TSelf : K_Half<TSelf>;

/// <summary>
/// The <see cref="K_HalfArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="HalfArray{K}"/>
/// <seealso cref="K_Half"/>
public interface K_HalfArray
    : K_Array<Half>;

/// <summary>
/// The <see cref="K_HalfArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half[], K_HalfArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="HalfArray{K}"/>
/// <seealso cref="K_Half{TSelf}"/>
public interface K_HalfArray<TSelf>
    : K_HalfArray, IConstTypeArg<Half[], TSelf>
    where TSelf : K_HalfArray<TSelf>;

/// <summary>
/// The <see cref="Half{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Half"/>
/// <seealso cref="K_Half{TSelf}"/>
/// <seealso cref="HalfArray{K}"/>
public class Half<K> : K<Half, K>, K_Half
    where K : K_Half
{ public static Half Value => K.Value; }

/// <summary>
/// The <see cref="HalfArray{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Half"/>
/// <seealso cref="Half{K}"/>
public class HalfArray<K> : K<Half[], K>, K_HalfArray
    where K : K_HalfArray
{ public static Half[] Value => K.Value; }
