namespace ConstTypeArgs.ProcessRunners;

/// <summary>
/// The <see cref="ReadOnlyState{T}"/> record encapsulates an immutable state for a process runner.
/// </summary>
/// <typeparam name="T">
/// The type of the state data.
/// </typeparam>
/// <seealso cref="Context{T}"/>
/// <seealso cref="State{T}"/>
/// <seealso cref="State{T}.AsReadOnly"/>
public readonly record struct ReadOnlyState<T>
    where T : notnull
{
    /// <summary>
    /// Represents a state with no data.
    /// </summary>
    /// <remarks>
    /// Use this to check if there is no state data.
    /// </remarks>
    public static readonly ReadOnlyState<T> None = new() { IsNone = true, Data = default! };

    /// <summary>
    /// Gets the state data's type.
    /// </summary>
    /// <value>
    /// The state data's type.
    /// </value>
    [EditorBrowsable(Never)]
    public static Type DataType => typeof(T);

    /// <summary>
    /// Gets &amp; inits a value indicating whether there is no state data.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if there is no state data;
    /// otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// This is set to <see langword="true"/> if the state is <see cref="None"/>
    /// and in no other case.
    /// </remarks>
    [EditorBrowsable(Never)]
    internal readonly bool IsNone { get; private init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReadOnlyState{T}"/> record.
    /// </summary>
    [EditorBrowsable(Never)]
    public ReadOnlyState() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReadOnlyState{T}"/> record with the specified data.
    /// </summary>
    /// <param name="data">
    /// The state data.
    /// </param>
    public ReadOnlyState(T data) => Data = data;

    /// <summary>
    /// Gets &amp; inits the state.
    /// </summary>
    /// <value>
    /// The state data or <see langword="default"/>(<typeparamref name="T"/>) if there is none.
    /// </value>
    public readonly T Data { get; init; } = default!;

    /// <summary>
    /// Converts a value of type <typeparamref name="T"/> to a <see cref="ReadOnlyState{T}"/>.
    /// </summary>
    /// <param name="data">
    /// The data to convert.
    /// </param>
    public static explicit operator ReadOnlyState<T>(T data) => new() { Data = data };

    /// <summary>
    /// Converts a <see cref="ReadOnlyState{T}"/> to a value of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="state">
    /// The state to convert.
    /// </param>
    public static implicit operator T(ReadOnlyState<T> state) => state.Data;
}

/// <summary>
/// The <see cref="StateExtensions"/> class provides extension methods for the <see cref="ReadOnlyState{T}"/> record.
/// </summary>
/// <seealso cref="ReadOnlyState{T}"/>
public static class ReadOnlyStateExtensions
{
    /// <summary>
    /// Tests if there is no state data.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the state data.
    /// </typeparam>
    /// <param name="state">
    /// The state to test.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if there is no state data;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool HasNoState<T>(this ReadOnlyState<T> state)
        where T : notnull
        => state.IsNone;
}
