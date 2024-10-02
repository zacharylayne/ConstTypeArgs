using ConstTypeArgs.Reflection.Core;

namespace ConstTypeArgs.Reflection;

public partial class Reflector
{
    /// <summary>
    /// Provides a private implementation of the <see cref="IAttributeInfo"/> interface.
    /// </summary>
    private sealed class AttributeInfo
        : IAttributeInfo
   {
        /// <summary>
        /// Required. Gets &amp; inits the element this object represents.
        /// </summary>
        public required IElementInfo Target { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits the name of the attribute this object represents.
        /// </summary>
        public required string Name { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits the framework kinds the attribute this object represents is.
        /// </summary>
        public FrameworkKinds Kind { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required Type Type { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public IEnumerable<ITypeInfo> BaseTypes { get; init; } = [];

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required bool HasGenericParameters { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required bool IsClosed { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required IEnumerable<IGenericParameterInfo> GenericParameters { get; init; } = [];

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required bool HasGenericArguments { get; init; }

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required IEnumerable<ITypeInfo> GenericArguments { get; init; } = [];

        /// <summary>
        /// Required. Gets &amp; inits a collection of information about the constructor arguments
        /// </summary>
        public required IEnumerable<IConstTypeArgInfo> ConstTypeArguments { get; init; } = [];
    }
}
