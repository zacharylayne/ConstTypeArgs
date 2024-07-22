using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Bools;

/// <summary>
/// The <see cref="K_Bool"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="bool"/> const type arguments
/// rather than <see cref="K_Unmanaged{T}">K_Unmanaged&lt;bool&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstType&lt;bool&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Bool{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="Bool{K}"/>
/// <seealso cref="K_BoolArray"/>
/// <seealso cref="__"/>
public interface K_Bool : K_Unmanaged<bool>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Bool, IConstTypeArg<bool?>;
}

/// <summary>
/// The <see cref="K_Bool{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool, K_Bool&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="bool"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Bool"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="Bool{K}"/>
/// <seealso cref="K_BoolArray{TSelf}"/>
public interface K_Bool<TSelf> : K_Bool, IConstTypeArg<bool, TSelf>
    where TSelf : K_Bool<TSelf>;

/// <summary>
/// The <see cref="K_BoolArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="bool[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;bool&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;bool[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_BoolArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="BoolArray{K}"/>
/// <seealso cref="K_Bool"/>
/// <seealso cref="__"/>
public interface K_BoolArray : K_Array<bool>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_BoolArray;
}

/// <summary>
/// The <see cref="K_BoolArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool[], K_BoolArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="bool[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_BoolArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="BoolArray{K}"/>
/// <seealso cref="K_Bool{TSelf}"/>
public interface K_BoolArray<TSelf> : K_BoolArray, IConstTypeArg<bool[], TSelf>
    where TSelf : K_BoolArray<TSelf>;

/// <summary>
/// The <see cref="Bool{K}"/> class provides a const argument provider that
/// wraps the <see langword="bool"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Bool"/>
/// <seealso cref="BoolArray{K}"/>
public abstract class Bool<K> : K<bool, K>, K_Bool
    where K : K_Bool
{ public static bool Value => K.Value; }

/// <summary>
/// The <see cref="BoolArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="bool"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_BoolArray"/>
/// <seealso cref="Bool{K}"/>
public abstract class BoolArray<K> : K<bool[], K>, K_BoolArray
    where K : K_BoolArray
{ public static bool[] Value => K.Value; }
