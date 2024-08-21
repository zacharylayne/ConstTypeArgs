namespace ConstTypeArgs.Reflection;

public static partial class Reflector
{
    /// <summary>
    /// Provides a private concrete implementation of the <see cref="IAttributeInfo"/> interface.
    /// </summary>
    public sealed class AttributeInfoImpl
        : IAttributeInfo
    {
        /// <inheritdoc/>
        public Type Type => throw new NotImplementedException();

        /// <inheritdoc/>
        public string Name => throw new NotImplementedException();       

        /// <inheritdoc/>
        public bool IsClass => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool IsInterface => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool IsStruct => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool IsAbstract => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool IsSealed => throw new NotImplementedException();

        /// <inheritdoc/>
        public FrameworkKinds Kind => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<IAttributeInfo> Attributes => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<ITypeInfo> Implements => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<ITypeInfo> BaseTypes => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool HasGenericParameters => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool IsClosed => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<IGenericParameterInfo> GenericParameters => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool HasGenericArguments => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<ITypeInfo> GenericArguments => throw new NotImplementedException();

        /// <inheritdoc/>
        public IEnumerable<IConstTypeArgInfo> ConstTypeArguments => throw new NotImplementedException();

        /// <summary>
        /// Creates a new instance of the <see cref="AttributeInfoImpl"/> class.
        /// </summary>
        public AttributeInfoImpl()
        {
        }
    }
}