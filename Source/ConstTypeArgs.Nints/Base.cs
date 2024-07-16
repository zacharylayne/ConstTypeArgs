using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Nints;

/// <summary>
/// The <see cref="K_Nint"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="Nint{K}"/>
/// <seealso cref="K_NintArray"/>
public interface K_Nint
    : K_Unmanaged<nint>, K_Integer<nint>, K_SignedNumber<nint>;

/// <summary>
/// The <see cref="K_Nint{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint, K_Nint&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="Nint{K}"/>
/// <seealso cref="K_NintArray{TSelf}"/>
public interface K_Nint<TSelf>
    : K_Nint, IConstTypeArg<nint, TSelf>
    where TSelf : K_Nint<TSelf>;

/// <summary>
/// The <see cref="K_NintArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="NintArray{K}"/>
/// <seealso cref="K_Nint"/>
public interface K_NintArray
    : K_Array<nint>;

/// <summary>
/// The <see cref="K_NintArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint[], K_NintArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="NintArray{K}"/>
/// <seealso cref="K_Nint{TSelf}"/>
public interface K_NintArray<TSelf>
    : K_NintArray, IConstTypeArg<nint[], TSelf>
    where TSelf : K_NintArray<TSelf>;

/// <summary>
/// The <see cref="Nint{K}"/> class provides a const argument provider that
/// wraps the <see langword="nint"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Nint"/>
/// <seealso cref="K_Nint{TSelf}"/>
/// <seealso cref="NintArray{K}"/>
public class Nint<K> : K<nint, K>, K_Nint
    where K : K_Nint
{ public static nint Value => K.Value; }

/// <summary>
/// The <see cref="Nint{KNint}"/> class provides a const argument provider that
/// wraps the <see langword="nint"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Nint"/>
/// <seealso cref="Nint{K}"/>
public class NintArray<K> : K<nint[], K>, K_NintArray
    where K : K_NintArray
{ public static nint[] Value => K.Value; }
