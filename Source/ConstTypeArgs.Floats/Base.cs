using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Floats;

/// <summary>
/// The <see cref="K_Float"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="Float{K}"/>
/// <seealso cref="K_FloatArray"/>
public interface K_Float
    : K_Unmanaged<float>, K_FloatingPoint<float>, K_SignedNumber<float>;

/// <summary>
/// The <see cref="K_Float{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float, K_Float&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="Float{K}"/>
/// <seealso cref="K_FloatArray{TSelf}"/>
public interface K_Float<TSelf>
    : K_Float, IConstTypeArg<float, TSelf>
    where TSelf : K_Float<TSelf>;

/// <summary>
/// The <see cref="K_FloatArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="FloatArray{K}"/>
/// <seealso cref="K_Float"/>
public interface K_FloatArray
    : K_Array<float>;

/// <summary>
/// The <see cref="K_FloatArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float[], K_FloatArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="FloatArray{K}"/>
/// <seealso cref="K_Float{TSelf}"/>
public interface K_FloatArray<TSelf>
    : K_FloatArray, IConstTypeArg<float[], TSelf>
    where TSelf : K_FloatArray<TSelf>;

/// <summary>
/// The <see cref="Float{K}"/> class provides a const argument provider that
/// wraps the <see langword="float"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="FloatArray{K}"/>
/// <seealso cref="K_Float"/>
/// <seealso cref="K_Float{TSelf}"/>
public class Float<K> : K<float, K>, K_Float
    where K : K_Float
{ public static float Value => K.Value; }

/// <summary>
/// The <see cref="FloatArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="float"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Float{K}"/>
/// <seealso cref="K_Float"/>
public class FloatArray<K> : K<float[], K>, K_FloatArray
    where K : K_FloatArray
{ public static float[] Value => K.Value; }
