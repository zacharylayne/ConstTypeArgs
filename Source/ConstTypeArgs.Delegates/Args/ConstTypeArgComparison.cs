namespace ConstTypeArgs.Delegates;

/// <summary>
/// The <see cref="ConstTypeArgComparison{T, K1, K2}"/> delegate represents a method that
/// compares the const type argument <typeparamref name="K1"/>
/// and the const type argument <typeparamref name="K2"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the const type arguments.
/// </typeparam>
/// <typeparam name="K1">
/// The const type argument to compare against <typeparamref name="K2"/>.
/// </typeparam>
/// <typeparam name="K2">
/// The const type argument to compare to <typeparamref name="K2"/>.
/// </typeparam>
/// <returns>
/// Returns:
///   <list type="bullet">
///     <item>
///     A value of <c>-1</c> if the const type argument <typeparamref name="K1"/>
///     is less than the const type argument <typeparamref name="K2"/>,
///     </item>
///     <item>
///     A value of <c>0</c> if both const type arguments are equal,
///     </item>
///     <item>
///     A value of <c>1</c> if the const type argument <typeparamref name="K1"/>
///     is greater than the const type argument <typeparamref name="K2"/>.
///     </item>
///   </list>
/// </returns>
/// <seealso cref="ConstTypeArgComparison{T1, K1, T2, K2}"/>
public delegate int ConstTypeArgComparison<T, K1, K2>()
    where K1 : IConstTypeArg<T> where K2 : IConstTypeArg<T>;

/// <summary>
/// The <see cref="ConstTypeArgComparison{T1, K1, T2, K2}"/> delegate represents a method that
/// compares two const type arguments of different types, <typeparamref name="K1"/>
/// and <typeparamref name="K2"/>.
/// </summary>
/// <typeparam name="T1">
/// The type of the first const type argument.
/// </typeparam>
/// <typeparam name="K1">
/// The const type argument to compare against <typeparamref name="K2"/>.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second const type argument.
/// </typeparam>
/// <typeparam name="K2">
/// The const type argument to compare to <typeparamref name="K1"/>.
/// </typeparam>
/// <returns>
///   <list type="bullet">
///     <item>
///     A value of <c>-1</c> if the const type argument <typeparamref name="K1"/>
///     is less than the const type argument <typeparamref name="K2"/>,
///     </item>
///     <item>
///     A value of <c>0</c> if both const type arguments are equal,
///     </item>
///     <item>
///     A value of <c>1</c> if the const type argument <typeparamref name="K1"/>
///     is greater than the const type argument <typeparamref name="K2"/>.
///     </item>
///   </list>
/// </returns>
/// <seealso cref="ConstTypeArgComparison{T, K1, K2}"/>
public delegate int ConstTypeArgComparison<T1, K1, T2, K2>()
    where K1 : IConstTypeArg<T1> where K2 : IConstTypeArg<T2>;