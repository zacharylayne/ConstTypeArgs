using ConstTypeArgs.Delegates.Funcs;

using IntLock = System.Threading.Interlocked;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Interlocked;

#region Int32

/// <summary>
/// The <see cref="DecrementInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-int32@)">
/// Interlocked.Decrement(ref int)</see> which decrements the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct DecrementInt32 : K_RefFunction<int, int>
{ public static RefFunction<int, int> Value => IntLock.Decrement; }

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="DecrementUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-uint32@)">
/// Interlocked.Decrement(ref uint)</see> which decrements the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct DecrementUInt32 : K_RefFunction<uint, uint>
{ public static RefFunction<uint, uint> Value => IntLock.Decrement; }

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="DecrementInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-int64@)">
/// Interlocked.Decrement(ref long)</see> which decrements the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct DecrementInt64 : K_RefFunction<long, long>
{ public static RefFunction<long, long> Value => IntLock.Decrement; }

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="DecrementUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-uint64@)">
/// Interlocked.Decrement(ref ulong)</see> which decrements the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct DecrementUInt64 : K_RefFunction<ulong, ulong>
{ public static RefFunction<ulong, ulong> Value => IntLock.Decrement; }

#endregion UInt64
