#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace ConstTypeArgs;

// #IMPLEMENTATION NOTES: Why types prefixed with "K_"?
// ----------------------------------------------------
// These types are a special kind of argument provider. Like all argument providers, they are
// meant for using type parameters to pass values to generics and, as such, they are prefixed with "K_"
// to indicate their intended use as "K" constant.
//
// The difference between these types and other argument providers is that they wrap the value of another
// argument provider.

/// <summary>
/// The <see cref="K"/> interface provides a base interface for identifying
/// const type argument holders, which are types of const type argument providers
/// that wrap <em>(i.e. hold)</em> the values of other const type argument providers.
/// </summary>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
public interface K : IConstTypeArg;

/// <summary>
/// The <see cref="K{TArg}"/> interface provides a base interface for identifying
/// const type argument holders, which are types of const type argument providers
/// that wrap <em>(i.e. hold)</em> the values of other const type argument providers.
/// </summary>
/// <typeparam name="TArg">
/// The const type argument provider containing the value to be held.
/// </typeparam>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
public interface K<TArg> : IConstTypeArg
    where TArg : IConstTypeArg;

/// <summary>
/// The <see cref="K{T, TArg}"/> interface provides the means to implement an argument provider
/// that wraps the value from another argument provider specified in <typeparamref name="TArg"/>.
/// </summary>
/// <typeparam name="T">
/// The wrapped value's type.
/// </typeparam>
/// <typeparam name="TArg">
/// The argument provider containing the value to be wrapped.
/// </typeparam>
/// <remarks>
/// Use <see cref="K{T, TArg}"/> to reuse values from other argument providers to provide
/// domain-specific constants, such as minimum, maximum, &amp; default values.
/// </remarks>
public interface K<out T, TArg> : K<TArg>, IConstTypeArg<T>
    where TArg : IConstTypeArg<T>;
