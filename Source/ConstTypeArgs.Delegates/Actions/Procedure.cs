using ConstTypeArgs.Core;
using ConstTypeArgs.Delegates.Funcs;
using ConstTypeArgs.Delegates.Predicates;

#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.Delegates.Actions;

/// <summary>
/// The <see cref="K_Procedure"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&gt;</c> derived type.
/// </summary>
/// <seealso cref="K_Function{TResult}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action">
/// System.Action</seealso>
/// <seealso cref="K_Function{TResult}"/>
public interface K_Procedure
    : K_Delegate<Action>;

/// <summary>
/// The <see cref="K_Procedure{T}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the input parameter.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-1">
/// Action&lt;T&gt;</seealso>
/// <seealso cref="K_Function{T1, TResult}"/>
public interface K_Procedure<in T1>
    : K_Delegate<Action<T1>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-2">
/// Action&lt;T1,T2&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, TResult}"/>
public interface K_Procedure<in T1, in T2>
    : K_Delegate<Action<T1, T2>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-3">
/// Action&lt;T1,T2,T3&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3>
    : K_Delegate<Action<T1, T2, T3>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-4">
/// Action&lt;T1,T2,T3,T4&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4>
    : K_Delegate<Action<T1, T2, T3, T4>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-5">
/// Action&lt;T1,T2,T3,T4,T5&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5>
    : K_Delegate<Action<T1, T2, T3, T4, T5>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-6">
/// Action&lt;T1,T2,T3,T4,T5,T6&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-7">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-8">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-9">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-10">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-11">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11, T12}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-12">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-13">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-14">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-15">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/>
/// <seealso cref="K_Predicate{T}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>;

/// <summary>
/// The <see cref="K_Procedure{T1,T2,T3,T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16&gt;&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-16">
/// Action&lt;T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16&gt;</seealso>
/// <seealso cref="K_Function{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/>
/// <seealso cref="K_Predicate{T}"/>
public interface K_Procedure<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
    : K_Delegate<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>;
