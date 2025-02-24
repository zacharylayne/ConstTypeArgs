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
/// The <see cref="AddInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-int32@-system-int32)">
/// Interlocked.Add(ref int, int)</see> which is an atomic operation that adds the second parameter
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddInt32 : K_RefFunction<int, int, int>
{ public static RefFunction<int, int, int> Value => IntLock.Add; }

/// <summary>
/// The <see cref="AddK_Int32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-int32@-system-int32)">
/// Interlocked.Add(ref int, int)</see> which is an atomic operation that adds the value of the const type argument <typeparamref name="K"/>
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to add to the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddK_Int32<K> : K_RefFunction<int, int>
    where K : K_Int
{
    public static RefFunction<int, int> Value => static (ref int location)
        => IntLock.Add(ref location, K.Value);
}

#endregion Int32

#region UInt32

/// <summary>
/// The <see cref="AddUInt32"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-uint32@-system-uint32)">
/// Interlocked.Add(ref uint, uint)</see> which is an atomic operation that adds the second parameter
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddUInt32 : K_RefFunction<uint, uint, uint>
{ public static RefFunction<uint, uint, uint> Value => IntLock.Add; }

/// <summary>
/// The <see cref="AddK_UInt32{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-uint32@-system-uint32)">
/// Interlocked.Add(ref uint, uint)</see> which is an atomic operation that adds the value of the const type argument <typeparamref name="K"/>
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to add to the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddK_UInt32<K> : K_RefFunction<uint, uint>
    where K : K_Uint
{
    public static RefFunction<uint, uint> Value => static (ref uint location)
        => IntLock.Add(ref location, K.Value);
}

#endregion UInt32

#region Int64

/// <summary>
/// The <see cref="AddInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-int64@-system-int64)">
/// Interlocked.Add(ref long, long)</see> which is an atomic operation that adds the second parameter
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddInt64 : K_RefFunction<long, long, long>
{ public static RefFunction<long, long, long> Value => IntLock.Add; }

/// <summary>
/// The <see cref="AddK_Int64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-int64@-system-int64)">
/// Interlocked.Add(ref long, long)</see> which is an atomic operation that adds the value of the const type argument <typeparamref name="K"/>
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to add to the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddK_Int64<K> : K_RefFunction<long, long>
    where K : K_Long
{
    public static RefFunction<long, long> Value => static (ref long location)
        => IntLock.Add(ref location, K.Value);
}

#endregion Int64

#region UInt64

/// <summary>
/// The <see cref="AddUInt64"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-uint64@-system-uint64)">
/// Interlocked.Add(ref ulong, ulong)</see> which is an atomic operation that adds the second parameter
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddUInt64 : K_RefFunction<ulong, ulong, ulong>
{ public static RefFunction<ulong, ulong, ulong> Value => IntLock.Add; }

/// <summary>
/// The <see cref="AddK_UInt64{K}"/> readonly struct provides a const type argument equal to
/// a thread-safe <see href="https://learn.microsoft.com/dotnet/api/system.threading.interlocked.add#system-threading-interlocked-add(system-uint64@-system-uint64)">
/// Interlocked.Add(ref ulong, ulong)</see> which is an atomic operation that adds the value of the const type argument <typeparamref name="K"/>
/// to the value of the first and returns the new value that was stored in the first parameter.
/// </summary>
/// <typeparam name="K">
/// The const type argument containing the value to add to the first parameter.
/// </typeparam>
/// <exception cref="NullReferenceException">
/// Thrown when calling the method <see cref="Value"/> provides and the address of the first argument
/// is equal to a <see langword="null"/> pointer.
/// </exception>
/// <threadsafety static="true" instance="true"/>
public readonly struct AddK_UInt64<K> : K_RefFunction<ulong, ulong>
    where K : K_Ulong
{
    public static RefFunction<ulong, ulong> Value => static (ref ulong location)
        => IntLock.Add(ref location, K.Value);
}

#endregion UInt64
