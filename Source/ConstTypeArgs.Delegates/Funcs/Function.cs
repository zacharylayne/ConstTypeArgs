using ConstTypeArgs.Core;
using ConstTypeArgs.Delegates.Actions;

#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.Delegates.Funcs;

/// <summary>
/// The <see cref="K_Function{TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-1">
/// System.Func&lt;TResult&gt;</seealso>
/// <seealso cref="K_Procedure"/>
public interface K_Function<out TResult>
    : K_Delegate<Func<TResult>>;

/// <summary>
/// The <see cref="K_Function{T, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-2">
/// System.Func&lt;T, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T}"/>
public interface K_Function<in T, out TResult>
    : K_Delegate<Func<T, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-3">
/// System.Func&lt;T1, T2, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2}"/>
public interface K_Function<in T1, in T2, out TResult>
    : K_Delegate<Func<T1, T2, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-4">
/// System.Func&lt;T1, T2, T3, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3}"/>
public interface K_Function<in T1, in T2, in T3, out TResult>
    : K_Delegate<Func<T1, T2, T3, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-5">
/// System.Func&lt;T1, T2, T3, T4, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4}"/>
public interface K_Function<in T1, in T2, in T3, in T4, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-6">
/// System.Func&lt;T1, T2, T3, T4, T5, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-7">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-8">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-9">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-10">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-11">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-12">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh input parameter.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-13">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh input parameter.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth input parameter.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-14">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh input parameter.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth input parameter.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth input parameter.
/// </typeparam>
/// <typeparam name="T14">
/// The type of the fourteenth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-15">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>
    : K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh input parameter.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth input parameter.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth input parameter.
/// </typeparam>
/// <typeparam name="T14">
/// The type of the fourteenth input parameter.
/// </typeparam>
/// <typeparam name="T15">
/// The type of the fifteenth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-16">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>
    :  K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>;

/// <summary>
/// The <see cref="K_Function{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Func&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,TResult&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth input parameter.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth input parameter.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh input parameter.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth input parameter.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth input parameter.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth input parameter.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh input parameter.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth input parameter.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth input parameter.
/// </typeparam>
/// <typeparam name="T14">
/// The type of the fourteenth input parameter.
/// </typeparam>
/// <typeparam name="T15">
/// The type of the fifteenth input parameter.
/// </typeparam>
/// <typeparam name="T16">
/// The type of the sixteenth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The return type of the function.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-17">
/// System.Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, 16, TResult&gt;</seealso>
/// <seealso cref="K_Procedure{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/>
public interface K_Function<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>
    :  K_Delegate<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>;
