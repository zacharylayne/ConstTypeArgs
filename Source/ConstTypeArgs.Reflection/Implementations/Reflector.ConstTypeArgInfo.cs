namespace ConstTypeArgs.Reflection;

public partial class Reflector
{
    /// <summary>
    /// Provides a private concrete implementation of the <see cref="IConstTypeArgInfo"/> interface.
    /// </summary>
    private sealed class ConstTypeArgInfoImpl
        : TypeInfo, IConstTypeArgInfo
    {
        /// <summary>
        /// Required. Gets &amp; inits the const type argument's value as an object.
        /// </summary>
        /// <remarks>
        /// If <see cref="IsValueDefined"/> is <see langword="false"/>,
        /// the const type argument this object represents should be <see langword="null"/>
        /// or <see langword="default"/>. In this case, the value of this property is undefined
        /// regardless of what this property returns.
        /// </remarks>
        public required object Value { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits the type of the const type argument's value.
        /// If the type of the value is not known, the value is <see langword="null"/>.
        /// </summary>
        public required Type TypeOfValue { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a value indicating whether or not the value
        /// of the const type argument this object represents is defined.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the value of the const type argument;
        /// otherwise, <see langword="false"/>.
        /// </value>
        public required bool IsValueDefined { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits flags specifying what well-known const type
        /// the const type argument this object represents is.
        /// </summary>
        /// <seealso cref="IsWellKnownConstType"/>
        /// <seealso cref="ImplementsWellKnownConstType"/>
        public required WellKnownConstTypes WellKnownConstTypes { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a value indicating whether or not the const type
        /// is a well-known const type <em>(i.e. a type listed as a member in <see cref="WellKnownConstTypes"/>)</em>.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the const type argument is a well-known const type;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <seealso cref="WellKnownConstTypes"/>
        /// <seealso cref="ImplementsWellKnownConstType"/>
        public bool IsWellKnownConstType { get; init; }

        /// <summary>
        /// Gets whether or not the const type argument this object represents implements
        /// implements one or more well-known const types.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the const type argument implements one or more;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <seealso cref="WellKnownConstTypes"/>
        /// <seealso cref="IsWellKnownConstType"/>
        public bool ImplementsWellKnownConstType
            => WellKnownConstTypes != WellKnownConstTypes.None;
    }
}
