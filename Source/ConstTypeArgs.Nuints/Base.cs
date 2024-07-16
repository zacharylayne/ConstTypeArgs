using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Nuints;

/// <summary>
/// The <see cref="K_Nuint"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="Nuint{K}"/>
/// <seealso cref="K_NuintArray"/>
public interface K_Nuint
    : K_Unmanaged<nuint>, K_Integer<nuint>, K_UnsignedNumber<nuint>;

/// <summary>
/// The <see cref="K_Nuint{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint, KNuint&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="Nuint{K}"/>
/// <seealso cref="K_NuintArray{TSelf}"/>
public interface K_Nuint<TSelf>
    : K_Nuint, IConstTypeArg<nuint, TSelf>
    where TSelf : K_Nuint<TSelf>;

/// <summary>
/// The <see cref="K_NuintArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="NuintArray{K}"/>
/// <seealso cref="K_Nuint"/>
public interface K_NuintArray
    : K_Array<nuint>;

/// <summary>
/// The <see cref="K_NuintArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint[], K_NuintArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="NuintArray{K}"/>
/// <seealso cref="K_Nuint{TSelf}"/>
public interface K_NuintArray<TSelf>
    : K_NuintArray, IConstTypeArg<nuint[], TSelf>
    where TSelf : K_NuintArray<TSelf>;

/// <summary>
/// The <see cref="Nuint{K}"/> class provides a const argument provider that
/// wraps the <see langword="nuint"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="NuintArray{K}"/>
/// <seealso cref="K_Nuint"/>
/// <seealso cref="K_Nuint{TSelf}"/>
public class Nuint<K> : K<nuint, K>, K_Nuint
    where K : K_Nuint
{ public static nuint Value => K.Value; }

/// <summary>
/// The <see cref="NuintArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="nuint"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Nuint{K}"/>
/// <seealso cref="K_Nuint"/>
public class NuintArray<K> : K<nuint[], K>, K_NuintArray
    where K : K_NuintArray
{ public static nuint[] Value => K.Value; }
