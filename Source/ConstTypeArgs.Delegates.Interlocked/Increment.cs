using ConstTypeArgs.Delegates.Funcs;

using IntLock = System.Threading.Interlocked;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Interlocked;

#region Int32

/// <summary>
/// The <see cref="IncrementInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-int32@)">
/// Interlocked.Increment(ref int)</see> which increments the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct IncrementInt32 : K_RefFunction<int, int>
{ public static RefFunction<int, int> Value => IntLock.Increment; }

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="IncrementUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-uint32@)">
/// Interlocked.Increment(ref uint)</see> which increments the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct IncrementUInt32 : K_RefFunction<uint, uint>
{ public static RefFunction<uint, uint> Value => IntLock.Increment; }

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="IncrementInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-int64@)">
/// Interlocked.Increment(ref long)</see> which increments the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct IncrementInt64 : K_RefFunction<long, long>
{ public static RefFunction<long, long> Value => IntLock.Increment; }

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="IncrementUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.increment#system-threading-interlocked-increment(system-uint64@)">
/// Interlocked.Increment(ref ulong)</see> which increments the value of the first parameter as an atomic operation.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct IncrementUInt64 : K_RefFunction<ulong, ulong>
{ public static RefFunction<ulong, ulong> Value => IntLock.Increment; }

#endregion UInt64
