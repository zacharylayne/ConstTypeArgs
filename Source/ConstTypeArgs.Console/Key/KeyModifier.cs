using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Console.Key;

/// <summary>
/// The <see cref="K_KeyModifier"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleModifiers&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</see> const type arguments
/// rather than <see cref="K_Enum{T}">K_Enum&lt;ConsoleModifiers&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleModifiers&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_KeyModifier{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</seealso>
/// <seealso cref="KeyModifiers"/>
/// <seealso cref="KeyModifier{K}"/>
/// <seealso cref="K_KeyModifierArray"/>
/// <seealso cref="__"/>
public interface K_KeyModifier : K_Enum<ConsoleModifiers>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_KeyModifier, IConstTypeArg<ConsoleModifiers>;
}

/// <summary>
/// The <see cref="K_KeyModifier{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleModifiers, K_ConsoleModifiers&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// /// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_KeyModifier"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</seealso>
/// <seealso cref="KeyModifiers"/>
/// <seealso cref="KeyModifier{K}"/>
/// <seealso cref="K_KeyModifierArray{TSelf}"/>
public interface K_KeyModifier<TSelf> : K_KeyModifier, IConstTypeArg<ConsoleModifiers, TSelf>
    where TSelf : K_KeyModifier<TSelf>;

/// <summary>
/// The <see cref="K_KeyModifierArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleModifiers[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers[]</see> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;ConsoleModifiers&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleModifiers[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_KeyModifierArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</seealso>
/// <seealso cref="KeyModifierArray{K}"/>
/// <seealso cref="K_KeyModifier"/>
/// <seealso cref="__"/>
public interface K_KeyModifierArray : K_Array<ConsoleModifiers>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_KeyModifierArray;
}

/// <summary>
/// The <see cref="K_KeyModifierArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleModifiers[], K_ConsoleModifiersArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers[]</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_KeyModifierArray"/> instead.
/// </remarks>
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</see>
/// <seealso cref="KeyModifiers"/>
/// <seealso cref="KeyModifierArray{K}"/>
/// <seealso cref="K_KeyModifier{TSelf}"/>
public interface K_KeyModifierArray<TSelf> : K_KeyModifierArray, IConstTypeArg<ConsoleModifiers[], TSelf>
    where TSelf : K_KeyModifierArray<TSelf>;

/// <summary>
/// The <see cref="KeyModifier{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="KeyModifiers"/>
/// <seealso cref="K_KeyModifier"/>
/// <seealso cref="KeyModifierArray{K}"/>
public abstract class KeyModifier<K> : K<ConsoleModifiers, K>, K_KeyModifier
    where K : K_KeyModifier
{ public static ConsoleModifiers Value => K.Value; }

/// <summary>
/// The <see cref="KeyModifierArray{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</see> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="KeyModifiers"/>
/// <seealso cref="K_KeyModifierArray"/>
/// <seealso cref="KeyModifier{K}"/>
public abstract class KeyModifierArray<K> : K<ConsoleModifiers[], K>, K_KeyModifierArray
    where K : K_KeyModifierArray
{ public static ConsoleModifiers[] Value => K.Value; }
