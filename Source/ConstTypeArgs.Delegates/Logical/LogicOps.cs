// Ignore Spelling: NAND XNOR Pred NIMPLY
using ConstTypeArgs.Delegates.Predicates;

#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Delegates.Logical;

#region AND

/**
| A     | B     | A AND B |
|-------|-------|---------|
| false | false | false   |
| false | true  | false   |
| true  | false | false   |
| true  | true  | true    |
**/

/// <summary>
/// The <see cref="AND{T, KPred}"/> const type argument provides a predicate that
/// performs a logical AND operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type argument <typeparamref name="KPred"/> and the given input of the type <typeparamref name="T"/>,
/// and provides the static method <see cref="Eval{K}"/> evaluating
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred">
/// The predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
///  <para>
///  The following table shows the result of the AND operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A AND B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>true</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct AND<T, KPred> : K_Predicate<T>
    where KPred : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise AND operation evaluating <typeparamref name="KPred"/> with
    /// the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical AND operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => KPred.Value(arg);
}

/// <summary>
/// The <see cref="AND{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical AND operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if both <typeparamref name="KPred1"/>
/// &amp; <typeparamref name="KPred2"/> evaluate to <see langword="true"/>.
///  <para>
///  The following table shows the result of the AND operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A AND B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>true</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct AND<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise AND operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical AND operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => KPred1.Value(arg) && KPred2.Value(arg);
}

#endregion AND

#region NAND

/**
| A     | B     | A NAND B |
|-------|-------|----------|
| false | false | true     |
| false | true  | true     |
| true  | false | true     |
| true  | true  | false    |
**/

/// <summary>
/// The <see cref="NAND{T, KPred}"/> const type argument provides a predicate that
/// performs a logical NAND operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type argument <typeparamref name="KPred"/> and the given input of the type <typeparamref name="T"/>,
/// and provides the static method <see cref="Eval{K}"/> evaluating
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred">
/// The predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
///  <para>
///  The following table shows the result of the NAND operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A NAND B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>false</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct NAND<T, KPred> : K_Predicate<T>
    where KPred : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise AND operation evaluating <typeparamref name="KPred"/> with
    /// the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical AND operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => (arg) => !KPred.Value(arg);
}

/// <summary>
/// The <see cref="NAND{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical AND operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if at least one of the const type arguments
/// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/> evaluates to <see langword="false"/>.
///  <para>
///  The following table shows the result of the NAND operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A NAND B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>false</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct NAND<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise NAND operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical NAND operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => !(KPred1.Value(arg) && KPred2.Value(arg));
}

#endregion NAND

/// <summary>
/// The <see cref="OR{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical OR operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if at least one of const type arguments
/// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/> evaluates to <see langword="true"/>.
///  <para>
///  The following table shows the result of the OR operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A OR B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>true</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct OR<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise OR operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical OR operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => KPred1.Value(arg) || KPred2.Value(arg);
}

/**
| A     | B     | A XOR B |
|-------|-------|---------|
| false | false | false   |
| false | true  | true    |
| true  | false | true    |
| true  | true  | false   |
**/

/// <summary>
/// The <see cref="XOR{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical XOR operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if <em>EXACTLY ONE</em> of the const type arguments
/// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/> evaluates to <see langword="true"/>.
///  <para>
///  The following table shows the result of the XOR operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A XOR B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>false</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct XOR<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise XOR operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical XOR operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => KPred1.Value(arg) ^ KPred2.Value(arg);
}

/**
| A     | B     | A NOR B |
|-------|-------|---------|
| false | false | true    |
| false | true  | false   |
| true  | false | false   |
| true  | true  | false   |
**/

/// <summary>
/// The <see cref="NOR{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical NOR  operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if <em>BOTH</em> of the const type arguments
/// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/> evaluate to <see langword="false"/>.
///  <para>
///  The following table shows the result of the NOR operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A NOR B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>false</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct NOR<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise NOR operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical NOR operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => !(KPred1.Value(arg) || KPred2.Value(arg));
}

/**
| A     | B     | A XNOR B |
|-------|-------|----------|
| false | false | true     |
| false | true  | false    |
| true  | false | false    |
| true  | true  | true     |
**/

/// <summary>
/// The <see cref="XNOR{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical XNOR  operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if <em>BOTH</em> of the const type arguments
/// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/> return the same value.
///  <para>
///  The following table shows the result of the XNOR operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A XNOR B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>true</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct XNOR<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise XNOR operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical XNOR operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => KPred1.Value(arg) == KPred2.Value(arg);
}

/**
| A     | B     | A IMPLY B |
|-------|-------|-----------|
| false | false | true      |
| false | true  | true      |
| true  | false | false     |
| true  | true  | true      |
**/

/// <summary>
/// The <see cref="IMPLY{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical IMPLY  operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>. IMPLY is also
/// known as "material implication" or "material conditional".
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if a true premise (<typeparamref name="KPred1"/>)
/// does not lead to a false conclusion (<typeparamref name="KPred2"/>).
/// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/> return the same value.
///  <para>
///  The following table shows the result of the IMPLY operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A IMPLY B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>true</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct IMPLY<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise IMPLY operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical IMPLY operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => !KPred1.Value(arg) || KPred2.Value(arg);
}

/**
| A     | B     | A NIMPLY B |
|-------|-------|------------|
| false | false | false      |
| false | true  | false      |
| true  | false | true       |
| true  | true  | false      |
**/

/// <summary>
/// The <see cref="NIMPLY{T, KPred1, KPred2}"/> const type argument provides a predicate that
/// performs a logical NIMPLY  operation on the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type arguments <typeparamref name="KPred1"/> and <typeparamref name="KPred2"/> given input
/// of the type <typeparamref name="T"/>
/// and provides the static method <see cref="Eval{K}"/> to evaluate
/// against a given const type argument of type <see cref="IConstTypeArg{T}"/>. NIMPLY is also
/// known as "non-implication" or "antecedent".
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred1">
/// The 1st predicate const type argument to evaluate.
/// </typeparam>
/// <typeparam name="KPred2">
/// The 2nd predicate const type argument to evaluate.
/// </typeparam>
/// <remarks>
/// <see cref="Value"/> returns <see langword="true"/> only if a true premise (<typeparamref name="KPred1"/>)
/// leads to a false conclusion (<typeparamref name="KPred2"/>).
///  <para>
///  The following table shows the result of the IMPLY operation for all possible inputs:
///    <list type="table"><listheader>
///      <term><c>A</c></term>           <term><c>B</c></term>     <term><c>A NIMPLY B</c></term></listheader>
///      <item><term><c>false</c></term> <term><c>false</c></term> <term><c>false</c></term></item>
///      <item><term><c>false</c></term> <term><c>true</c></term>  <term><c>false</c></term></item>
///      <item><term><c>true</c></term>  <term><c>false</c></term> <term><c>true</c></term></item>
///      <item><term><c>true</c></term>  <term><c>true</c></term>  <term><c>false</c></term></item>
///    </list>
///  </para>
/// </remarks>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
public readonly struct NIMPLY<T, KPred1, KPred2> : K_Predicate<T>
    where KPred1 : K_Predicate<T> where KPred2 : K_Predicate<T>
{
    /// <summary>
    /// Performs a bitwise NIMPLY operation evaluating
    /// <typeparamref name="KPred1"/> &amp; <typeparamref name="KPred2"/>
    /// with the value of the given const type argument <typeparamref name="K"/>.
    /// </summary>
    /// <typeparam name="K">
    /// The const type argument to evaluate.
    /// </typeparam>
    /// <returns>
    /// The <see cref="bool"/> value of the logical NIMPLY operation.
    /// </returns>
    public static bool Eval<K>() where K : IConstTypeArg<T> => Value(K.Value);

    public static Predicate<T> Value => static (arg) => KPred1.Value(arg) && !KPred2.Value(arg);
}
