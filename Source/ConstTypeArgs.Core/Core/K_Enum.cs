#pragma warning disable IDE1006 // Naming Styles
namespace ConstTypeArgs.Core;

// #IMPLEMENTATION NOTES: Why are types prefixed with "K_"?
// --------------------------------------------------------
// The purpose of these types is for using type parameters to pass values to generics
// and, as such, they are prefixed with "K_" to indicate their intended use as a "K" constant.

/// <summary>
/// The <see cref="K_Enum"/> interface provides a base interface for identifying
/// const type argument with values that are a type of enum.
/// </summary>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
[EditorBrowsable(Advanced)]
public interface K_Enum
    : IConstTypeArg;

/// <summary>
/// The <see cref="K_Enum{T}"/> interface provides a base type
/// for all interfaces used to constrain const type argument values
/// to <see langword="enum"/> types.
/// </summary>
/// <typeparam name="T">
/// The <see langword="enum"/> type of the const type argument's value.
/// </typeparam>
/// <seealso cref="K_Class{T}"/>
/// <seealso cref="K_Delegate{T}"/>
/// <seealso cref="K_MulticastDelegate{T}"/>
/// <seealso cref="K_Struct{T}"/>
/// <seealso cref="K_Unmanaged{T}"/>
/// <seealso cref="K_Array{T}"/>
public interface K_Enum<out T> : IConstTypeArg<T>, K_Enum
    where T : struct, Enum;
