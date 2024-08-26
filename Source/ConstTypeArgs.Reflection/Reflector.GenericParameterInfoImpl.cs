namespace ConstTypeArgs.Reflection;

public static partial class Reflector
{
    /// <summary>
    /// Provides a private concrete implementation of the <see cref="IGenericParameterInfo"/> interface.
    /// </summary>
    public sealed class GenericParameterInfoImpl
        : IGenericParameterInfo
    {
        /// <summary>
        /// Required. Gets &amp; inits the name of the generic parameter this object represents.
        /// </summary>
        public required string Name { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits the framework kinds the generic parameter this object represents is.
        /// </summary>
        public required FrameworkKinds Kind { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits the generic parameter list position of
        /// the generic parameter this object represents.
        /// </summary>
        /// <value>
        /// Position is 0-based.
        /// </value>
        public required int Position { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constraints placed
        /// on the generic parameter this object represents.
        /// </summary>
        /// <value>
        /// If the generic parameter this object represents has no constraints, the value is an empty collection.
        /// </value>
        public required IEnumerable<ITypeInfo> TypedConstraints { get; init; } = [];

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the attributes
        /// marking the generic parameter this object represents.
        /// </summary>
        /// <value>
        /// If the generic parameter this object represents has no attributes, the value is an empty collection.
        /// </value>
        public required IEnumerable<IAttributeInfo> Attributes { get; init; } = [];
    }
}
