namespace ConstTypeArgs.Reflection;

public static partial class Reflector
{
    /// <summary>
    /// Provides a private concrete implementation of the <see cref="IConstTypeArgInfo"/> interface.
    /// </summary>
    private sealed class ConstTypeArgInfoImpl
        : IConstTypeArgInfo
    {
        public Type Type => throw new NotImplementedException();
        public string Name => throw new NotImplementedException();
        public object? Value => throw new NotImplementedException();

        public bool IsClass => throw new NotImplementedException();

        public bool IsInterface => throw new NotImplementedException();

        public bool IsStruct => throw new NotImplementedException();

        public bool IsAbstract => throw new NotImplementedException();

        public bool IsSealed => throw new NotImplementedException();

        public FrameworkKinds Kind => throw new NotImplementedException();

        public IEnumerable<IAttributeInfo> Attributes => throw new NotImplementedException();

        public IEnumerable<ITypeInfo> Implements => throw new NotImplementedException();

        public IEnumerable<ITypeInfo> BaseTypes => throw new NotImplementedException();

        public bool IsValueDefined => throw new NotImplementedException();

        public bool IsWellKnownConstType => throw new NotImplementedException();

        public bool ImplementsWellKnownConstType => throw new NotImplementedException();

        public WellKnownConstTypes WellKnownConstTypes => throw new NotImplementedException();

        /// <summary>
        /// Creates a new instance of the <see cref="ConstTypeArgInfoImpl"/> class.
        /// </summary>
        public ConstTypeArgInfoImpl()
        {
        }
    }
}