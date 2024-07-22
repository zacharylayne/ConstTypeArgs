using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Console.Key;

/// <summary>
/// The <see cref="K_SpecialKey"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleSpecialKey&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
/// System.ConsoleSpecialKey</see> const type arguments
/// rather than <see cref="K_Enum{T}">K_Enum&lt;ConsoleSpecialKey&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ConsoleSpecialKey&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_SpecialKey{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
/// System.ConsoleSpecialKey</seealso>
/// <seealso cref="SpecialKey{K}"/>
/// <seealso cref="__"/>
public interface K_SpecialKey : K_Enum<ConsoleSpecialKey>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_SpecialKey, IConstTypeArg<ConsoleSpecialKey>;
}

/// <summary>
/// The <see cref="K_SpecialKey{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ConsoleSpecialKey, K_ConsoleSpecialKey&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for
/// /// <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
/// System.ConsoleSpecialKey</see> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_SpecialKey"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
/// System.ConsoleSpecialKey</seealso>
/// <seealso cref="SpecialKey{K}"/>
public interface K_SpecialKey<TSelf> : K_SpecialKey, IConstTypeArg<ConsoleSpecialKey, TSelf>
    where TSelf : K_SpecialKey<TSelf>;

/// <summary>
/// The <see cref="SpecialKey{K}"/> class provides a const argument provider that
/// wraps the <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
/// System.ConsoleSpecialKey</see> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_SpecialKey"/>
public abstract class SpecialKey<K> : K<ConsoleSpecialKey, K>, K_SpecialKey
    where K : K_SpecialKey
{ public static ConsoleSpecialKey Value => K.Value; }

/// <summary>
/// The <see cref="SpecialKeys"/> static class encapsulates const type arguments
/// for <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">ConsoleSpecialKey.ControlBreak</see>
/// and <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">ConsoleSpecialKey.ControlC</see>.
/// </summary>
/// <seealso cref="SpecialKey{K}"/>
/// <seealso cref="K_SpecialKey"/>
/// <seealso cref="Keys"/>
/// <seealso cref="KeyModifiers"/>
public static class SpecialKeys
{
    /// <summary>
    /// The <see cref="ControlBreak"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
    /// System.ConsoleSpecialKey.ControlBreak</see>.
    /// </summary>
    /// <seealso cref="ControlC"/>
    public readonly struct ControlBreak : K_SpecialKey<ControlBreak>
    { public static ConsoleSpecialKey Value => ConsoleSpecialKey.ControlBreak; }

    /// <summary>
    /// The <see cref="ControlC"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolespecialkey">
    /// System.ConsoleSpecialKey.ControlC</see>.
    /// </summary>
    /// <seealso cref="ControlBreak"/>
    public readonly struct ControlC : K_SpecialKey<ControlC>
    { public static ConsoleSpecialKey Value => ConsoleSpecialKey.ControlC; }
}
