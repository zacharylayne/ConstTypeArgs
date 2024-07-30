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
/// The <see cref="OrInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.or#system-threading-interlocked-or(system-int32@-system-int32)">
/// Interlocked.Or(ref int, int)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrInt32 : K_RefFunction<int, int, int>
{ public static RefFunction<int, int, int> Value => IntLock.Or; }

/// <summary>
/// The <see cref="OrInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.or#system-threading-interlocked-or(system-int32@-system-int32)">
/// Interlocked.Or(ref int, int)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the OR operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrInt32<K> : K_RefFunction<int, int>
    where K : K_Int
{
    public static RefFunction<int, int> Value => static (ref int location)
        => IntLock.Or(ref location, K.Value);
}

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="OrUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.or#system-threading-interlocked-or(system-uint32@-system-uint32)">
/// Interlocked.Or(ref uint, uint)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrUInt32 : K_RefFunction<uint, uint, uint>
{ public static RefFunction<uint, uint, uint> Value => IntLock.Or; }

/// <summary>
/// The <see cref="OrUInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.or#system-threading-interlocked-or(system-uint32@-system-uint32)">
/// Interlocked.Or(ref uint, uint)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the OR operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrUInt32<K> : K_RefFunction<uint, uint>
    where K : K_Uint
{
    public static RefFunction<uint, uint> Value => static (ref uint location)
        => IntLock.Or(ref location, K.Value);
}

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="OrInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-or(system-int64@-system-int64)">
/// Interlocked.Or(ref long, long)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrInt64 : K_RefFunction<long, long, long>
{ public static RefFunction<long, long, long> Value => IntLock.Or; }

/// <summary>
/// The <see cref="OrInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-or(system-int64@-system-int64)">
/// Interlocked.Or(ref long, long)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the OR operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrInt64<K> : K_RefFunction<long, long>
    where K : K_Long
{
    public static RefFunction<long, long> Value => static (ref long location)
        => IntLock.Or(ref location, K.Value);
}

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="OrUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-or(system-uint64@-system-uint64)">
/// Interlocked.And(ref ulong, ulong)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the second and returns the original value.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrUInt64 : K_RefFunction<ulong, ulong, ulong>
{ public static RefFunction<ulong, ulong, ulong> Value => IntLock.Or; }

/// <summary>
/// The <see cref="OrUInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.and#system-threading-interlocked-or(system-uint64@-system-uint64)">
/// Interlocked.And(ref ulong, ulong)</see> which is an atomic operation that performs a bitwise OR operation on the value of the first parameter
/// with the value of the const type argument <typeparamref name="K"/> and
/// returns the original value.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the second value for the OR operation.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct OrUInt64<K> : K_RefFunction<ulong, ulong>
    where K : K_Ulong
{
    public static RefFunction<ulong, ulong> Value => static (ref ulong location)
        => IntLock.Or(ref location, K.Value);
}

#endregion UInt64