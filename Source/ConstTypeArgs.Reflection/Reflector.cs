using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

namespace ConstTypeArgs.Reflection;

// #TODO: Determine if there are use cases for converting Reflector into a singleton
//        to allow extension methods to be added in other libraries.

/// <summary>
/// The <see cref="Reflector"/> class provides methods for reflecting on types for
/// Const Type Args framework mechanics.
/// </summary>
public sealed partial class Reflector
{
    /// <summary>
    /// A message that warns the user that a type implements multiple holders.
    /// </summary>
    private const string ImplementsMultipleHoldersWarningMsg = """
                                    The type {0} implements multiple holders.
                                    This will cause ambiguity in many reflection operations & should be avoided.
                                    """;

    /// <summary>
    /// The name of the <see cref="IConstTypeArg{T}.Value"/> member.
    /// </summary>
    private const string ConstTypeArgValueMember= "Value";

    /// <summary>
    /// The <see cref="Type{T}"/> class provides <see cref="Reflector"/> a caching mechanism
    /// for <typeparamref name="T"/> reflection information.
    /// </summary>
    /// <typeparam name="T">
    /// The type to cache reflection information for.
    /// </typeparam>
    public sealed partial class Type<[DynamicallyAccessedMembers(Interfaces)] T>
    {
        /// <summary>
        /// The static constructor for the <see cref="Type{T}"/> class.
        /// </summary>
        static Type() { Reflect = new Type<T>(); }

        /// <summary>
        /// The singleton instance of the <see cref="Type{T}"/> class.
        /// </summary>
        internal static readonly Type<T> Reflect;
    }
}
