#pragma warning disable RCS1154 // Sort enum members

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="FrameworkKinds"/> enumeration provides flags for specifying a framework kind,
/// such as const type argument, holder, or interface, const type parameter, argument consumer,
/// and other kinds.
/// </summary>
[Flags]
public enum FrameworkKinds
{
    /// <summary>
    /// The kind is not a defined kind of type, such as a const type argument, holder, interface,
    /// argument consumer, const type parameter, or other defined kinds.
    /// </summary>
    Undefined            = 0,

    /// <summary>
    /// The code element is not relevant to framework mechanics and has no identifiable kind.
    /// </summary>
    None                 = int.MaxValue,

    /// <summary>
    /// The type is a core type defined in the ConstTypeArgs.Core library.
    /// </summary>
    CoreType             = 1 << 0,

    /// <summary>
    /// The type is a const type argument.
    /// </summary>
    ConstTypeArg         = 1 << 4,

    /// <summary>
    /// The type is a const type interface.
    /// </summary>
    ConstTypeInterface   = 1 << 5,

    /// <summary>
    /// The type is a const type holder <em>(i.e. a const type argument
    /// wrapping another const type argument)</em>.
    /// </summary>
    ConstTypeHolder      = 1 << 6,

    /// <summary>
    /// The type is a const type discard <em>(i.e. a const type argument
    /// signifying it provides no value)</em>.
    /// </summary>
    ConstTypeDiscard     = 1 << 7,

    /// <summary>
    /// The type is a const type argument.
    /// </summary>
    ConstType            = CoreType | ConstTypeArg | ConstTypeInterface | ConstTypeHolder | ConstTypeDiscard,

    /// <summary>
    /// The type is an argument consumer.
    /// </summary>
    ConsumerType         = 1 << 17,

    /// <summary>
    /// The method is a argument consumer.
    /// </summary>
    ConsumerMethod       = 1 << 18,

    /// <summary>
    /// The generic is an open argument consumer, meaning that const type arguments have not been supplied for
    /// all of the generic's const type parameters.
    /// </summary>
    OpenConsumer         = 1 << 19,

    /// <summary>
    /// The generic is a closed argument consumer, meaning that const type arguments have been supplied for
    /// all of the generic's const type parameters.
    /// </summary>
    /// <remarks>
    /// Closed argument consumers <em>MAY</em> still be open generics <em>IF</em> they have
    /// non-const type generic parameters that have not been supplied with type arguments.
    /// </remarks>
    ClosedConsumer       = 1 << 20,

    /// <summary>
    /// The generic type is an open argument consumer, meaning that const type arguments have not been supplied for
    /// all of the type's const type parameters.
    /// </summary>
    OpenConsumerType     = OpenConsumer   | ConsumerType,

    /// <summary>
    /// The generic type is a closed argument consumer, meaning that const type arguments have been supplied for
    /// all of the type's const type parameters.
    /// </summary>
    /// <remarks>
    /// Types of closed argument consumers <em>MAY</em> still be open generic types <em>IF</em> they have
    /// non-const type generic type parameters that have not been supplied with type arguments.
    /// </remarks>
    ClosedConsumerType   = ClosedConsumer | ConsumerType,

    /// <summary>
    /// The generic method an open argument consumer, meaning that const type arguments have not been supplied for
    /// all of the method's const type parameters.
    /// </summary>
    OpenConsumerMethod   = OpenConsumer   | ConsumerMethod,

    /// <summary>
    /// The generic method is a closed argument consumer, meaning that const type arguments have been supplied for
    /// all of the method's const type parameters.
    /// </summary>
    /// <remarks>
    /// Methods that are closed argument consumers <em>MAY</em> still be open generic methods <em>IF</em> they have
    /// non-const type generic parameters that have not been supplied with type arguments.
    /// </remarks>
    ClosedConsumerMethod = ClosedConsumer | ConsumerMethod,

    /// <summary>
    /// The generic is an argument consumer <em>(i.e. a generic with one or more const type parameters)</em>.
    /// </summary>
    Consumer             = ConsumerType | ConsumerMethod | ClosedConsumer | OpenConsumer,

    /// <summary>
    /// The type is a generic parameter.
    /// </summary>
    GenericParameter     = 1 << 29,

    /// <summary>
    /// The type is an exception.
    /// </summary>
    Exception            = 1 << 30,

    /// <summary>
    /// The type is an attribute.
    /// </summary>
    Attribute            = 1 << 31,

    /// <summary>
    /// The type is a kind of type that is integral to the ConstTypeArgs framework,
    /// but is not a const type itself.
    /// </summary>
    NotConstType         = Consumer | GenericParameter | Exception| Attribute,

    /// <summary>
    /// Identifies all kinds of types that are integral concepts within the ConstTypeArgs framework.
    /// </summary>
    All                  = ConstType | NotConstType,
}
