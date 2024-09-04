namespace ConstTypeArgs.Reflection.Attributes;

/// <summary>
/// The <see cref="AttributeArgument"/> record provides information about
/// a named or positional argument on a custom attribute.
/// </summary>
public abstract record AttributeArgument
{
    /// <summary>
    /// The message describing that a given attribute kind must be named or positional.
    /// </summary>
    private const string KindMustBeNamedOrPositional = $"""
                The attribute specified attribute kind must be
                {nameof(AttributeArgumentKind.Named)}
                or {nameof(AttributeArgumentKind.Positional)}.
                """;

    /// <summary>
    /// The message used when the argument type is undefined.
    /// </summary>
    private const string ArgumentTypeUndefinedMessage = "The argument type cannot be undefined.";

    /// <summary>
    /// Optional. Gets &amp; inits the argument's name.
    /// </summary>
    /// <value>
    /// The default value is an empty string.
    /// </value>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// The backing field for the <see cref="ArgumentType"/> property.
    /// </summary>
    private AttributeArgumentTypes _ArgumentType;

    /// <summary>
    /// Required. Gets &amp; inits a value indicating the argument's type.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Thrown when initialized to <see cref="AttributeArgumentTypes.Undefined"/>.
    /// </exception>
    public required AttributeArgumentTypes ArgumentType
    {
        get => _ArgumentType;

        init
        {
            if (value == AttributeArgumentTypes.Undefined)
                throw new ArgumentException(ArgumentTypeUndefinedMessage, nameof(ArgumentType));

            _ArgumentType = value;
        }
    }

    /// <summary>
    /// The backing field for the <see cref="ArgumentKind"/> property.
    /// </summary>
    private AttributeArgumentKind _ArgumentKind;

    /// <summary>
    /// Required. Gets &amp; inits a value indicating the argument's kind
    /// <em>(i.e. named or positional)</em>.
    /// </summary>
    public required AttributeArgumentKind ArgumentKind
    {
        get => _ArgumentKind;

        init
        {
            if (value == AttributeArgumentKind.None)
                throw new ArgumentException(KindMustBeNamedOrPositional, nameof(ArgumentKind));

            _ArgumentKind = value;
        }
    }

    /// <summary>
    /// Returns the argument's value as an object.
    /// </summary>
    /// <returns>
    /// The argument's value as an object.
    /// </returns>
    /// <remarks>
    /// Use <see cref="ArgumentType"/> to determine the type of the returned value.
    /// </remarks>
    public abstract object? GetValue();
}

/// <summary>
/// The <see cref="AttributeArgument{T}"/> record provides information about a named or positional argument
/// </summary>
/// <typeparam name="T">
/// The type of the argument's value.
/// </typeparam>
public abstract record AttributeArgument<T>
    : AttributeArgument
{
    /// <summary>
    /// The static constructor for the <see cref="AttributeArgument{T}"/> record.
    /// </summary>
    AttributeArgument()
    {

    }

    /// <summary>
    /// Required. Gets &amp; inits the argument's value.
    /// </summary>
    public required T Value { get; init; }

    /// <inheritdoc/>
    public override object? GetValue() => Value;
}
