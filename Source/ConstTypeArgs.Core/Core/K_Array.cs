#pragma warning disable IDE1006 // Naming Styles
namespace ConstTypeArgs.Core;

// #IMPLEMENTATION NOTES: Why are types prefixed with "K_"?
// --------------------------------------------------------
// The purpose of these types is for using type parameters to pass values to generics
// and, as such, they are prefixed with "K_" to indicate their intended use as a "K" constant.

// #TODO? Should T be notnull?

/// <summary>
/// The <see cref="K_Array"/> interface provides a base interface for identifying
/// const type argument arrays.
/// </summary>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
[EditorBrowsable(Advanced)]
public interface K_Array : IConstTypeArg;

/// <summary>
/// The <see cref="K_Array{T}"/> interface provides a base type
/// for all interfaces used to constrain const type argument values to
/// types of arrays.
/// </summary>
/// <typeparam name="T">
/// The type of array of the const type argument's value.
/// </typeparam>
/// <seealso cref="K_Class{T}"/>
/// <seealso cref="K_Delegate{T}"/>
/// <seealso cref="K_MulticastDelegate{T}"/>
/// <seealso cref="K_Enum{T}"/>
/// <seealso cref="K_Struct{T}"/>
/// <seealso cref="K_Unmanaged{T}"/>
/// <seealso cref="K_FloatingPoint{T}"/>
/// <seealso cref="K_Integer{T}"/>
/// <seealso cref="K_Number{T}"/>
/// <seealso cref="K_SignedNumber{T}"/>
/// <seealso cref="K_UnsignedNumber{T}"/>
public interface K_Array<out T> : IConstTypeArg<T[]>, K_Array;
