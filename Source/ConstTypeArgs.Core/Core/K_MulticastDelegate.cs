#pragma warning disable IDE1006 // Naming Styles
namespace ConstTypeArgs.Core;

// #IMPLEMENTATION NOTES: Why are types prefixed with "K_"?
// --------------------------------------------------------
// The purpose of these types is for using type parameters to pass values to generics
// and, as such, they are prefixed with "K_" to indicate their intended use as a "K" constant.

/// <summary>
/// The <see cref="K_MulticastDelegate"/> interface provides a base interface for identifying
/// const type argument that are multicast delegates.
/// </summary>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
[EditorBrowsable(Advanced)]
public interface K_MulticastDelegate
    : IConstTypeArg;

/// <summary>
/// The <see cref="K_MulticastDelegate{T}"/> interface provides a base type
/// for all interfaces used to constrain const type argument values
/// to <see langword="delegate"/> types of type
/// <see href="https://learn.microsoft.com/dotnet/api/system.multicastdelegate">
/// MulticastDelegate</see>.
/// </summary>
/// <typeparam name="T">
/// The <see langword="delegate"/> type of the const type argument's value.
/// </typeparam>
/// <remarks>
/// Implement this for const type arguments when delegate chaining is desired.
/// </remarks>
/// <seealso cref="K_Delegate{T}"/>
/// <seealso cref="K_Class{T}"/>
/// <seealso cref="K_Enum{T}"/>
/// <seealso cref="K_Struct{T}"/>
/// <seealso cref="K_Unmanaged{T}"/>
/// <seealso cref="K_Number{T}"/>
/// <seealso cref="K_Array{T}"/>
public interface K_MulticastDelegate<out T>
    : IConstTypeArg<T>, K_MulticastDelegate
    where T : MulticastDelegate;
