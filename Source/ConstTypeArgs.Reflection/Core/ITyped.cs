using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="ITyped"/> interface is used to provide information about
/// the type of a framework-related code element.
/// </summary>
[EditorBrowsable(Never)]
public interface ITyped
{
    /// <summary>
    /// Gets the code element's type.
    /// </summary>
    Type Type
    {
        [return: DynamicallyAccessedMembers(
            PublicMethods | PublicProperties | PublicFields | Interfaces)]
        get;
    }
}
