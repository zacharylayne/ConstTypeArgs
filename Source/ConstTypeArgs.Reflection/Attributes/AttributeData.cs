namespace ConstTypeArgs.Reflection.Attributes;

/// <summary>
/// The <see cref="AttributeData"/> record is used to store information about a custom attribute.
/// </summary>
public record AttributeData
{
    /// <summary>
    /// The message for the exception that is thrown when a specified attribute type
    /// is not derived from <see cref="Attribute"/>.
    /// </summary>
    private const string MustDeriveFromAttributeMessage = $"""
                The attribute type must derive from {nameof(Attribute)}.
                """;

    /// <summary>
    /// The backing field for the <see cref="Type"/> property.
    /// </summary>
    private Type? _Type;

    /// <summary>
    /// Required. Gets &amp; inits the custom attribute's type.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Thrown when the specified attribute type is not derived from <see cref="Attribute"/>.
    /// </exception>
    public required Type Type
    {
        get => _Type!;

        init
        {
            if (!value.IsSubclassOf(typeof(Attribute)))
                throw new ArgumentException(MustDeriveFromAttributeMessage, nameof(Type));

            _Type = value;
        }
    }

    /// <summary>
    /// Required. Gets &amp; inits the target of the custom attribute.
    /// </summary>
    public required object Target { get; init; }

    /// <summary>
    /// Required. Gets &amp; inits the kind of target the custom attribute is applied to
    /// <em>(i.e. a type, method, parameter, etc.)</em>.
    /// </summary>
    public required AttributeTargets TargetKind { get; init; }

    // #TODO: GenericArguments

    ///// <summary>
    ///// Gets &amp; inits the custom attribute's positional arguments.
    ///// </summary>
    ///// <value>
    ///// The custom attribute's positional arguments or an empty collection if there are none.
    ///// </value>
    //public required IEnumerable<PositionalAttributeArgument> PositionalArguments { get; init; }
    //    = [];

    ///// <summary>
    ///// Gets &amp; inits the custom attribute's named arguments.
    ///// </summary>
    ///// <value>
    ///// The custom attribute's named arguments or an empty collection if there are none.
    ///// </value>
    //public required IEnumerable<NamedAttributeArgument> NamedArguments { get; init; }
    //    = [];
}
