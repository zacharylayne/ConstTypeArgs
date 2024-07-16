using ConstTypeArgs.Core;
using ConstTypeArgs.Delegates.Funcs;

#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.Delegates.Actions;

/// <summary>
/// The <see cref="RefProcedure{T}"/> delegate is an action that
/// takes a reference to a value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <param name="reference">
/// The reference to the value of type <typeparamref name="T"/>.
/// </param>
/// <seealso cref="RefProcedure{T, TArgs}"/>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArgs, TResult}"/>
public delegate void RefProcedure<T>(ref T reference);

/// <summary>
/// The <see cref="RefProcedure{T}"/> delegate is an action that
/// takes a reference to a value of type <typeparamref name="T"/>
/// and additional arguments of type <typeparamref name="TArgs"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArgs">
/// The type encapsulating the remaining arguments to be passed in.
/// </typeparam>
/// <param name="reference">
/// The reference to the value of type <typeparamref name="T"/>.
/// </param>
/// <param name="arguments">
/// The remaining arguments to be passed in.
/// </param>
/// <seealso cref="RefProcedure{T}"/>
/// <seealso cref="RefFunction{T, TResult}"/>
/// <seealso cref="RefFunction{T, TArgs, TResult}"/>
public delegate void RefProcedure<T, in TArgs>(ref T reference, TArgs arguments);

/// <summary>
/// The <see cref="K_RefProcedure{T}"/> interface provides a more explicit
/// IConstTypeArgs&lt;RefProcedure&lt;T&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <seealso cref="K_RefProcedure{T, TArgs}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArgs, TResult}"/>
public interface K_RefProcedure<T>
    : K_Delegate<RefProcedure<T>>;

/// <summary>
/// The <see cref="K_RefProcedure{T, TArgs}"/> interface provides a more explicit
/// IConstTypeArgs&lt;RefProcedure&lt;T, TArgs&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be passed by reference.
/// </typeparam>
/// <typeparam name="TArgs">
/// The type encapsulating the remaining arguments to be passed in.
/// </typeparam>
/// <seealso cref="K_RefProcedure{T}"/>
/// <seealso cref="K_RefFunction{T, TResult}"/>
/// <seealso cref="K_RefFunction{T, TArgs, TResult}"/>
public interface K_RefProcedure<T, in TArgs>
    : K_Delegate<RefProcedure<T, TArgs>>;
