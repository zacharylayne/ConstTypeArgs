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
/// The <see cref="ExchangeInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-int32@-system-int32)">
/// Interlocked.Exchange(ref int, int)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeInt32 : K_RefFunction<int, int, int>
{ public static RefFunction<int, int, int> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-int32@-system-int32)">
/// Interlocked.Exchange(ref int, int)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeInt32"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeInt32<K> : K_RefFunction<int, int>
    where K : K_Int
{
    public static RefFunction<int, int> Value => static (ref int location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="ExchangeUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-uint32@-system-uint32)">
/// Interlocked.Exchange(ref uint, uint)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-uint32@)">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeUInt32 : K_RefFunction<uint, uint, uint>
{ public static RefFunction<uint, uint, uint> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeUInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-int32@-system-int32)">
/// Interlocked.Exchange(ref int, int)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeUInt32<K> : K_RefFunction<uint, uint>
    where K : K_Uint
{
    public static RefFunction<uint, uint> Value => static (ref uint location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="ExchangeInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-int64@-system-uint64)">
/// Interlocked.Exchange(ref long, long)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeInt64 : K_RefFunction<long, long, long>
{ public static RefFunction<long, long, long> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-int64@-system-uint64)">
/// Interlocked.Exchange(ref long, long)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeInt64<K> : K_RefFunction<long, long>
    where K : K_Long
{
    public static RefFunction<long, long> Value => static (ref long location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="ExchangeUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-uint64@-system-uint64)">
/// Interlocked.Exchange(ref ulong, ulong)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeUInt64 : K_RefFunction<ulong, ulong, ulong>
{ public static RefFunction<ulong, ulong, ulong> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeUInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-int64@-system-uint64)">
/// Interlocked.Exchange(ref long, long)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeUInt64<K> : K_RefFunction<ulong, ulong>
    where K : K_Ulong
{
    public static RefFunction<ulong, ulong> Value => static (ref ulong location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion UInt64

#region Single

/// <summary>
/// The <see cref="ExchangeSingle"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-single@-system-single)">
/// Interlocked.Exchange(ref float, float)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeSingle : K_RefFunction<float, float, float>
{ public static RefFunction<float, float, float> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeSingle{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-single@-system-single)">
/// Interlocked.Exchange(ref float, float)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeSingle<K> : K_RefFunction<float, float>
    where K : K_Float
{
    public static RefFunction<float, float> Value => static (ref float location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion Single

#region Double

/// <summary>
/// The <see cref="ExchangeDouble"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-double@-system-double)">
/// Interlocked.Exchange(ref double, double)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeDouble : K_RefFunction<double, double, double>
{ public static RefFunction<double, double, double> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeDouble{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-double@-system-double)">
/// Interlocked.Exchange(ref double, double)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeDouble<K> : K_RefFunction<double, double>
    where K : K_Double
{
    public static RefFunction<double, double> Value => static (ref double location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion Double

#region IntPtr

/// <summary>
/// The <see cref="ExchangeIntPtr"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-intptr@-system-intptr)">
/// Interlocked.Exchange(ref nint, nint)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeIntPtr : K_RefFunction<nint, nint, nint>
{ public static RefFunction<nint, nint, nint> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeIntPtr{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-intptr@-system-intptr)">
/// Interlocked.Exchange(ref nint, nint)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeIntPtr<K> : K_RefFunction<nint, nint>
    where K : K_Nint
{
    public static RefFunction<nint, nint> Value => static (ref nint location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion IntPtr

#region UIntPtr

/// <summary>
/// The <see cref="ExchangeUIntPtr"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-uintptr@-system-uintptr)">
/// Interlocked.Exchange(ref nuint, nuint)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeUIntPtr : K_RefFunction<nuint, nuint, nuint>
{ public static RefFunction<nuint, nuint, nuint> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeUIntPtr{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see cref="RefFunction{T ,T}"/> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeUIntPtr<K> : K_RefFunction<nuint, nuint>
    where K : K_Nuint
{
    public static RefFunction<nuint, nuint> Value => static (ref nuint location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion UIntPtr

#region Object

/// <summary>
/// The <see cref="ExchangeObject"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-object@-system-object)">
/// Interlocked.Exchange(ref object, object)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeObject{K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeObject : K_RefFunction<object, object, object>
{ public static RefFunction<object, object, object> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeObject{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(system-object@-system-object)">
/// Interlocked.Exchange(ref object, object)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso cref="ExchangeT{T, K}"/>
public readonly struct ExchangeObject<K> : K_RefFunction<object, object>
    where K : Core.K_Class<object>
{
    public static RefFunction<object, object> Value => static (ref object location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion Object

#region T

/// <summary>
/// The <see cref="ExchangeT{T}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(-0@-0)">
/// Interlocked.Exchange(ref T, T)</see> which sets the value of the first parameter to the
/// value of the second and returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be exchanged.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeT{T, K}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
public readonly struct ExchangeT<T> : K_RefFunction<T, T, T>
    where T : class?
{ public static RefFunction<T, T, T> Value => IntLock.Exchange; }

/// <summary>
/// The <see cref="ExchangeObject{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange#system-threading-interlocked-exchange(-0@-0)">
/// Interlocked.Exchange(ref T, T)</see> which sets the value of the first parameter to the
/// the value of the const type argument <typeparamref name="K"/> and
/// returns the original value as an atomic operation.
/// </summary>
/// <typeparam name="T">
/// The type of the value to be exchanged.
/// </typeparam>
/// <typeparam name="K">
/// The const type argument containing the new value.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
/// <seealso cref="ExchangeT{T}"/>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.exchange">
/// System.Threading.Interlocked.Exchange</seealso>
/// <seealso cref="ExchangeInt32"/>
/// <seealso cref="ExchangeInt32{K}"/>
/// <seealso cref="ExchangeUInt32"/>
/// <seealso cref="ExchangeUInt32{K}"/>
/// <seealso cref="ExchangeInt64"/>
/// <seealso cref="ExchangeInt64{K}"/>
/// <seealso cref="ExchangeUInt64"/>
/// <seealso cref="ExchangeUInt64{K}"/>
/// <seealso cref="ExchangeSingle"/>
/// <seealso cref="ExchangeSingle{K}"/>
/// <seealso cref="ExchangeDouble"/>
/// <seealso cref="ExchangeDouble{K}"/>
/// <seealso cref="ExchangeIntPtr"/>
/// <seealso cref="ExchangeIntPtr{K}"/>
/// <seealso cref="ExchangeUIntPtr"/>
/// <seealso cref="ExchangeUIntPtr{K}"/>
/// <seealso cref="ExchangeObject"/>
/// <seealso cref="ExchangeObject{K}"/>
public readonly struct ExchangeT<T, K> : K_RefFunction<T, T>
    where T : class where K : IConstTypeArg<T>
{
    public static RefFunction<T, T> Value => static (ref T location)
        => IntLock.Exchange(ref location, K.Value);
}

#endregion T
