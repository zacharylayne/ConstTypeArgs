using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Converters;

/// <summary>
/// The <see cref="K_Converter{TInput, TOutput}"/> interface  provides a more explicit
/// <c>IConstTypeArg&lt;Converter&lt;TInput, TOutput&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TInput">
/// The type of object that is to be converted.
/// </typeparam>
/// <typeparam name="TOutput">
/// The type the input object is to be converted to.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.converter-2">
/// System.Converter&lt;TInput, TOutput&gt;</seealso>
public interface K_Converter<in TInput, out TOutput>
    : K_Delegate<Converter<TInput, TOutput>>;

/// <summary>
/// The <see cref="K_ConverterArray{TInput, TOutput}"/> interface  provides a more explicit
/// <c>IConstTypeArg&lt;Converter&lt;TInput, TOutput&gt;[]&gt;</c> derived type.
/// </summary>
/// <typeparam name="TInput">
/// The type of object that is to be converted.
/// </typeparam>
/// <typeparam name="TOutput">
/// The type the input object is to be converted to.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.converter-2">
/// System.Converter&lt;TInput, TOutput&gt;</seealso>
public interface K_ConverterArray<in TInput, out TOutput>
    : K_Array<Converter<TInput, TOutput>>;

/// <summary>
/// The <see cref="Converter{TInput, TOutput, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.converter-2">
/// System.Converter&lt;TInput, TOutput&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="TInput">
/// The type of object that is to be converted.
/// </typeparam>
/// <typeparam name="TOutput">
/// The type the input object is to be converted to.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Converter<TInput, TOutput, K>
    : K<Converter<TInput, TOutput>, K>, K_Converter<TInput, TOutput>
    where K : K_Converter<TInput, TOutput>
{ public static Converter<TInput, TOutput> Value => K.Value; }

/// <summary>
/// The <see cref="Converter{TInput, TOutput, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.converter-2">
/// System.Converter&lt;TInput, TOutput&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="TInput">
/// The type of object that is to be converted.
/// </typeparam>
/// <typeparam name="TOutput">
/// The type the input object is to be converted to.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class ConverterArray<TInput, TOutput, K>
    : K<Converter<TInput, TOutput>[], K>, K_ConverterArray<TInput, TOutput>
    where K : K_ConverterArray<TInput, TOutput>
{ public static Converter<TInput, TOutput>[] Value => K.Value; }