#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.Core;

// #IMPLEMENTATION NOTES: Why types prefixed with "K_"?
// ----------------------------------------------------
// These types are a special kind of argument provider. Like all argument providers, they are
// meant for using type parameters to pass values to generics and, as such, they are prefixed with "K_"
// to indicate their intended use as "K" constant.
//
// The difference between these types and other argument providers is that they wrap the value of another
// argument provider.

/// <summary>
/// The <see cref="K_ReadOnlyMemory{T}"/> interface provides a more explicit
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ReadOnlyMemory&lt;T&gt;&gt;</see> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of items held in memory.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.readonlymemory-1">ReadOnlyMemory&lt;T&gt;</seealso>
/// <seealso cref="K_ReadOnlyMemoryArray{T}"/>
/// <seealso cref="K_ReadOnlyMemoryT_Array{T}"/>
public interface K_ReadOnlyMemory<T> : K_Struct<ReadOnlyMemory<T>>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ReadOnlyMemory<T>, IConstTypeArg<ReadOnlyMemory<T>>;
}

/// <summary>
/// The <see cref="K_ReadOnlyMemoryArray{T}"/> interface provides a more explicit
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ReadOnlyMemory&lt;T&gt;[]&gt;</see> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of items held in memory.
/// </typeparam>
/// <remarks>
/// This type is used to provide arrays of <c>ReadOnlyMemory</c>, as opposed to an array inside <c>ReadOnlyMemory</c>.
/// See <see cref="K_ReadOnlyMemoryT_Array{T}"/> for more information.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.readonlymemory-1">ReadOnlyMemory&lt;T&gt;</seealso>
/// <seealso cref="K_ReadOnlyMemory{T}"/>
/// <seealso cref="K_ReadOnlyMemoryT_Array{T}"/>
public interface K_ReadOnlyMemoryArray<T> : K_Array<ReadOnlyMemory<T>[]>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ReadOnlyMemoryArray<T>, IConstTypeArg<ReadOnlyMemory<T>[]>;
}

/// <summary>
/// The <see cref="K_ReadOnlyMemoryT_Array{T}"/> interface provides a more explicit
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ReadOnlyMemory&lt;T[]&gt;&gt;</see> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of items held in memory.
/// </typeparam>
/// <remarks>
/// This type is used to provide an array inside <c>ReadOnlyMemory</c>, as opposed to arrays of <c>ReadOnlyMemory</c>.
/// See <see cref="K_ReadOnlyMemoryArray{T}"/> for more information.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.readonlymemory-1">ReadOnlyMemory&lt;T&gt;</seealso>
/// <seealso cref="K_ReadOnlyMemory{T}"/>
/// <seealso cref="K_ReadOnlyMemoryArray{T}"/>
public interface K_ReadOnlyMemoryT_Array<T> : K_Array<T>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ReadOnlyMemoryT_Array<T>, IConstTypeArg<ReadOnlyMemory<T[]>>;
}
