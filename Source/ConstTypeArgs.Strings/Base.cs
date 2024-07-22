using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Strings;

/// <summary>
/// The <see cref="K_String"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="string"/> const type arguments
/// rather than <see cref="K_Class{T}">K_Class&lt;string&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;string&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_String{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="String{K}"/>
/// <seealso cref="K_StringArray"/>
/// <seealso cref="__"/>
public interface K_String : K_Class<string>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_String, IConstTypeArg<string>;
}

/// <summary>
/// The <see cref="K_String{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string, K_String&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="string"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_String"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="String{K}"/>
/// <seealso cref="K_StringArray{TSelf}"/>
public interface K_String<TSelf> : K_String, IConstTypeArg<string, TSelf>
    where TSelf : K_String<TSelf>;

/// <summary>
/// The <see cref="K_StringArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="string[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;string&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;string[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_StringArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="StringArray{K}"/>
/// <seealso cref="K_String"/>
/// <seealso cref="__"/>
public interface K_StringArray : K_Array<string>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_StringArray;
}

/// <summary>
/// The <see cref="K_StringArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string[], K_StringArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="string[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_StringArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="StringArray{K}"/>
/// <seealso cref="K_String{TSelf}"/>
public interface K_StringArray<TSelf> : K_StringArray, IConstTypeArg<string[], TSelf>
    where TSelf : K_StringArray<TSelf>;

/// <summary>
/// The <see cref="String{K}"/> class provides a const argument provider that
/// wraps the <see langword="string"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_String"/>
/// <seealso cref="StringArray{K}"/>
public abstract class String<K> : K<string, K>, K_String
    where K : K_String
{ public static string Value => K.Value; }

/// <summary>
/// The <see cref="StringArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="string"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_StringArray"/>
/// <seealso cref="String{K}"/>
public abstract class StringArray<K> : K<string[], K>, K_StringArray
    where K : K_StringArray
{ public static string[] Value => K.Value; }
