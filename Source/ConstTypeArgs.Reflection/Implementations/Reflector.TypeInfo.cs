namespace ConstTypeArgs.Reflection;

public partial class Reflector
{
    /// <summary>
    /// Provides a concrete implementation of the <see cref="ITypeInfo"/> interface.
    /// </summary>
    private class TypeInfo
        : ITypeInfo
    {
        /// <summary>
        /// Required. Gets &amp; inits the type this object represents.
        /// </summary>
        public required Type Type { get; init; }

        /// <summary>
        /// Gets the name of the type this object represents.
        /// </summary>
        public string Name => Type.Name;

        /// <summary>
        /// Required. Gets &amp; inits the framework-related kind of the type this object represents.
        /// </summary>
        /// <value>
        /// If the type this object represents is not framework-related, the value is
        /// <see cref="FrameworkKinds.None"/>. Otherwise, the value is a bitwise combination of
        /// one or more <see cref="FrameworkKinds"/> flags.
        /// </value>
        public required FrameworkKinds Kind { get; init; } // #TODO

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the attributes
        /// marking the type this object represents.
        /// </summary>
        /// <value>
        /// If the type this object represents has no attributes, the value is an empty collection.
        /// </value>
        public required IEnumerable<IAttributeInfo> Attributes { get; init; } = []; // #TODO

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the base types
        /// of the type this object represents.
        /// </summary>
        /// <remarks>
        /// The collection is ordered from most derived to least derived.
        /// If the type this object represents has no base types, the value is an empty collection.
        /// </remarks>
        /// <seealso cref="Implements"/>
        public required IEnumerable<ITypeInfo> BaseTypes { get; init; } = []; // #TODO

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the interfaces
        /// implemented by the type this object represents.
        /// </summary>
        /// <value>
        /// If the type this object represents implements no interfaces, the value is an empty collection.
        /// </value>
        /// <seealso cref="BaseTypes"/>
        public required IEnumerable<ITypeInfo> Implements { get; init; } = []; // #TODO

        /// <summary>
        /// Gets whether or not the type this object represents is a class.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type this object represents is a class;
        /// otherwise, <see langword="false"/>.
        /// </value>
        public bool IsClass => Type.IsClass;

        /// <summary>
        /// Gets whether or not the type this object represents is an instance.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type this object represents is an instance;
        /// otherwise, <see langword="false"/>.
        /// </value>
        public bool IsInterface => Type.IsInterface;

        /// <summary>
        /// Gets whether or not the type this object represents is a struct.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type this object represents is a struct;
        /// otherwise, <see langword="false"/>.
        /// </value>
        public bool IsStruct => Type.IsValueType && !Type.IsEnum;

        /// <summary>
        /// Gets whether or not the type this object represents is abstract.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type this object represents is abstract;
        /// otherwise, <see langword="false"/>.
        /// </value>
        public bool IsAbstract => Type.IsAbstract;

        /// <summary>
        /// Gets whether or not the type this object represents is sealed.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type this object represents is sealed;
        /// otherwise, <see langword="false"/>.
        /// </value>
        public bool IsSealed => Type.IsSealed;
    }
}
