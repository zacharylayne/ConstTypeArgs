using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Bools;

/// <summary>
/// The <see cref="K_Bool"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="Bool{K}"/>
/// <seealso cref="K_BoolArray"/>
public interface K_Bool
    : K_Unmanaged<bool>;

/// <summary>
/// The <see cref="K_Bool{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool, K_Bool&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="Bool{K}"/>
/// <seealso cref="K_BoolArray{TSelf}"/>
public interface K_Bool<TSelf>
    : K_Bool, IConstTypeArg<bool, TSelf>
    where TSelf : K_Bool<TSelf>;

/// <summary>
/// The <see cref="K_BoolArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="Bool{K}"/>
/// <seealso cref="K_Bool"/>
public interface K_BoolArray
    : K_Array<bool>;

/// <summary>
/// The <see cref="K_BoolArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;bool[], K_BoolArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.boolean">
/// System.Boolean</seealso>
/// <seealso cref="BoolArray{K}"/>
/// <seealso cref="K_Bool{TSelf}"/>
public interface K_BoolArray<TSelf>
    : K_BoolArray, IConstTypeArg<bool[], TSelf>
    where TSelf : K_BoolArray<TSelf>;

/// <summary>
/// The <see cref="Bool{K}"/> class provides a const argument provider that
/// wraps the <see langword="bool"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="BoolArray{K}"/>
/// <seealso cref="K_Bool"/>
/// <seealso cref="K_Bool{TSelf}"/>
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
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Bool{K}"/>
/// <seealso cref="K_Bool"/>
public abstract class BoolArray<K> : K<bool[], K>, K_BoolArray
    where K : K_BoolArray
{ public static bool[] Value => K.Value; }
