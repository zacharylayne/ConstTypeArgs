using ConstTypeArgs.Delegates.Funcs;
using ConstTypeArgs.Doubles;
using ConstTypeArgs.Floats;
using ConstTypeArgs.Ints;
using ConstTypeArgs.Longs;
using ConstTypeArgs.Nints;
using ConstTypeArgs.Nuints;
using ConstTypeArgs.Uints;
using ConstTypeArgs.Ulongs;

using IntLock = System.Threading.Interlocked;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Delegates.Interlocked;

#region Int32

/// <summary>
/// The <see cref="CompareExchangeInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int32@-system-int32-system-int32)">
/// Interlocked.CompareExchange(ref int, int, int)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeInt32 : K_RefFunction<int, int, int, int>
{ public static RefFunction<int, int, int, int> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int32@-system-int32-system-int32)">
/// Interlocked.CompareExchange(ref int, int, int)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeInt32<K> : K_RefFunction<int, int, int>
    where K : K_Int
{
    public static RefFunction<int, int, int> Value => static (ref int location, int value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_Int32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int32@-system-int32-system-int32)">
/// Interlocked.CompareExchange(ref int, int, int)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_Int32<K> : K_RefFunction<int, int, int>
    where K : K_Int
{
    public static RefFunction<int, int, int> Value => static (ref int location, int comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_Int32{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int32@-system-int32-system-int32)">
/// Interlocked.CompareExchange(ref int, int, int)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_Int32<KCompare, KExchange> : K_RefFunction<int, int>
    where KCompare : K_Int where KExchange : K_Int
{
    public static RefFunction<int, int> Value => static (ref int location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="CompareExchangeUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint32@-system-uint32-system-uint32)">
/// Interlocked.CompareExchange(ref uint, uint, uint)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeUInt32 : K_RefFunction<uint, uint, uint, uint>
{ public static RefFunction<uint, uint, uint, uint> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeUInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint32@-system-uint32-system-uint32)">
/// Interlocked.CompareExchange(ref uint, uint, uint)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeUInt32<K> : K_RefFunction<uint, uint, uint>
    where K : K_Uint
{
    public static RefFunction<uint, uint, uint> Value => static (ref uint location, uint value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_UInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint32@-system-uint32-system-uint32)">
/// Interlocked.CompareExchange(ref uint, uint, uint)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_UInt32<K> : K_RefFunction<uint, uint, uint>
    where K : K_Uint
{
    public static RefFunction<uint, uint, uint> Value => static (ref uint location, uint comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_UInt32{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint32@-system-uint32-system-uint32)">
/// Interlocked.CompareExchange(ref uint, uint, uint)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_UInt32<KCompare, KExchange> : K_RefFunction<uint, uint>
    where KCompare : K_Uint where KExchange : K_Uint
{
    public static RefFunction<uint, uint> Value => static (ref uint location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="CompareExchangeInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int64@-system-int64-system-int64)">
/// Interlocked.CompareExchange(ref long, long, long)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeInt64 : K_RefFunction<long, long, long, long>
{ public static RefFunction<long, long, long, long> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int64@-system-int64-system-int64)">
/// Interlocked.CompareExchange(ref long, long, long)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeInt64<K> : K_RefFunction<long, long, long>
    where K : K_Long
{
    public static RefFunction<long, long, long> Value => static (ref long location, long value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_Int64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int64@-system-int64-system-int64)">
/// Interlocked.CompareExchange(ref long, long, long)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_Int64<K> : K_RefFunction<long, long, long>
    where K : K_Long
{
    public static RefFunction<long, long, long> Value => static (ref long location, long comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_Int64{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-int64@-system-int64-system-int64)">
/// Interlocked.CompareExchange(ref long, long, long)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_Int64<KCompare, KExchange> : K_RefFunction<long, long>
    where KCompare : K_Long where KExchange : K_Long
{
    public static RefFunction<long, long> Value => static (ref long location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="CompareExchangeUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint64@-system-uint64-system-uint64)">
/// Interlocked.CompareExchange(ref ulong, ulong, ulong)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeUInt64 : K_RefFunction<ulong, ulong, ulong, ulong>
{ public static RefFunction<ulong, ulong, ulong, ulong> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeUInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint64@-system-uint64-system-uint64)">
/// Interlocked.CompareExchange(ref ulong, ulong, ulong)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeUInt64<K> : K_RefFunction<ulong, ulong, ulong>
    where K : K_Ulong
{
    public static RefFunction<ulong, ulong, ulong> Value => static (ref ulong location, ulong value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_UInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint64@-system-uint64-system-uint64)">
/// Interlocked.CompareExchange(ref ulong, ulong, ulong)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_UInt64<K> : K_RefFunction<ulong, ulong, ulong>
    where K : K_Ulong
{
    public static RefFunction<ulong, ulong, ulong> Value => static (ref ulong location, ulong comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_UInt64{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uint64@-system-uint64-system-uint64)">
/// Interlocked.CompareExchange(ref ulong, ulong, ulong)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_UInt64<KCompare, KExchange> : K_RefFunction<ulong, ulong>
    where KCompare : K_Ulong where KExchange : K_Ulong
{
    public static RefFunction<ulong, ulong> Value => static (ref ulong location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion UInt64

#region Single

/// <summary>
/// The <see cref="CompareExchangeSingle"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-single@-system-single-system-single)">
/// Interlocked.CompareExchange(ref float, float, float)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeSingle : K_RefFunction<float, float, float, float>
{ public static RefFunction<float, float, float, float> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeSingle{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-single@-system-single-system-single)">
/// Interlocked.CompareExchange(ref float, float, float)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeSingle<K> : K_RefFunction<float, float, float>
    where K : K_Float
{
    public static RefFunction<float, float, float> Value => static (ref float location, float value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_Single{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-single@-system-single-system-single)">
/// Interlocked.CompareExchange(ref float, float, float)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_Single<K> : K_RefFunction<float, float, float>
    where K : K_Float
{
    public static RefFunction<float, float, float> Value => static (ref float location, float comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_Single{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-single@-system-single-system-single)">
/// Interlocked.CompareExchange(ref float, float, float)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_Single<KCompare, KExchange> : K_RefFunction<float, float>
    where KCompare : K_Float where KExchange : K_Float
{
    public static RefFunction<float, float> Value => static (ref float location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion Single

#region Double

/// <summary>
/// The <see cref="CompareExchangeDouble"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-double@-system-double-system-double)">
/// Interlocked.CompareExchange(ref double, double, double)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeDouble : K_RefFunction<double, double, double, double>
{ public static RefFunction<double, double, double, double> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeDouble{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-double@-system-double-system-double)">
/// Interlocked.CompareExchange(ref double, double, double)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeDouble<K> : K_RefFunction<double, double, double>
    where K : K_Double
{
    public static RefFunction<double, double, double> Value => static (ref double location, double value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_Double{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-double@-system-double-system-double)">
/// Interlocked.CompareExchange(ref double, double, double)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_Double<K> : K_RefFunction<double, double, double>
    where K : K_Double
{
    public static RefFunction<double, double, double> Value => static (ref double location, double comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_Double{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-double@-system-double-system-double)">
/// Interlocked.CompareExchange(ref double, double, double)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_Double<KCompare, KExchange> : K_RefFunction<double, double>
    where KCompare : K_Double where KExchange : K_Double
{
    public static RefFunction<double, double> Value => static (ref double location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion Double

#region IntPtr

/// <summary>
/// The <see cref="CompareExchangeIntPtr"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-intptr@-system-intptr-system-intptr)">
/// Interlocked.CompareExchange(ref nint, nint, nint)</see> which compares the first parameter with the third,
/// and if equal, replaces the first parameter with the second as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeIntPtr : K_RefFunction<nint, nint, nint, nint>
{ public static RefFunction<nint, nint, nint, nint> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeIntPtr{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-intptr@-system-intptr-system-intptr)">
/// Interlocked.CompareExchange(ref nint, nint, nint)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeIntPtr<K> : K_RefFunction<nint, nint, nint>
    where K : K_Nint
{
    public static RefFunction<nint, nint, nint> Value => static (ref nint location, nint value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_IntPtr{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-intptr@-system-intptr-system-intptr)">
/// Interlocked.CompareExchange(ref nint, nint, nint)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_IntPtr<K> : K_RefFunction<nint, nint, nint>
    where K : K_Nint
{
    public static RefFunction<nint, nint, nint> Value => static (ref nint location, nint comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_IntPtr{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-intptr@-system-intptr-system-intptr)">
/// Interlocked.CompareExchange(ref nint, nint, nint)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_IntPtr<KCompare, KExchange> : K_RefFunction<nint, nint>
    where KCompare : K_Nint where KExchange : K_Nint
{
    public static RefFunction<nint, nint> Value => static (ref nint location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion IntPtr

#region UIntPtr

/// <summary>
/// The <see cref="CompareExchangeUIntPtr"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uintptr@-system-uintptr-system-uintptr)">
/// Interlocked.CompareExchange(ref nuint, nuint, nuint)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeUIntPtr : K_RefFunction<nuint, nuint, nuint, nuint>
{ public static RefFunction<nuint, nuint, nuint, nuint> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeUIntPtr{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uintptr@-system-uintptr-system-uintptr)">
/// Interlocked.CompareExchange(ref nuint, nuint, nuint)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeUIntPtr<K> : K_RefFunction<nuint, nuint, nuint>
    where K : K_Nuint
{
    public static RefFunction<nuint, nuint, nuint> Value => static (ref nuint location, nuint value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_UIntPtr{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uintptr@-system-uintptr-system-uintptr)">
/// Interlocked.CompareExchange(ref nuint, nuint, nuint)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_UIntPtr<K> : K_RefFunction<nuint, nuint, nuint>
    where K : K_Nuint
{
    public static RefFunction<nuint, nuint, nuint> Value => static (ref nuint location, nuint comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_UIntPtr{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-uintptr@-system-uintptr-system-uintptr)">
/// Interlocked.CompareExchange(ref nuint, nuint, nuint)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_UIntPtr<KCompare, KExchange> : K_RefFunction<nuint, nuint>
    where KCompare : K_Nuint where KExchange : K_Nuint
{
    public static RefFunction<nuint, nuint> Value => static (ref nuint location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion UIntPtr

#region Object

/// <summary>
/// The <see cref="CompareExchangeObject"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-object@-system-object-system-object)">
/// Interlocked.CompareExchange(ref object, object, object)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeObject : K_RefFunction<object?, object?, object?, object?>
{ public static RefFunction<object?, object?, object?, object?> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeObject{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-object@-system-object-system-object)">
/// Interlocked.CompareExchange(ref object, object, object)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeObject<K> : K_RefFunction<object?, object?, object?>
    where K : Core.K_Class<object>
{
    public static RefFunction<object?, object?, object?> Value => static (ref object? location, object? value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_Object{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-object@-system-object-system-object)">
/// Interlocked.CompareExchange(ref object, object, object)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_Object<K> : K_RefFunction<object?, object?, object?>
    where K : Core.K_Class<object>
{
    public static RefFunction<object?, object?, object?> Value => static (ref object? location,object? comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_Object{KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(system-object@-system-object-system-object)">
/// Interlocked.CompareExchange(ref object, object, object)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_Object<KCompare, KExchange> : K_RefFunction<object?, object?>
    where KCompare : Core.K_Class<object> where KExchange : Core.K_Class<object>
{
    public static RefFunction<object?, object?> Value => static (ref object? location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion Object

#region T

/// <summary>
/// The <see cref="CompareExchangeT{T}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(-0@-0-0)">
/// Interlocked.CompareExchange(ref T, T, T)</see> that is an atomic operation that compares the value of the first parameter
/// with the third,
/// and if equal, replaces the first parameter's value with the second .
/// The first parameter's original value is returned.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be compared and exchanged.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeT<T> : K_RefFunction<T, T, T, T>
    where T : class?
{ public static RefFunction<T, T, T, T> Value => IntLock.CompareExchange; }

/// <summary>
/// The <see cref="CompareK_ExchangeT{T, K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(-0@-0-0)">
/// Interlocked.CompareExchange(ref T, T, T)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="K"/>.
/// If equal, the first parameter's value is replaced with the value of the second as an atomic operation.
/// The original value is returned.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be compared and exchanged.
/// </typeparam>
/// <typeparam name="K">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeT<T, K> : K_RefFunction<T, T, T>
    where T : class where K : IConstTypeArg<T>
{
    public static RefFunction<T, T, T> Value => static (ref T location, T value)
        => IntLock.CompareExchange(ref location, value, K.Value);
}

/// <summary>
/// The <see cref="CompareExchangeK_T{T, K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(-0@-0-0)">
/// Interlocked.CompareExchange(ref T, T, T)</see> that is an atomic operation that compares the value of the first parameter
/// with the second.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="K"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be compared and exchanged.
/// </typeparam>
/// <typeparam name="K">
/// The const type argument containing the value to set as the third parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareExchangeK_T<T, K> : K_RefFunction<T, T, T>
    where T : class where K : IConstTypeArg<T>
{
    public static RefFunction<T, T, T> Value => static (ref T location, T comparand)
        => IntLock.CompareExchange(ref location, K.Value, comparand);
}

/// <summary>
/// The <see cref="CompareK_ExchangeK_T{T, KCompare, KExchange}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.compareexchange#system-threading-interlocked-compareexchange(-0@-0-0)">
/// Interlocked.CompareExchange(ref T, T, T)</see> that is an atomic operation that compares the value of the first parameter
/// to the value of the const type argument <typeparamref name="KCompare"/>.
/// If equal, the first parameter's value is replaced with the value of the const type argument <typeparamref name="KExchange"/>.
/// The original value is returned.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be compared and exchanged.
/// </typeparam>
/// <typeparam name="KCompare">
/// The const type argument containing the value to compare with the third parameter.
/// </typeparam>
/// <typeparam name="KExchange">
/// The const type argument containing the value to exchange with the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct CompareK_ExchangeK_T<T, KCompare, KExchange> : K_RefFunction<T, T>
    where T : class where KCompare : IConstTypeArg<T> where KExchange : IConstTypeArg<T>
{
    public static RefFunction<T, T> Value => static (ref T location)
        => IntLock.CompareExchange(ref location, KExchange.Value, KCompare.Value);
}

#endregion T
