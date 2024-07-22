using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Nuints;

/// <summary>
/// The <see cref="K_Nuint"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="nuint"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;nuint&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;nuint&gt;</see>,
/// <see cref="K_UnsignedNumber{T}">K_UnsignedNumber&lt;nuint&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;nuint&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Nuint{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="Nuint{K}"/>
/// <seealso cref="K_NuintArray"/>
/// <seealso cref="__"/>
public interface K_Nuint : K_Unmanaged<nuint>, K_Integer<nuint>, K_UnsignedNumber<nuint>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Nuint, IConstTypeArg<nuint?>;
}

/// <summary>
/// The <see cref="K_Nuint{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint, K_Nuint&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="nuint"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Nuint"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="Nuint{K}"/>
/// <seealso cref="K_NuintArray{TSelf}"/>
public interface K_Nuint<TSelf> : K_Nuint, IConstTypeArg<nuint, TSelf>
    where TSelf : K_Nuint<TSelf>;

/// <summary>
/// The <see cref="K_NuintArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="nuint[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;nuint&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;nuint[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_NuintArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="NuintArray{K}"/>
/// <seealso cref="K_Nuint"/>
/// <seealso cref="__"/>
public interface K_NuintArray : K_Array<nuint>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_NuintArray;
}

/// <summary>
/// The <see cref="K_NuintArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nuint[], K_NuintArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="nuint[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_NuintArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uintptr">
/// System.UIntPtr</seealso>
/// <seealso cref="NuintArray{K}"/>
/// <seealso cref="K_Nuint{TSelf}"/>
public interface K_NuintArray<TSelf> : K_NuintArray, IConstTypeArg<nuint[], TSelf>
    where TSelf : K_NuintArray<TSelf>;

/// <summary>
/// The <see cref="Nuint{K}"/> class provides a const argument provider that
/// wraps the <see langword="nuint"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Nuint"/>
/// <seealso cref="NuintArray{K}"/>
public abstract class Nuint<K> : K<nuint, K>, K_Nuint
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
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_NuintArray"/>
/// <seealso cref="Nuint{K}"/>
public abstract class NuintArray<K> : K<nuint[], K>, K_NuintArray
    where K : K_NuintArray
{ public static nuint[] Value => K.Value; }
