using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Strings;

/// <summary>
/// The <see cref="K_String"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="String{K}"/>
/// <seealso cref="K_StringArray"/>
public interface K_String
    : K_Class<string>;

/// <summary>
/// The <see cref="K_String{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string, K_String&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="String{K}"/>
/// <seealso cref="K_StringArray{TSelf}"/>
public interface K_String<TSelf>
    : K_String, IConstTypeArg<string, TSelf>
    where TSelf : K_String<TSelf>;

/// <summary>
/// The <see cref="K_StringArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="StringArray{K}"/>
/// <seealso cref="K_String"/>
public interface K_StringArray
    : K_Array<string>;

/// <summary>
/// The <see cref="K_StringArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;string[], K_StringArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.string">
/// System.String</seealso>
/// <seealso cref="StringArray{K}"/>
/// <seealso cref="K_String{TSelf}"/>
public interface K_StringArray<TSelf>
    : K_StringArray, IConstTypeArg<string[], TSelf>
    where TSelf : K_StringArray<TSelf>;

/// <summary>
/// The <see cref="String{K}"/> class provides a const argument provider that
/// wraps the <see langword="string"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="StringArray{K}"/>
/// <seealso cref="K_String"/>
/// <seealso cref="K_String{TSelf}"/>
public class String<K> : K<string, K>, K_String
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
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="String{K}"/>
/// <seealso cref="K_String"/>
public class StringArray<K> : K<string[], K>, K_StringArray
    where K : K_StringArray
{ public static string[] Value => K.Value; }
