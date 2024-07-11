using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Chars;

/// <summary>
/// The <see cref="K_Char"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="Char{K}"/>
/// <seealso cref="K_CharArray"/>
public interface K_Char
    : K_Unmanaged<char>;

/// <summary>
/// The <see cref="K_Char{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char, K_Char&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="Char{K}"/>
/// <seealso cref="K_CharArray{TSelf}"/>
public interface K_Char<TSelf>
    : K_Char, IConstTypeArg<char, TSelf>
    where TSelf : K_Char<TSelf>;

/// <summary>
/// The <see cref="K_CharArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="CharArray{K}"/>
/// <seealso cref="K_Char"/>
public interface K_CharArray
    : K_Array<char>;

/// <summary>
/// The <see cref="K_CharArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;char[], K_CharArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.char">
/// System.Char</seealso>
/// <seealso cref="CharArray{K}"/>
/// <seealso cref="K_Char{TSelf}"/>
public interface K_CharArray<TSelf>
    : K_CharArray, IConstTypeArg<char[], TSelf>
    where TSelf : K_CharArray<TSelf>;

/// <summary>
/// The <see cref="Char{K}"/> class provides a const argument provider that
/// wraps the <see langword="char"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="CharArray{K}"/>
/// <seealso cref="K_Char"/>
/// <seealso cref="K_Char{TSelf}"/>
public class Char<K> : K<char, K>, K_Char
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
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Char{K}"/>
/// <seealso cref="K_Char"/>
public class CharArray<K> : K<char[], K>, K_CharArray
    where K : K_CharArray
{ public static char[] Value => K.Value; }
