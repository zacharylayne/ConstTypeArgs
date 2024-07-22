using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Console.Key;

/// <summary>
/// The <see cref="K_Key"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleKey&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</see> const type arguments
/// rather than <see cref="K_Enum{T}">K_Enum&lt;ConsoleKey&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleKey&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Key{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</seealso>
/// <seealso cref="Keys"/>
/// <seealso cref="Key{K}"/>
/// <seealso cref="K_KeyArray"/>
/// <seealso cref="__"/>
public interface K_Key : K_Enum<ConsoleKey>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Key, IConstTypeArg<ConsoleKey>;
}

/// <summary>
/// The <see cref="K_Key{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleKey, K_ConsoleKey&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Key"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</seealso>
/// <seealso cref="Keys"/>
/// <seealso cref="Key{K}"/>
/// <seealso cref="K_KeyArray{TSelf}"/>
public interface K_Key<TSelf> : K_Key, IConstTypeArg<ConsoleKey, TSelf>
    where TSelf : K_Key<TSelf>;

/// <summary>
/// The <see cref="K_KeyArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleKey[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey[]</see> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;ConsoleKey&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleKey[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_KeyArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</seealso>
/// <seealso cref="Keys"/>
/// <seealso cref="KeyArray{K}"/>
/// <seealso cref="K_Key"/>
/// <seealso cref="__"/>
public interface K_KeyArray : K_Array<ConsoleKey>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_KeyArray;
}

/// <summary>
/// The <see cref="K_KeyArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleKey[], K_ConsoleKeyArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey[]</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_KeyArray"/> instead.
/// </remarks>
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</see>
/// <seealso cref="Keys"/>
/// <seealso cref="KeyArray{K}"/>
/// <seealso cref="K_Key{TSelf}"/>
public interface K_KeyArray<TSelf> : K_KeyArray, IConstTypeArg<ConsoleKey[], TSelf>
    where TSelf : K_KeyArray<TSelf>;

/// <summary>
/// The <see cref="Key{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="Keys"/>
/// <seealso cref="K_Key"/>
/// <seealso cref="KeyArray{K}"/>
public abstract class Key<K> : K<ConsoleKey, K>, K_Key
    where K : K_Key
{ public static ConsoleKey Value => K.Value; }

/// <summary>
/// The <see cref="KeyArray{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">
/// System.ConsoleKey</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="Keys"/>
/// <seealso cref="K_KeyArray"/>
/// <seealso cref="Key{K}"/>
public abstract class KeyArray<K> : K<ConsoleKey[], K>, K_KeyArray
    where K : K_KeyArray
{ public static ConsoleKey[] Value => K.Value; }
