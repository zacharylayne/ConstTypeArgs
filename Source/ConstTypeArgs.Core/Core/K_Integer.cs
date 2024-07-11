#pragma warning disable IDE1006 // Naming Styles
namespace ConstTypeArgs.Core;

// #IMPLEMENTATION NOTES: Why are types prefixed with "K_"?
// --------------------------------------------------------
// The purpose of these types is for using type parameters to pass values to generics
// and, as such, they are prefixed with "K_" to indicate their intended use as a "K" constant.

/// <summary>
/// The <see cref="K_Integer"/> interface provides a base interface for identifying
/// const type argument whose values are a type of
/// <see href="https://learn.microsoft.com/dotnet/api/system.numerics.ibinaryinteger-1">
/// IBinaryInteger&lt;T&gt;</see>.
/// </summary>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
[EditorBrowsable(Advanced)]
public interface K_Integer
    : IConstTypeArg;

/// <summary>
/// The <see cref="K_Integer{T}"/> interface provides a base type
/// for all interfaces used to constrain const type argument values
/// to
/// <see href="https://learn.microsoft.com/dotnet/api/system.numerics.ibinaryinteger-1">
/// IBinaryInteger&lt;T&gt;</see>
/// types.
/// </summary>
/// <typeparam name="T">
/// The <see cref="IBinaryInteger{T}"/> type of the const type argument's value.
/// </typeparam>
/// <seealso cref="K_FloatingPoint{T}"/>
/// <seealso cref="K_Number{T}"/>
/// <seealso cref="K_SignedNumber{T}"/>
/// <seealso cref="K_UnsignedNumber{T}"/>
/// <seealso cref="K_Array{T}"/>
/// <seealso cref="K_Delegate{T}"/>
/// <seealso cref="K_MulticastDelegate{T}"/>
/// <seealso cref="K_Enum{T}"/>
/// <seealso cref="K_Struct{T}"/>
/// <seealso cref="K_Unmanaged{T}"/>
public interface K_Integer<out T>
    : K_Number<T>, K_Integer
    where T : IBinaryNumber<T>, IBinaryInteger<T>;
