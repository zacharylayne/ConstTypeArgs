#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace ConstTypeArgs;

/// <summary>
/// The <see cref="IConstTypeArg"/> interface provides a base interface for identifying
/// const type argument providers, which are used to pass static read-only &amp; constant
/// values to generic types, delegates, &amp; methods.
/// </summary>
/// <remarks>
/// This is a marker interface intended for very limited usage. It can be useful to simplify
/// type testing &amp; type parameter constraints.
/// </remarks>
[EditorBrowsable(Advanced)]
public interface IConstTypeArg;

/// <summary>
/// The <see cref="IConstTypeArg{T}"/> interface uses static abstract interface methods
/// to provide the means to "pass" values to generic types, delegates, and methods. These
/// values are then directly accessible from within a static context, such as type initializers
/// and static methods &amp; fields. This mimics the behavior of C++'s template specialization (go to
/// <a href="https://en.cppreference.com/w/cpp/language/template_specialization">
/// Template Specialization</a> for more information).
/// </summary>
/// <typeparam name="T">
/// The type of the values to be passed as const type arguments.
/// </typeparam>
/// <remarks>
/// This is intended to provide access to values that are, but not limited to,
/// static readonly values. <strong><em>IMMUTABILITY IS HOWEVER STRONGLY RECOMMENDED.</em></strong>
///   <note type="important">
///   Because <see cref="IConstTypeArg{T}"/> type definitions are <em>argument providers</em>,
///   they are intended to be used as type parameters or as a means to access readonly static values
///   <em>(recommended)</em> or constants. There are few reasons to instantiate them, pass them as
///   arguments to a method, or use them as a return type. There is a very low risk of their usage
///   causing unintended side-effects without a deliberate misuse of reflection.
///   <para>
///   For more information, see the developer documentation.
///   </para>
///   </note>
/// </remarks>
public interface IConstTypeArg<out T> : IConstTypeArg
{
    /// <summary>
    /// Gets a const type argument's value.
    /// </summary>
    /// <value>
    /// The const type argument's value.
    /// </value>
    /// <seealso cref="IConstTypeArg{T, TSelf}.GetValue()"/>
    static abstract T Value { get; }
}

/// <summary>
/// The <see cref="IConstTypeArg{T, TSelf}"/> interface is used to complement
/// <em>argument providers</em> where, in certain cases, it may not be possible to determine
/// an argument provider's type at compile-time
/// </summary>
/// <typeparam name="T">
/// The type of values to be passed as const type arguments.
/// </typeparam>
/// <typeparam name="TSelf">
/// The implementing type itself.
/// </typeparam>
/// <remarks>
/// In rare use cases, an argument provider's type might need to be known but cannot be determined
/// at runtime. In such situations, <see cref="IConstTypeArg{T, TSelf}"/> can prove helpful,
/// though types implementing this interface are still const type arguments and generally should
/// not be instantiated, passed as arguments to a method, or used as a return type.
/// This maintains a very low risk of their usage causing unintended side-effects
/// without a deliberate misuse of reflection.
/// </remarks>
public interface IConstTypeArg<out T, TSelf> : IConstTypeArg<T>
    where TSelf : IConstTypeArg<T, TSelf>, IConstTypeArg
{
    /// <summary>
    /// Returns a const type argument's value.
    /// </summary>
    /// <returns>
    /// The const type argument's value.
    /// </returns>
    /// <seealso cref="IConstTypeArg{T}.Value"/>
    public T GetValue() => TSelf.Value;
}
