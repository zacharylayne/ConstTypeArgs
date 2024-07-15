using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Sbytes;

/// <summary>
/// The <see cref="K_Sbyte"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="Sbyte{K}"/>
/// <seealso cref="K_SbyteArray"/>
public interface K_Sbyte
    : K_Unmanaged<sbyte>, K_Integer<sbyte>, K_SignedNumber<sbyte>;

/// <summary>
/// The <see cref="K_Sbyte{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte, K_Sbyte&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="Sbyte{K}"/>
/// <seealso cref="K_SbyteArray{TSelf}"/>
public interface K_Sbyte<TSelf>
    : K_Sbyte, IConstTypeArg<sbyte, TSelf>
    where TSelf : K_Sbyte<TSelf>;

/// <summary>
/// The <see cref="K_SbyteArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="SbyteArray{K}"/>
/// <seealso cref="K_Sbyte"/>
public interface K_SbyteArray
    : K_Array<sbyte>;

/// <summary>
/// The <see cref="K_SbyteArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte[], K_SbyteArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="SbyteArray{K}"/>
/// <seealso cref="K_Sbyte{TSelf}"/>
public interface K_SbyteArray<TSelf>
    : K_SbyteArray, IConstTypeArg<sbyte[], TSelf>
    where TSelf : K_SbyteArray<TSelf>;

/// <summary>
/// The <see cref="Sbyte{K}"/> class provides a const argument provider that
/// wraps the <see langword="sbyte"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="SbyteArray{K}"/>
/// <seealso cref="K_Sbyte"/>
/// <seealso cref="K_Sbyte{TSelf}"/>
public class Sbyte<K> : K<sbyte, K>, K_Sbyte
    where K : K_Sbyte
{ public static sbyte Value => K.Value; }

/// <summary>
/// The <see cref="SbyteArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="sbyte"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Sbyte{K}"/>
/// <seealso cref="K_Sbyte"/>
public class SbyteArray<K> : K<sbyte[], K>, K_SbyteArray
    where K : K_SbyteArray
{ public static sbyte[] Value => K.Value; }
