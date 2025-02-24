using ConstTypeArgs.Delegates.Funcs;
using ConstTypeArgs.Ints;
using ConstTypeArgs.Longs;
using ConstTypeArgs.Uints;
using ConstTypeArgs.Ulongs;

using IntLock = System.Threading.Interlocked;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Delegates.Interlocked;

#region Int32

/// <summary>
/// The <see cref="AndInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-int32@-system-int32)">
/// Interlocked.And(ref int, int)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndInt32 : K_RefFunction<int, int, int>
{ public static RefFunction<int, int, int> Value => IntLock.And; }

/// <summary>
/// The <see cref="AndInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-int32@-system-int32)">
/// Interlocked.And(ref int, int)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the AND operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndInt32<K> : K_RefFunction<int, int>
    where K : K_Int
{
    public static RefFunction<int, int> Value => static (ref int location)
        => IntLock.And(ref location, K.Value);
}

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="AndUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-uint32@-system-uint32)">
/// Interlocked.And(ref uint, uint)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndUInt32 : K_RefFunction<uint, uint, uint>
{ public static RefFunction<uint, uint, uint> Value => IntLock.And; }

/// <summary>
/// The <see cref="AndUInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-uint32@-system-uint32)">
/// Interlocked.And(ref uint, uint)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the AND operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndUInt32<K> : K_RefFunction<uint, uint>
    where K : K_Uint
{
    public static RefFunction<uint, uint> Value => static (ref uint location)
        => IntLock.And(ref location, K.Value);
}

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="AndInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-int64@-system-int64)">
/// Interlocked.And(ref long, long)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndInt64 : K_RefFunction<long, long, long>
{ public static RefFunction<long, long, long> Value => IntLock.And; }

/// <summary>
/// The <see cref="AndInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-int64@-system-int64)">
/// Interlocked.And(ref long, long)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the AND operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndInt64<K> : K_RefFunction<long, long>
    where K : K_Long
{
    public static RefFunction<long, long> Value => static (ref long location)
        => IntLock.And(ref location, K.Value);
}

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="AndUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-uint64@-system-uint64)">
/// Interlocked.And(ref ulong, ulong)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndUInt64 : K_RefFunction<ulong, ulong, ulong>
{ public static RefFunction<ulong, ulong, ulong> Value => IntLock.And; }

/// <summary>
/// The <see cref="AndUInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-and(system-uint64@-system-uint64)">
/// Interlocked.And(ref ulong, ulong)</see> which is an atomic operation that performs a bitwise AND operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the AND operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AndUInt64<K> : K_RefFunction<ulong, ulong>
    where K : K_Ulong
{
    public static RefFunction<ulong, ulong> Value => static (ref ulong location)
        => IntLock.And(ref location, K.Value);
}

#endregion UInt64