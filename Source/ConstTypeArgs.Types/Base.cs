using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Types;

/// <summary>
/// The <see cref="K_Type"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="Type{K}"/>
/// <seealso cref="K_TypeArray"/>
public interface K_Type
    : IConstTypeArg<Type>;

/// <summary>
/// The <see cref="K_Type{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type, K_Type&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="Type{K}"/>
/// <seealso cref="K_TypeArray{TSelf}"/>
public interface K_Type<TSelf>
    : K_Type, IConstTypeArg<Type, TSelf>
    where TSelf : K_Type<TSelf>;

/// <summary>
/// The <see cref="K_TypeArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="TypeArray{K}"/>
/// <seealso cref="K_Type"/>
public interface K_TypeArray
    : K_Array<Type>;

/// <summary>
/// The <see cref="K_TypeArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Type[], K_TypeArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.type">
/// System.Type</seealso>
/// <seealso cref="TypeArray{K}"/>
/// <seealso cref="K_Type{TSelf}"/>
public interface K_TypeArray<TSelf>
    : K_TypeArray, IConstTypeArg<Type[], TSelf>
    where TSelf : K_TypeArray<TSelf>;

/// <summary>
/// The <see cref="Type{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.Type">
/// System.Type</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Type"/>
/// <seealso cref="K_Type{TSelf}"/>
/// <seealso cref="TypeArray{K}"/>
public class Type<K> : K<Type, K>, K_Type
    where K : K_Type
{ public static Type Value => K.Value; }

/// <summary>
/// The <see cref="TypeArray{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.Type">
/// System.Type</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Type"/>
/// <seealso cref="Type{K}"/>
public class TypeArray<K> : K<Type[], K>, K_TypeArray
    where K : K_TypeArray
{ public static Type[] Value => K.Value; }
