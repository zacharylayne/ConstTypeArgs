using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Ints;

/// <summary>
/// The <see cref="K_Int"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="Int{K}"/>
/// <seealso cref="K_IntArray"/>
public interface K_Int : K_Unmanaged<int>, K_Integer<int>, K_SignedNumber<int>;

/// <summary>
/// The <see cref="K_Int{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int, K_Int&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="Int{K}"/>
/// <seealso cref="K_IntArray{TSelf}"/>
public interface K_Int<TSelf>
    : K_Int, IConstTypeArg<int, TSelf>
    where TSelf : K_Int<TSelf>;

/// <summary>
/// The <see cref="K_IntArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="IntArray{K}"/>
/// <seealso cref="K_Int"/>
public interface K_IntArray
    : K_Array<int>;

/// <summary>
/// The <see cref="K_IntArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int[], K_IntArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="IntArray{K}"/>
/// <seealso cref="K_Int{TSelf}"/>
public interface K_IntArray<TSelf>
    : K_IntArray, IConstTypeArg<int[], TSelf>
    where TSelf : K_IntArray<TSelf>;

/// <summary>
/// The <see cref="Int{K}"/> class provides a const argument provider that
/// wraps the <see langword="int"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="IntArray{K}"/>
/// <seealso cref="K_Int"/>
/// <seealso cref="K_Int{TSelf}"/>
public abstract class Int<K> : K<int, K>, K_Int
    where K : K_Int
{ public static int Value => K.Value; }

/// <summary>
/// The <see cref="IntArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="int"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Int{K}"/>
/// <seealso cref="K_Int"/>
public class IntArray<K> : K<int[], K>, K_IntArray
    where K : K_IntArray
{ public static int[] Value => K.Value; }
