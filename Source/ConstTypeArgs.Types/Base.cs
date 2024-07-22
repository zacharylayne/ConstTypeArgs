using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Types;

/// <summary>
/// The <see cref="K_Type"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="Type"/> const type arguments
/// rather than <see cref="K_Class{T}">K_Class&lt;Type&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;Type&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Type{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="TypeArg{K}"/>
/// <seealso cref="K_TypeArray"/>
/// <seealso cref="__"/>
public interface K_Type : K_Class<Type>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Type, IConstTypeArg<Type>;
}

/// <summary>
/// The <see cref="K_Type{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type, K_Type&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="Type"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Type"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="TypeArg{K}"/>
/// <seealso cref="K_TypeArray{TSelf}"/>
public interface K_Type<TSelf> : K_Type, IConstTypeArg<Type, TSelf>
    where TSelf : K_Type<TSelf>;

/// <summary>
/// The <see cref="K_TypeArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="Type[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;Type&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;Type[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_TypeArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="TypeArray{K}"/>
/// <seealso cref="K_Type"/>
/// <seealso cref="__"/>
public interface K_TypeArray : K_Array<Type>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_TypeArray;
}

/// <summary>
/// The <see cref="K_TypeArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type[], K_TypeArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="Type[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_TypeArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="TypeArray{K}"/>
/// <seealso cref="K_Type{TSelf}"/>
public interface K_TypeArray<TSelf> : K_TypeArray, IConstTypeArg<Type[], TSelf>
    where TSelf : K_TypeArray<TSelf>;

/// <summary>
/// The <see cref="TypeArg{K}"/> class provides a const argument provider that
/// wraps the <see langword="Type"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Type"/>
/// <seealso cref="TypeArray{K}"/>
public abstract class TypeArg<K> : K<Type, K>, K_Type
    where K : K_Type
{ public static Type Value => K.Value; }

/// <summary>
/// The <see cref="TypeArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="Type"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_TypeArray"/>
/// <seealso cref="TypeArg{K}"/>
public abstract class TypeArray<K> : K<Type[], K>, K_TypeArray
    where K : K_TypeArray
{ public static Type[] Value => K.Value; }
