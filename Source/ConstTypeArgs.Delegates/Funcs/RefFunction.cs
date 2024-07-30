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
/// <seealso cref="RefFunction{T, TArg, TResult}"/>
/// <seealso cref="RefFunction{T, TArg1, TArg2, TResult}"/>
/// <seealso cref="RefProcedure{T}"/>
/// <seealso cref="RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArgs, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArg1, TArg2, TResult}"/>
public delegate TResult RefFunction<T, out TResult>(ref T reference);

/// <summary>
/// The <see cref="RefFunction{T, TArg, TResult}"/> delegate is a function that
/// takes a reference to a value of type <typeparamref name="T"/>
/// and an argument type <typeparamref name="TArg"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArg">
/// The type encapsulating the remaining arguments to be passed in.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <param name="reference">
/// The reference to the value of type <typeparamref name="T"/>.
/// </param>
/// <param name="arg">
/// The remaining arguments to be passed in.
/// </param>
/// <returns>
/// A value of type <typeparamref name="TResult"/>.
/// </returns>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArg1, TArg2, TResult}"/>
/// <seealso cref="RefProcedure{T}"/>
/// <seealso cref="RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArg, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArg1, TArg2, TResult}"/>
public delegate TResult RefFunction<T, in TArg, out TResult>(ref T reference,
    TArg arg);

/// <summary>
/// The <see cref="RefFunction{T, TArg1, TArg2, TResult}"/> delegate is a function that
/// takes a reference to a value of type <typeparamref name="T"/> and additional arguments
/// <typeparamref name="TArg1"/> &amp; <typeparamref name="TArg2"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArg1">
/// The type of the first argument to be passed in.
/// </typeparam>
/// <typeparam name="TArg2">
/// The type of the second argument to be passed in.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <param name="reference">
/// The reference to the value of type <typeparamref name="T"/>.
/// </param>
/// <param name="arg1">
/// The first argument to be passed in.
/// </param>
/// <param name="arg2">
/// The second argument to be passed in.
/// </param>
/// <returns>
/// A value of type <typeparamref name="TResult"/>.
/// </returns>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArg, TResult}"/>
/// <seealso cref="RefProcedure{T}"/>
/// <seealso cref="RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArg, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArg1, TArg2, TResult}"/>
public delegate TResult RefFunction<T, in TArg1, in TArg2, out TResult>(ref T reference,
    TArg1 arg1, TArg2 arg2);

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
/// The <see cref="K_RefFunction{T, TArg, TResult}"/> interface provides a more explicit
/// IConstTypeArg&lt;RefFunc&lt;T, TArg, TResult&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArg">
/// The type of argument to be passed in.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefProcedure{T}"/>
/// <seealso cref="K_RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TArg1, TArg2, TResult}"/>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArg, TResult}"/>
/// <seealso cref="RefFunction{T, TArg1, TArg2, TResult}"/>
public interface K_RefFunction<T, in TArg, out TResult>
    : K_Delegate<RefFunction<T, TArg, TResult>>;

/// <summary>
/// The <see cref="K_RefFunction{T, TArg1, TArg2, TResult}"/> interface provides a more explicit
/// IConstTypeArg&lt;RefFunc&lt;T, TArg1, TArg2, TResult&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArg1">
/// The type of the first argument to be passed in.
/// </typeparam>
/// <typeparam name="TArg2">
/// The type of the second argument to be passed in.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the value to be returned.
/// </typeparam>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArg, TResult}"/>
/// <seealso cref="K_RefProcedure{T}"/>
/// <seealso cref="K_RefProcedure{T, TArgs}"/>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArg, TResult}"/>
/// <seealso cref="RefFunction{T, TArg1, TArg2, TResult}"/>
public interface K_RefFunction<T, in TArg1, in TArg2, out TResult>
    : K_Delegate<RefFunction<T, TArg1, TArg2, TResult>>;
