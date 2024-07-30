using ConstTypeArgs.Delegates.Args.Funcs;

namespace ConstTypeArgs.Delegates.Args.Actions;

/// <summary>
/// The <see cref="ActionArg{T, K}"/> represents a method that has one const type argument
/// and does not return a value.
/// </summary>
/// <typeparam name="T">
/// The type of the const type argument.
/// </typeparam>
/// <typeparam name="K">
/// The const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T, K, TResult}"/>
public delegate void ActionArg<T, K>()
    where K : IConstTypeArg<T>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2}"/>
/// represents a method that has two const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3}"/>
/// represents a method that has three const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4}"/>
/// represents a method that has four const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>
    where K4 : IConstTypeArg<T4>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5}"/>
/// represents a method that has five const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>
    where K4 : IConstTypeArg<T4> where K5 : IConstTypeArg<T5>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6}"/>
/// represents a method that has six const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>
    where K4 : IConstTypeArg<T4> where K5 : IConstTypeArg<T5> where K6 : IConstTypeArg<T6>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7}"/>
/// represents a method that has seven const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>
    where K4 : IConstTypeArg<T4> where K5 : IConstTypeArg<T5> where K6 : IConstTypeArg<T6>
    where K7 : IConstTypeArg<T7>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8}"/>
/// represents a method that has eight const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>
    where K4 : IConstTypeArg<T4> where K5 : IConstTypeArg<T5> where K6 : IConstTypeArg<T6>
    where K7 : IConstTypeArg<T7> where K8 : IConstTypeArg<T8>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10}"/>
/// represents a method that has nine const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2> where K3 : IConstTypeArg<T3>
    where K4 : IConstTypeArg<T4> where K5 : IConstTypeArg<T5> where K6 : IConstTypeArg<T6>
    where K7 : IConstTypeArg<T7> where K8 : IConstTypeArg<T8> where K9 : IConstTypeArg<T9>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10}"/>
/// represents a method that has ten const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11}"/>
/// represents a method that has eleven const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh const type argument.
/// </typeparam>
/// <typeparam name="K11">
/// The eleventh const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10, T11, K11>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10> where K11 : IConstTypeArg<T11>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12}"/>
/// represents a method that has twelve const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh const type argument.
/// </typeparam>
/// <typeparam name="K11">
/// The eleventh const type argument.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth const type argument.
/// </typeparam>
/// <typeparam name="K12">
/// The twelfth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10, T11, K11, T12, K12>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10> where K11 : IConstTypeArg<T11> where K12 : IConstTypeArg<T12>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13}"/>
/// represents a method that has thirteen const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh const type argument.
/// </typeparam>
/// <typeparam name="K11">
/// The eleventh const type argument.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth const type argument.
/// </typeparam>
/// <typeparam name="K12">
/// The twelfth const type argument.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth const type argument.
/// </typeparam>
/// <typeparam name="K13">
/// The thirteenth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10, T11, K11, T12, K12, T13, K13>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10> where K11 : IConstTypeArg<T11> where K12 : IConstTypeArg<T12>
    where K13 : IConstTypeArg<T13>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14}"/>
/// represents a method that has fourteen const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh const type argument.
/// </typeparam>
/// <typeparam name="K11">
/// The eleventh const type argument.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth const type argument.
/// </typeparam>
/// <typeparam name="K12">
/// The twelfth const type argument.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth const type argument.
/// </typeparam>
/// <typeparam name="K13">
/// The thirteenth const type argument.
/// </typeparam>
/// <typeparam name="T14">
/// The type of the fourteenth const type argument.
/// </typeparam>
/// <typeparam name="K14">
/// The fourteenth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10> where K11 : IConstTypeArg<T11> where K12 : IConstTypeArg<T12>
    where K13 : IConstTypeArg<T13> where K14 : IConstTypeArg<T14>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14, T15, K15}"/>
/// represents a method that has fifteen const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh const type argument.
/// </typeparam>
/// <typeparam name="K11">
/// The eleventh const type argument.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth const type argument.
/// </typeparam>
/// <typeparam name="K12">
/// The twelfth const type argument.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth const type argument.
/// </typeparam>
/// <typeparam name="K13">
/// The thirteenth const type argument.
/// </typeparam>
/// <typeparam name="T14">
/// The type of the fourteenth const type argument.
/// </typeparam>
/// <typeparam name="K14">
/// The fourteenth const type argument.
/// </typeparam>
/// <typeparam name="T15">
/// The type of the fifteenth const type argument.
/// </typeparam>
/// <typeparam name="K15">
/// The fifteenth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14, T15, K15, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14,
                               T15, K15>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10> where K11 : IConstTypeArg<T11> where K12 : IConstTypeArg<T12>
    where K13 : IConstTypeArg<T13> where K14 : IConstTypeArg<T14> where T15 : IConstTypeArg<T15>;

/// <summary>
/// The <see cref="ActionArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14, T15, K15, T16, K16}"/>
/// represents a method that has sixteen const type arguments and does not return a value.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The first const type argument.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The second const type argument.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third const type argument.
/// </typeparam>
/// <typeparam name="K3">
/// The third const type argument.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth const type argument.
/// </typeparam>
/// <typeparam name="K4">
/// The fourth const type argument.
/// </typeparam>
/// <typeparam name="T5">
/// The type of the fifth const type argument.
/// </typeparam>
/// <typeparam name="K5">
/// The fifth const type argument.
/// </typeparam>
/// <typeparam name="T6">
/// The type of the sixth const type argument.
/// </typeparam>
/// <typeparam name="K6">
/// The sixth const type argument.
/// </typeparam>
/// <typeparam name="T7">
/// The type of the seventh const type argument.
/// </typeparam>
/// <typeparam name="K7">
/// The seventh const type argument.
/// </typeparam>
/// <typeparam name="T8">
/// The type of the eighth const type argument.
/// </typeparam>
/// <typeparam name="K8">
/// The eighth const type argument.
/// </typeparam>
/// <typeparam name="T9">
/// The type of the ninth const type argument.
/// </typeparam>
/// <typeparam name="K9">
/// The ninth const type argument.
/// </typeparam>
/// <typeparam name="T10">
/// The type of the tenth const type argument.
/// </typeparam>
/// <typeparam name="K10">
/// The tenth const type argument.
/// </typeparam>
/// <typeparam name="T11">
/// The type of the eleventh const type argument.
/// </typeparam>
/// <typeparam name="K11">
/// The eleventh const type argument.
/// </typeparam>
/// <typeparam name="T12">
/// The type of the twelfth const type argument.
/// </typeparam>
/// <typeparam name="K12">
/// The twelfth const type argument.
/// </typeparam>
/// <typeparam name="T13">
/// The type of the thirteenth const type argument.
/// </typeparam>
/// <typeparam name="K13">
/// The thirteenth const type argument.
/// </typeparam>
/// <typeparam name="T14">
/// The type of the fourteenth const type argument.
/// </typeparam>
/// <typeparam name="K14">
/// The fourteenth const type argument.
/// </typeparam>
/// <typeparam name="T15">
/// The type of the fifteenth const type argument.
/// </typeparam>
/// <typeparam name="K15">
/// The fifteenth const type argument.
/// </typeparam>
/// <typeparam name="T16">
/// The type of the sixteenth const type argument.
/// </typeparam>
/// <typeparam name="K16">
/// The sixteenth const type argument.
/// </typeparam>
/// <seealso cref="FuncArg{T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8, T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14, T15, K15, T16, K16, TResult}"/>
public delegate void ActionArg<T1, K1, T2, K2, T3, K3, T4, K4, T5, K5, T6, K6, T7, K7, T8, K8,
                               T9, K9, T10, K10, T11, K11, T12, K12, T13, K13, T14, K14,
                               T15, K15, T16, K16>()
    where K1  : IConstTypeArg<T1>  where K2  : IConstTypeArg<T2>  where K3  : IConstTypeArg<T3>
    where K4  : IConstTypeArg<T4>  where K5  : IConstTypeArg<T5>  where K6  : IConstTypeArg<T6>
    where K7  : IConstTypeArg<T7>  where K8  : IConstTypeArg<T8>  where K9  : IConstTypeArg<T9>
    where K10 : IConstTypeArg<T10> where K11 : IConstTypeArg<T11> where K12 : IConstTypeArg<T12>
    where K13 : IConstTypeArg<T13> where K14 : IConstTypeArg<T14> where T15 : IConstTypeArg<T15>
    where K16 : IConstTypeArg<T16>;