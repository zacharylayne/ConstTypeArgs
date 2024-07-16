using ConstTypeArgs.Core;
using ConstTypeArgs.Delegates.Actions;

#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.Delegates.Funcs;

/// <summary>
/// The <see cref="RefFunction{T, TResult}"/> delegate is a function that
/// takes a reference to a value of type <typeparamref name="T"/>
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <param name="reference">
/// The reference to the value of type <typeparamref name="T"/>.
/// </param>
/// <returns>
/// A value of type <typeparamref name="TResult"/>.
/// </returns>
/// <seealso cref="RefFunction{T, TArgs, TResult}"/>
/// <seealso cref="RefProcedure{T}"/>
/// <seealso cref="RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArgs, TResult}"/>
public delegate TResult RefFunction<T, out TResult>(ref T reference);

/// <summary>
/// The <see cref="RefFunction{T, TArgs, TResult}"/> delegate is a function that
/// takes a reference to a value of type <typeparamref name="T"/>
/// and additional arguments of type <typeparamref name="TArgs"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArgs">
/// The type encapsulating the remaining arguments to be passed in.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <param name="reference">
/// The reference to the value of type <typeparamref name="T"/>.
/// </param>
/// <param name="arguments">
/// The remaining arguments to be passed in.
/// </param>
/// <returns>
/// A value of type <typeparamref name="TResult"/>.
/// </returns>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefProcedure{T}"/>
/// <seealso cref="RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArgs, TResult}"/>
public delegate TResult RefFunction<T, in TArgs, out TResult>(ref T reference,
    TArgs arguments);

/// <summary>
/// The <see cref="K_RefFunction{T, TResult}"/> interface provides a more explicit
/// IConstTypeArg&lt;RefFunc&lt;T, TResult&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <seealso cref="K_RefFunction{T, TArgs, TResult}"/>
/// <seealso cref="K_RefProcedure{T}"/>
/// <seealso cref="K_RefProcedure{T, TArgs}"/>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArgs, TResult}"/>
public interface K_RefFunction<T, out TResult>
    : IConstTypeArg<RefFunction<T, TResult>>;

/// <summary>
/// The <see cref="K_RefFunction{T, TArgs, TResult}"/> interface provides a more explicit
/// IConstTypeArg&lt;RefFunc&lt;T, TArgs, TResult&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArgs">
/// The type encapsulating the remaining arguments to be passed in.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefProcedure{T}"/>
/// <seealso cref="K_RefProcedure{T, TArgs}"/>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArgs, TResult}"/>
public interface K_RefFunction<T, in TArgs, out TResult>
    : K_Delegate<RefFunction<T, TArgs, TResult>>;
