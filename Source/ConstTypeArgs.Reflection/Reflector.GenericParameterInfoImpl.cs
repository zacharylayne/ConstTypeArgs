namespace ConstTypeArgs.Reflection;

public static partial class Reflector
{
    /// <summary>
    /// Provides a private concrete implementation of the <see cref="IGenericParameterInfo"/> interface.
    /// </summary>
    public sealed class GenericParameterInfoImpl
        : IGenericParameterInfo
    {
        /// <inheritdoc/>
        public string Name => throw new NotImplementedException();

        /// <inheritdoc/>
        public FrameworkKinds Kind => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<IAttributeInfo> Attributes => throw new NotImplementedException();

        /// <inheritdoc/>
        public int Position => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<ITypeInfo> TypedConstraints => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<string> UntypedConstraints => throw new NotImplementedException();

        /// <summary>
        /// Creates a new instance of the <see cref="GenericParameterInfoImpl"/> class.
        /// </summary>
        public GenericParameterInfoImpl()
        {
        }
    }
}