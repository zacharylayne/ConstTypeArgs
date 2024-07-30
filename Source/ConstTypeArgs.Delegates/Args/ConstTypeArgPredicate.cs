namespace ConstTypeArgs.Delegates;

/// <summary>
/// The <see cref="ConstTypeArgPredicate{T, K}"/> delegate represents a method that
/// defines a set of one or more criteria and determines whether or not the const type argument
/// specified for <typeparamref name="K"/> meets those criteria.
/// </summary>
/// <typeparam name="T">
/// The type of the const type argument.
/// </typeparam>
/// <typeparam name="K">
/// The const type argument to determine if it meets the criteria.
/// </typeparam>
/// <returns>
/// A value of <see langword="true"/> if the const type argument meets the criteria;
/// otherwise, <see langword="false"/>.
/// </returns>
public delegate bool ConstTypeArgPredicate<T, K>()
    where K : IConstTypeArg<T>;