using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Shorts;

/// <summary>
/// The <see cref="K_Short"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;short&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int16">
/// System.Int16</seealso>
/// <seealso cref="Short{K}"/>
/// <seealso cref="K_ShortArray"/>
/// <seealso cref="__"/>
public interface K_Short
    : K_Unmanaged<short>, K_Integer<short>, K_SignedNumber<short>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Short, IConstTypeArg<short?>;
}

/// <summary>
/// The <see cref="K_Short{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;short, K_Short&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int16">
/// System.Int16</seealso>
/// <seealso cref="Short{K}"/>
/// <seealso cref="K_ShortArray{TSelf}"/>
public interface K_Short<TSelf>
    : K_Short, IConstTypeArg<short, TSelf>
    where TSelf : K_Short<TSelf>;

/// <summary>
/// The <see cref="K_ShortArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;short[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int16">
/// System.Int16</seealso>
/// <seealso cref="ShortArray{K}"/>
/// <seealso cref="K_Short"/>
/// <seealso cref="__"/>
public interface K_ShortArray
    : K_Array<short>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ShortArray, IConstTypeArg<short[]>;
}

/// <summary>
/// The <see cref="K_ShortArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;short[], K_ShortArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int16">
/// System.Int16</seealso>
/// <seealso cref="ShortArray{K}"/>
/// <seealso cref="K_Short{TSelf}"/>
public interface K_ShortArray<TSelf>
    : K_ShortArray, IConstTypeArg<short[], TSelf>
    where TSelf : K_ShortArray<TSelf>;

/// <summary>
/// The <see cref="Short{K}"/> class provides a const argument provider that
/// wraps the <see langword="short"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="ShortArray{K}"/>
/// <seealso cref="K_Short"/>
/// <seealso cref="K_Short{TSelf}"/>
public class Short<K> : K<short, K>, K_Short
    where K : K_Short
{ public static short Value => K.Value; }

/// <summary>
/// The <see cref="ShortArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="short"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Short{K}"/>
/// <seealso cref="K_Short"/>
public class ShortArray<K> : K<short[], K>, K_ShortArray
    where K : K_ShortArray
{ public static short[] Value => K.Value; }
