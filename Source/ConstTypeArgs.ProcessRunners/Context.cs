//using System.Runtime.InteropServices;

//using static System.Runtime.InteropServices.LayoutKind;

namespace ConstTypeArgs.ProcessRunners;

// #TODO: Think about interop scenarios. Is there a use case, or even the ability, to use a process runner
//        from unmanaged code? Maybe add the StructLayout attribute back.
// #TODO: Add more seelso items.

/// <summary>
/// The <see cref="Context{T}"/> record struct encapsulates the immutable context for a process runner.
/// </summary>
/// <remarks>
/// Not all processes &amp; operations require a context. In these cases, they will have
/// a <see cref="Context{T}"/> set to <see cref="Empty"/>.An empty context has no data;
/// its <see cref="Data"/>/ property will be <see langword="default"/>(<typeparamref name="T"/>).
/// When this is a possibility, use the <see cref="ContextExtensions.IsEmpty{T}">IsEmpty{T}</see>
/// extension method to check if the context is empty.
/// </remarks>
/// <seealso cref="State{T}"/>
//[StructLayout(Auto, CharSet = CharSet.Auto)]
public readonly record struct Context<T>
{
    /// <summary>
    /// An empty context.
    /// </summary>
    /// <remarks>
    /// Use this to check if a context is empty or not.
    /// </remarks>
    public static readonly Context<T> Empty = new() { IsEmpty = true, Data = default! };

    /// <summary>
    /// Gets the context data's type.
    /// </summary>
    /// <value>
    /// The context data's type.
    /// </value>
    [EditorBrowsable(Never)]
    public static Type DataType => typeof(T);

    /// <summary>
    /// Gets &amp; inits a value indicating whether or not the context data is empty.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the context data is empty;
    /// otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// This is set to <see langword="true"/> if the context is <see cref="Empty"/>
    /// and in no other case.
    /// </remarks>
    [EditorBrowsable(Never)]
    internal readonly bool IsEmpty { get; init; }

    /// <summary>
    /// Gets &amp; inits the context data.
    /// </summary>
    /// <value>
    /// The context data.
    /// </value>
    /// <remarks>
    /// Use the <see cref="ContextExtensions.IsEmpty{T}">IsEmpty{T}</see> extension
    /// method to check if the context is empty. If it is, the value of this property
    /// will be <see langword="default"/>(<typeparamref name="T"/>).
    /// </remarks>
    public readonly T Data { get; init; } = default!;

    /// <summary>
    /// Initializes a new instance of the <see cref="Context{T}"/> struct.
    /// </summary>
    public Context() { }

    /// <summary>
    /// Converts a value of type <typeparamref name="T"/> to a <see cref="Context{T}"/>.
    /// </summary>
    /// <param name="data">
    /// The data to convert.
    /// </param>
    public static implicit operator Context<T>(T data) => new() { Data = data };

    /// <summary>
    /// Converts a <see cref="Context{T}"/> to a value of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="context">
    /// The context to convert.
    /// </param>
    public static implicit operator T(Context<T> context) => context.Data;
}

/// <summary>
/// The <see cref="ContextExtensions"/> class provides extension methods for the <see cref="Context{T}"/> struct.
/// </summary>
/// <seealso cref="Context{T}"/>
public static class ContextExtensions
{
    /// <summary>
    /// Tests if the context is empty.
    /// </summary>
    /// <param name="context">
    /// The context to test.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the context is empty;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsEmpty<T>(this Context<T> context) => context.IsEmpty;
}
