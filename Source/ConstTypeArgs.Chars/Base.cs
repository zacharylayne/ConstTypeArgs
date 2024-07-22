using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Chars;

/// <summary>
/// The <see cref="K_Char"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="char"/> const type arguments
/// rather than <see cref="K_Unmanaged{T}">K_Unmanaged&lt;char&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;char&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Char{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="Char{K}"/>
/// <seealso cref="K_CharArray"/>
/// <seealso cref="__"/>
public interface K_Char : K_Unmanaged<char>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Char, IConstTypeArg<char?>;
}

/// <summary>
/// The <see cref="K_Char{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char, K_Char&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="char"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Char"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="Char{K}"/>
/// <seealso cref="K_CharArray{TSelf}"/>
public interface K_Char<TSelf> : K_Char, IConstTypeArg<char, TSelf>
    where TSelf : K_Char<TSelf>;

/// <summary>
/// The <see cref="K_CharArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="char[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;char&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;char[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_CharArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="CharArray{K}"/>
/// <seealso cref="K_Char"/>
/// <seealso cref="__"/>
public interface K_CharArray : K_Array<char>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_CharArray;
}

/// <summary>
/// The <see cref="K_CharArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char[], K_CharArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="char[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_CharArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="CharArray{K}"/>
/// <seealso cref="K_Char{TSelf}"/>
public interface K_CharArray<TSelf> : K_CharArray, IConstTypeArg<char[], TSelf>
    where TSelf : K_CharArray<TSelf>;

/// <summary>
/// The <see cref="Char{K}"/> class provides a const argument provider that
/// wraps the <see langword="char"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Char"/>
/// <seealso cref="CharArray{K}"/>
public abstract class Char<K> : K<char, K>, K_Char
    where K : K_Char
{ public static char Value => K.Value; }

/// <summary>
/// The <see cref="CharArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="char"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_CharArray"/>
/// <seealso cref="Char{K}"/>
public abstract class CharArray<K> : K<char[], K>, K_CharArray
    where K : K_CharArray
{ public static char[] Value => K.Value; }
