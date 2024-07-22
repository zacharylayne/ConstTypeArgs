using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Floats;

/// <summary>
/// The <see cref="K_Float"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="float"/> const type arguments
/// rather than <see cref="K_Unmanaged{T}">K_Unmanaged&lt;float&gt;</see>,
/// <see cref="K_FloatingPoint{T}">K_FloatingPoint&lt;float&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_SignedNumber&lt;float&gt;</see>,
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;float&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Float{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="Float{K}"/>
/// <seealso cref="K_FloatArray"/>
/// <seealso cref="__"/>
public interface K_Float
    : K_Unmanaged<float>, K_FloatingPoint<float>, K_SignedNumber<float>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Float, IConstTypeArg<float?>;
}

/// <summary>
/// The <see cref="K_Float{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float, K_Float&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="float"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Float"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="Float{K}"/>
/// <seealso cref="K_FloatArray{TSelf}"/>
public interface K_Float<TSelf> : K_Float, IConstTypeArg<float, TSelf>
    where TSelf : K_Float<TSelf>;

/// <summary>
/// The <see cref="K_FloatArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="float[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;float&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;float[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_FloatArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="FloatArray{K}"/>
/// <seealso cref="K_Float"/>
/// <seealso cref="__"/>
public interface K_FloatArray : K_Array<float>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_FloatArray;
}

/// <summary>
/// The <see cref="K_FloatArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;float[], K_FloatArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="float[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_FloatArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.single">
/// System.Single</seealso>
/// <seealso cref="FloatArray{K}"/>
/// <seealso cref="K_Float{TSelf}"/>
public interface K_FloatArray<TSelf> : K_FloatArray, IConstTypeArg<float[], TSelf>
    where TSelf : K_FloatArray<TSelf>;

/// <summary>
/// The <see cref="Float{K}"/> class provides a const argument provider that
/// wraps the <see langword="float"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Float"/>
/// <seealso cref="FloatArray{K}"/>
public abstract class Float<K> : K<float, K>, K_Float
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
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_FloatArray"/>
/// <seealso cref="Float{K}"/>
public abstract class FloatArray<K> : K<float[], K>, K_FloatArray
    where K : K_FloatArray
{ public static float[] Value => K.Value; }
