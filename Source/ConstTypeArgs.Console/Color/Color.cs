using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Console.Color;

/// <summary>
/// The <see cref="K_ConsoleColor"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleColor&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</see> const type arguments
/// rather than <see cref="K_Enum{T}">K_Enum&lt;ConsoleColor&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleColor&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_ConsoleColor{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</seealso>
/// <seealso cref="ConsoleColor{K}"/>
/// <seealso cref="K_ConsoleColorArray"/>
/// <seealso cref="__"/>
public interface K_ConsoleColor : K_Enum<ConsoleColor>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ConsoleColor, IConstTypeArg<ConsoleColor>;
}

/// <summary>
/// The <see cref="K_ConsoleColor{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleColor, K_ConsoleColor&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_ConsoleColor"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</seealso>
/// <seealso cref="ConsoleColor{K}"/>
/// <seealso cref="K_ConsoleColorArray{TSelf}"/>
public interface K_ConsoleColor<TSelf> : K_ConsoleColor, IConstTypeArg<ConsoleColor, TSelf>
    where TSelf : K_ConsoleColor<TSelf>;

/// <summary>
/// The <see cref="K_ConsoleColorArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleColor[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor[]</see> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;ConsoleColor&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleColor[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_ConsoleColorArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</seealso>
/// <seealso cref="ConsoleColorArray{K}"/>
/// <seealso cref="K_ConsoleColor"/>
/// <seealso cref="__"/>
public interface K_ConsoleColorArray : K_Array<ConsoleColor>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ConsoleColorArray;
}

/// <summary>
/// The <see cref="K_ConsoleColorArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleColor[], K_ConsoleColorArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor[]</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_ConsoleColorArray"/> instead.
/// </remarks>
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</see>
/// <seealso cref="ConsoleColorArray{K}"/>
/// <seealso cref="K_ConsoleColor{TSelf}"/>
public interface K_ConsoleColorArray<TSelf> : K_ConsoleColorArray, IConstTypeArg<ConsoleColor[], TSelf>
    where TSelf : K_ConsoleColorArray<TSelf>;

/// <summary>
/// The <see cref="ConsoleColor{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_ConsoleColor"/>
/// <seealso cref="ConsoleColorArray{K}"/>
public abstract class ConsoleColor<K> : K<ConsoleColor, K>, K_ConsoleColor
    where K : K_ConsoleColor
{ public static ConsoleColor Value => K.Value; }

/// <summary>
/// The <see cref="ConsoleColorArray{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
/// System.ConsoleColor</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_ConsoleColorArray"/>
/// <seealso cref="ConsoleColor{K}"/>
public abstract class ConsoleColorArray<K> : K<ConsoleColor[], K>, K_ConsoleColorArray
    where K : K_ConsoleColorArray
{ public static ConsoleColor[] Value => K.Value; }
