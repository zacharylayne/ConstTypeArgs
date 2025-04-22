namespace ConstTypeArgs.ProcessRunners;

// #TODO: Add more seelso items.

/// <summary>
/// The <see cref="State{T}"/> record encapsulates the mutable state of a process runner.
/// </summary>
/// <remarks>
/// To test if there is no state, use the  extension method
/// <see cref="StateExtensions.HasNoState{T}(State{T})">HasNoState{T}</see>.
///   <para>
///   To convert to a <see cref="ReadOnlyState{T}"/>, use the method <see cref="State{T}.AsReadOnly"/>.
///   </para>
/// </remarks>
/// <seealso cref="Context{T}"/>
/// <seealso cref="ReadOnlyState{T}"/>
/// <seealso cref="AsReadOnly"/>
public struct State<T>
    where T : notnull
{
    /// <summary>
    /// Represents a state with no data.
    /// </summary>
    /// <remarks>
    /// Use this to check if there is no state data.
    /// </remarks>
    public static readonly State<T> None = new() { IsNone = true, Data = default! };

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
    /// Gets &amp; sets the state.
    /// </summary>
    /// <value>
    /// The state data or <see langword="default"/>(<typeparamref name="T"/>) if there is none.
    /// </value>
    public T Data { get; set; } = default!;

    /// <summary>
    /// Creates a new <see cref="State{T}"/> record.
    /// </summary>
    public State() { }

    /// <summary>
    /// Converts a <see cref="State{T}"/> to a <see cref="ReadOnlyState{T}"/>. This is useful
    /// when a process runner needs to expose its state as read-only.
    /// </summary>
    /// <returns>
    /// An immutable <see cref="ReadOnlyState{T}"/> that contains the same data as this state.
    /// </returns>
    public readonly ReadOnlyState<T> AsReadOnly() => new(Data);

    /// <summary>
    /// Converts a value of type <typeparamref name="T"/> to a <see cref="State{T}"/>.
    /// </summary>
    /// <param name="data">
    /// The data to convert.
    /// </param>
    public static implicit operator State<T>(T data) => new() { Data = data };

    /// <summary>
    /// Converts a <see cref="State{T}"/> to a value of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="state">
    /// The state to convert.
    /// </param>
    public static implicit operator T(State<T> state) => state.Data;
}

/// <summary>
/// The <see cref="StateExtensions"/> class provides extension methods for the <see cref="State{T}"/> record.
/// </summary>
/// <seealso cref="State{T}"/>
public static class StateExtensions
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
    public static bool HasNoState<T>(this State<T> state)
        where T : notnull
        => state.IsNone;
}
