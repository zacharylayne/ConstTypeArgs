namespace ConstTypeArgs.Reflection.Attributes;

/// <summary>
/// The <see cref="AttributeTargetKind"/> enumeration specifies what kind of element
/// a custom attribute is targeting.
/// </summary>
public enum AttributeTargetKind
{
    /// <summary>
    /// No target kind specified.
    /// </summary>
    None             = 0,

    /// <summary>
    /// The attribute is applied to an assembly.
    /// </summary>
    Assembly         = AttributeTargets.Assembly,

    /// <summary>
    /// The attribute is applied to a module.
    /// </summary>
    Module           = AttributeTargets.Module,

    /// <summary>
    /// The attribute is applied to a class.
    /// </summary>
    Class            = AttributeTargets.Class,

    /// <summary>
    /// The attribute is applied to a struct.
    /// </summary>
    Struct           = AttributeTargets.Struct,

    /// <summary>
    /// The attribute is applied to an enumeration.
    /// </summary>
    Enum             = AttributeTargets.Enum,

    /// <summary>
    /// The attribute is applied to a constructor.
    /// </summary>
    Constructor = AttributeTargets.Constructor,

    /// <summary>
    /// The attribute is applied to a method.
    /// </summary>
    Method            = AttributeTargets.Method,

    /// <summary>
    /// The attribute is applied to a property.
    /// </summary>
    Property         = AttributeTargets.Property,

    /// <summary>
    /// The attribute is applied to a field.
    /// </summary>
    Field            = AttributeTargets.Field,

    /// <summary>
    /// The attribute is applied to an event.
    /// </summary>
    Event            = AttributeTargets.Event,

    /// <summary>
    /// The attribute is applied to an interface.
    /// </summary>
    Interface        = AttributeTargets.Interface,

    /// <summary>
    /// The attribute is applied to a parameter.
    /// </summary>
    Parameter        = AttributeTargets.Parameter,

    /// <summary>
    /// The attribute is applied to a delegate.
    /// </summary>
    Delegate         = AttributeTargets.Delegate,

    /// <summary>
    /// The attribute is applied to a return value.
    /// </summary>
    ReturnValue      = AttributeTargets.ReturnValue,

    /// <summary>
    /// The attribute is applied to an generic parameter.
    /// </summary>
    GenericParameter = AttributeTargets.GenericParameter
}
