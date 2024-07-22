// Ignore Spelling: Spacebar App Sel
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Console.Key;

/// <summary>
/// The <see cref="Keys"/> static class encapsulates const type arguments for
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey</see> values.
/// </summary>
/// <seealso cref="Key{K}"/>
/// <seealso cref="KeyArray{K}"/>
/// <seealso cref="KeyModifiers"/>
/// <seealso cref="SpecialKeys"/>
public static class Keys
{
    /// <summary>
    /// The <see cref="NoKey"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.None</see>.
    /// </summary>
    public readonly struct NoKey : K_Key<NoKey> { public static ConsoleKey Value => ConsoleKey.None; }

    #region Number Keys

    /// <summary>
    /// The <see cref="NumPad0"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad0</see>.
    /// </summary>
    public readonly struct NumPad0 : K_Key<NumPad0> { public static ConsoleKey Value => ConsoleKey.NumPad0; }

    /// <summary>
    /// The <see cref="NumPad1"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad1</see>.
    /// </summary>
    public readonly struct NumPad1 : K_Key<NumPad1> { public static ConsoleKey Value => ConsoleKey.NumPad1; }

    /// <summary>
    /// The <see cref="NumPad2"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad2</see>.
    /// </summary>
    public readonly struct NumPad2 : K_Key<NumPad2> { public static ConsoleKey Value => ConsoleKey.NumPad2; }

    /// <summary>
    /// The <see cref="NumPad3"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad3</see>.
    /// </summary>
    public readonly struct NumPad3 : K_Key<NumPad3> { public static ConsoleKey Value => ConsoleKey.NumPad3; }

    /// <summary>
    /// The <see cref="NumPad4"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad4</see>.
    /// </summary>
    public readonly struct NumPad4 : K_Key<NumPad4> { public static ConsoleKey Value => ConsoleKey.NumPad4; }

    /// <summary>
    /// The <see cref="NumPad5"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad5</see>.
    /// </summary>
    public readonly struct NumPad5 : K_Key<NumPad5> { public static ConsoleKey Value => ConsoleKey.NumPad5; }

    /// <summary>
    /// The <see cref="NumPad6"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad6</see>.
    /// </summary>
    public readonly struct NumPad6 : K_Key<NumPad6> { public static ConsoleKey Value => ConsoleKey.NumPad6; }

    /// <summary>
    /// The <see cref="NumPad7"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad7</see>.
    /// </summary>
    public readonly struct NumPad7 : K_Key<NumPad7> { public static ConsoleKey Value => ConsoleKey.NumPad7; }

    /// <summary>
    /// The <see cref="NumPad8"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad8</see>.
    /// </summary>
    public readonly struct NumPad8 : K_Key<NumPad8> { public static ConsoleKey Value => ConsoleKey.NumPad8; }

    /// <summary>
    /// The <see cref="NumPad9"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NumPad9</see>.
    /// </summary>
    public readonly struct NumPad9 : K_Key<NumPad9> { public static ConsoleKey Value => ConsoleKey.NumPad9; }

    /// <summary>
    /// The <see cref="_0"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D0</see>.
    /// </summary>
    public readonly struct _0 : K_Key<_0> { public static ConsoleKey Value => ConsoleKey.D0; }

    /// <summary>
    /// The <see cref="_1"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D1</see>.
    /// </summary>
    public readonly struct _1 : K_Key<_1> { public static ConsoleKey Value => ConsoleKey.D1; }

    /// <summary>
    /// The <see cref="_2"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D2</see>.
    /// </summary>
    public readonly struct _2 : K_Key<_2> { public static ConsoleKey Value => ConsoleKey.D2; }

    /// <summary>
    /// The <see cref="_3"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D3</see>.
    /// </summary>
    public readonly struct _3 : K_Key<_3> { public static ConsoleKey Value => ConsoleKey.D3; }

    /// <summary>
    /// The <see cref="_4"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D4</see>.
    /// </summary>
    public readonly struct _4 : K_Key<_4> { public static ConsoleKey Value => ConsoleKey.D4; }

    /// <summary>
    /// The <see cref="_5"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D5</see>.
    /// </summary>
    public readonly struct _5 : K_Key<_5> { public static ConsoleKey Value => ConsoleKey.D5; }

    /// <summary>
    /// The <see cref="_6"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D6</see>.
    /// </summary>
    public readonly struct _6 : K_Key<_6> { public static ConsoleKey Value => ConsoleKey.D6; }

    /// <summary>
    /// The <see cref="_7"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D7</see>.
    /// </summary>
    public readonly struct _7 : K_Key<_7> { public static ConsoleKey Value => ConsoleKey.D7; }

    /// <summary>
    /// The <see cref="_8"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D8</see>.
    /// </summary>
    public readonly struct _8 : K_Key<_8> { public static ConsoleKey Value => ConsoleKey.D8; }

    /// <summary>
    /// The <see cref="_9"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D9</see>.
    /// </summary>
    public readonly struct _9 : K_Key<_9> { public static ConsoleKey Value => ConsoleKey.D9; }

    /// <summary>
    /// The <see cref="Decimal"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Decimal</see>.
    /// </summary>
    public readonly struct Decimal : K_Key<Decimal> { public static ConsoleKey Value => ConsoleKey.Decimal; }

    #endregion Number Keys

    #region Letters

    /// <summary>
    /// The <see cref="A"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.A</see>.
    /// </summary>
    public readonly struct A : K_Key<A> { public static ConsoleKey Value => ConsoleKey.A; }

    /// <summary>
    /// The <see cref="B"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.B</see>.
    /// </summary>
    public readonly struct B : K_Key<B> { public static ConsoleKey Value => ConsoleKey.B; }

    /// <summary>
    /// The <see cref="C"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.C</see>.
    /// </summary>
    public readonly struct C : K_Key<C> { public static ConsoleKey Value => ConsoleKey.C; }

    /// <summary>
    /// The <see cref="D"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.D</see>.
    /// </summary>
    public readonly struct D : K_Key<D> { public static ConsoleKey Value => ConsoleKey.D; }

    /// <summary>
    /// The <see cref="E"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.E</see>.
    /// </summary>
    public readonly struct E : K_Key<E> { public static ConsoleKey Value => ConsoleKey.E; }

    /// <summary>
    /// The <see cref="F"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F</see>.
    /// </summary>
    public readonly struct F : K_Key<F> { public static ConsoleKey Value => ConsoleKey.F; }

    /// <summary>
    /// The <see cref="G"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.G</see>.
    /// </summary>
    public readonly struct G : K_Key<G> { public static ConsoleKey Value => ConsoleKey.G; }

    /// <summary>
    /// The <see cref="H"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.H</see>.
    /// </summary>
    public readonly struct H : K_Key<H> { public static ConsoleKey Value => ConsoleKey.H; }

    /// <summary>
    /// The <see cref="I"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.I</see>.
    /// </summary>
    public readonly struct I : K_Key<I> { public static ConsoleKey Value => ConsoleKey.I; }

    /// <summary>
    /// The <see cref="J"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.J</see>.
    /// </summary>
    public readonly struct J : K_Key<J> { public static ConsoleKey Value => ConsoleKey.J; }

    /// <summary>
    /// The <see cref="K"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.K</see>.
    /// </summary>
    public readonly struct K : K_Key<K> { public static ConsoleKey Value => ConsoleKey.K; }

    /// <summary>
    /// The <see cref="L"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.L</see>.
    /// </summary>
    public readonly struct L : K_Key<L> { public static ConsoleKey Value => ConsoleKey.L; }

    /// <summary>
    /// The <see cref="M"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.M</see>.
    /// </summary>
    public readonly struct M : K_Key<M> { public static ConsoleKey Value => ConsoleKey.M; }

    /// <summary>
    /// The <see cref="N"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.N</see>.
    /// </summary>
    public readonly struct N : K_Key<N> { public static ConsoleKey Value => ConsoleKey.N; }

    /// <summary>
    /// The <see cref="O"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.O</see>.
    /// </summary>
    public readonly struct O : K_Key<O> { public static ConsoleKey Value => ConsoleKey.O; }

    /// <summary>
    /// The <see cref="P"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.P</see>.
    /// </summary>
    public readonly struct P : K_Key<P> { public static ConsoleKey Value => ConsoleKey.P; }

    /// <summary>
    /// The <see cref="Q"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Q</see>.
    /// </summary>
    public readonly struct Q : K_Key<Q> { public static ConsoleKey Value => ConsoleKey.Q; }

    /// <summary>
    /// The <see cref="R"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.R</see>.
    /// </summary>
    public readonly struct R : K_Key<R> { public static ConsoleKey Value => ConsoleKey.R; }

    /// <summary>
    /// The <see cref="S"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.S</see>.
    /// </summary>
    public readonly struct S : K_Key<S> { public static ConsoleKey Value => ConsoleKey.S; }

    /// <summary>
    /// The <see cref="T"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.T</see>.
    /// </summary>
    public readonly struct T : K_Key<T> { public static ConsoleKey Value => ConsoleKey.T; }

    /// <summary>
    /// The <see cref="U"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.U</see>.
    /// </summary>
    public readonly struct U : K_Key<U> { public static ConsoleKey Value => ConsoleKey.U; }

    /// <summary>
    /// The <see cref="V"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.V</see>.
    /// </summary>
    public readonly struct V : K_Key<V> { public static ConsoleKey Value => ConsoleKey.V; }

    /// <summary>
    /// The <see cref="W"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.W</see>.
    /// </summary>
    public readonly struct W : K_Key<W> { public static ConsoleKey Value => ConsoleKey.W; }

    /// <summary>
    /// The <see cref="X"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.X</see>.
    /// </summary>
    public readonly struct X : K_Key<X> { public static ConsoleKey Value => ConsoleKey.X; }

    /// <summary>
    /// The <see cref="Y"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Y</see>.
    /// </summary>
    public readonly struct Y : K_Key<Y> { public static ConsoleKey Value => ConsoleKey.Y; }

    /// <summary>
    /// The <see cref="Z"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Z</see>.
    /// </summary>
    public readonly struct Z : K_Key<Z> { public static ConsoleKey Value => ConsoleKey.Z; }

    #endregion Letters

    #region Common Keys

    /// <summary>
    /// The <see cref="Backspace"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Backspace</see>.
    /// </summary>
    public readonly struct Backspace : K_Key<Backspace>
    { public static ConsoleKey Value => ConsoleKey.Backspace; }

    /// <summary>
    /// The <see cref="Enter"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Enter</see>.
    /// </summary>
    public readonly struct Enter : K_Key<Enter>
    { public static ConsoleKey Value => ConsoleKey.Enter; }

    /// <summary>
    /// The <see cref="Escape"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Escape</see>.
    /// </summary>
    public readonly struct Escape : K_Key<Escape>
    { public static ConsoleKey Value => ConsoleKey.Escape; }

    /// <summary>
    /// The <see cref="Spacebar"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Spacebar</see>.
    /// </summary>
    public readonly struct Spacebar : K_Key<Spacebar>
    { public static ConsoleKey Value => ConsoleKey.Spacebar; }

    /// <summary>
    /// The <see cref="Tab"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Tab</see>.
    /// </summary>
    public readonly struct Tab : K_Key<Tab>
    { public static ConsoleKey Value => ConsoleKey.Tab; }

    /// <summary>
    /// The <see cref="PrintScreen"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.PrintScreen</see>.
    /// </summary>
    public readonly struct PrintScreen : K_Key<PrintScreen> { public static ConsoleKey Value => ConsoleKey.PrintScreen; }

    /// <summary>
    /// The <see cref="Pause"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Pause</see>.
    /// </summary>
    public readonly struct Pause : K_Key<Pause>
    { public static ConsoleKey Value => ConsoleKey.Pause; }

    /// <summary>
    /// The <see cref="Insert"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Insert</see>.
    /// </summary>
    public readonly struct Insert : K_Key<Insert> { public static ConsoleKey Value => ConsoleKey.Insert; }

    /// <summary>
    /// The <see cref="Delete"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Delete</see>.
    /// </summary>
    public readonly struct Delete : K_Key<Delete> { public static ConsoleKey Value => ConsoleKey.Delete; }

    /// <summary>
    /// The <see cref="Home"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Home</see>.
    /// </summary>
    public readonly struct Home : K_Key<Home>
    { public static ConsoleKey Value => ConsoleKey.Home; }

    /// <summary>
    /// The <see cref="End"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.End</see>.
    /// </summary>
    public readonly struct End : K_Key<End>
    { public static ConsoleKey Value => ConsoleKey.End; }

    /// <summary>
    /// The <see cref="PageUp"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.PageUp</see>.
    /// </summary>
    public readonly struct PageUp : K_Key<PageUp>
    { public static ConsoleKey Value => ConsoleKey.PageUp; }

    /// <summary>
    /// The <see cref="PageDown"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.PageDown</see>.
    /// </summary>
    public readonly struct PageDown : K_Key<PageDown>
    { public static ConsoleKey Value => ConsoleKey.PageDown; }

    #endregion Common Keys

    #region Math Operators

    /// <summary>
    /// The <see cref="Add"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Add</see> (numpad).
    /// </summary>
    public readonly struct Add : K_Key<Add> { public static ConsoleKey Value => ConsoleKey.Add; }

    /// <summary>
    /// The <see cref="Subtract"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Subtract</see> (numpad).
    /// </summary>
    public readonly struct Subtract : K_Key<Subtract> { public static ConsoleKey Value => ConsoleKey.Subtract; }

    /// <summary>
    /// The <see cref="Multiply"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Multiply</see> (numpad).
    /// </summary>
    public readonly struct Multiply : K_Key<Multiply> { public static ConsoleKey Value => ConsoleKey.Multiply; }

    /// <summary>
    /// The <see cref="Divide"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Divide</see> (numpad).
    /// </summary>
    public readonly struct Divide : K_Key<Divide> { public static ConsoleKey Value => ConsoleKey.Divide; }

    #endregion Math Operators

    #region Arrows

    /// <summary>
    /// The <see cref="LeftArrow"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.LeftArrow</see>.
    /// </summary>
    public readonly struct LeftArrow : K_Key<LeftArrow>
    { public static ConsoleKey Value => ConsoleKey.LeftArrow; }

    /// <summary>
    /// The <see cref="UpArrow"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.UpArrow</see>.
    /// </summary>
    public readonly struct UpArrow : K_Key<UpArrow>
    { public static ConsoleKey Value => ConsoleKey.UpArrow; }

    /// <summary>
    /// The <see cref="RightArrow"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.RightArrow</see>.
    /// </summary>
    public readonly struct RightArrow : K_Key<RightArrow>
    { public static ConsoleKey Value => ConsoleKey.RightArrow; }

    /// <summary>
    /// The <see cref="DownArrow"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.DownArrow</see>.
    /// </summary>
    public readonly struct DownArrow : K_Key<DownArrow>
    { public static ConsoleKey Value => ConsoleKey.DownArrow; }

    #endregion Arrows

    #region Misc Keys

    /// <summary>
    /// The <see cref="Separator"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Separator</see>.
    /// </summary>
    public readonly struct Separator : K_Key<Separator> { public static ConsoleKey Value => ConsoleKey.Separator; }

    /// <summary>
    /// The <see cref="Sleep"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Sleep</see>.
    /// </summary>
    public readonly struct Sleep : K_Key<Sleep> { public static ConsoleKey Value => ConsoleKey.Sleep; }

    /// <summary>
    /// The <see cref="Clear"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Clear</see>.
    /// </summary>
    public readonly struct Clear : K_Key<Clear>
    { public static ConsoleKey Value => ConsoleKey.Clear; }

    /// <summary>
    /// The <see cref="Select"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Select</see>.
    /// </summary>
    public readonly struct Select : K_Key<Select>
    { public static ConsoleKey Value => ConsoleKey.Select; }

    /// <summary>
    /// The <see cref="Print"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Print</see>.
    /// </summary>
    public readonly struct Print : K_Key<Print> { public static ConsoleKey Value => ConsoleKey.Print; }

    /// <summary>
    /// The <see cref="Execute"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Execute</see>.
    /// </summary>
    public readonly struct Execute : K_Key<Execute> { public static ConsoleKey Value => ConsoleKey.Execute; }

    /// <summary>
    /// The <see cref="Help"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Help</see>.
    /// </summary>
    public readonly struct Help : K_Key<Help> { public static ConsoleKey Value => ConsoleKey.Help; }

    /// <summary>
    /// The <see cref="Pa1"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Pa1</see>.
    /// </summary>
    public readonly struct Pa1 : K_Key<Pa1> { public static ConsoleKey Value => ConsoleKey.Pa1; }

    /// <summary>
    /// The <see cref="Packet "/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Packet</see>
    /// (used to pass Unicode characters with keystrokes).
    /// </summary>
    public readonly struct Packet : K_Key<Packet> { public static ConsoleKey Value => ConsoleKey.Packet; }

    /// <summary>
    /// The <see cref="Process"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Process</see>.
    /// </summary>
    public readonly struct Process : K_Key<Process> { public static ConsoleKey Value => ConsoleKey.Process; }

    /// <summary>
    /// The <see cref="Attention"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Attention</see>.
    /// </summary>
    public readonly struct Attention : K_Key<Attention> { public static ConsoleKey Value => ConsoleKey.Attention; }

    /// <summary>
    /// The <see cref="CrSel"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.CrSel</see> (CURSOR SELECT).
    /// </summary>
    public readonly struct CrSel : K_Key<CrSel> { public static ConsoleKey Value => ConsoleKey.CrSel; }

    /// <summary>
    /// The <see cref="ExSel"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.ExSel</see> (EXTEND SELECTION).
    /// </summary>
    public readonly struct ExSel : K_Key<ExSel> { public static ConsoleKey Value => ConsoleKey.ExSel; }

    /// <summary>
    /// The <see cref="EraseEndOfFile"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.EraseEndOfFile</see>.
    /// </summary>
    public readonly struct EraseEndOfFile : K_Key<EraseEndOfFile> { public static ConsoleKey Value => ConsoleKey.EraseEndOfFile; }

    /// <summary>
    /// The <see cref="Zoom"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Zoom</see>.
    /// </summary>
    public readonly struct Zoom : K_Key<Zoom> { public static ConsoleKey Value => ConsoleKey.Zoom; }

    /// <summary>
    /// The <see cref="NoName"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.NoName</see>.
    /// </summary>
    public readonly struct NoName : K_Key<NoName> { public static ConsoleKey Value => ConsoleKey.NoName; }

    #endregion Misc Keys

    #region Function Keys

    /// <summary>
    /// The <see cref="F1"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F1</see>.
    /// </summary>
    public readonly struct F1 : K_Key<F1> { public static ConsoleKey Value => ConsoleKey.F1; }

    /// <summary>
    /// The <see cref="F2"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F2</see>.
    /// </summary>
    public readonly struct F2 : K_Key<F2> { public static ConsoleKey Value => ConsoleKey.F2; }

    /// <summary>
    /// The <see cref="F3"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F3</see>.
    /// </summary>
    public readonly struct F3 : K_Key<F3> { public static ConsoleKey Value => ConsoleKey.F3; }

    /// <summary>
    /// The <see cref="F4"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F4</see>.
    /// </summary>
    public readonly struct F4 : K_Key<F4> { public static ConsoleKey Value => ConsoleKey.F4; }

    /// <summary>
    /// The <see cref="F5"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F5</see>.
    /// </summary>
    public readonly struct F5 : K_Key<F5> { public static ConsoleKey Value => ConsoleKey.F5; }

    /// <summary>
    /// The <see cref="F6"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F6</see>.
    /// </summary>
    public readonly struct F6 : K_Key<F6> { public static ConsoleKey Value => ConsoleKey.F6; }

    /// <summary>
    /// The <see cref="F7"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F7</see>.
    /// </summary>
    public readonly struct F7 : K_Key<F7> { public static ConsoleKey Value => ConsoleKey.F7; }

    /// <summary>
    /// The <see cref="F8"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F8</see>.
    /// </summary>
    public readonly struct F8 : K_Key<F8> { public static ConsoleKey Value => ConsoleKey.F8; }

    /// <summary>
    /// The <see cref="F9"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F9</see>.
    /// </summary>
    public readonly struct F9 : K_Key<F9> { public static ConsoleKey Value => ConsoleKey.F9; }

    /// <summary>
    /// The <see cref="F10"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F10</see>.
    /// </summary>
    public readonly struct F10 : K_Key<F10> { public static ConsoleKey Value => ConsoleKey.F10; }

    /// <summary>
    /// The <see cref="F11"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F11</see>.
    /// </summary>
    public readonly struct F11 : K_Key<F11> { public static ConsoleKey Value => ConsoleKey.F11; }

    /// <summary>
    /// The <see cref="F12"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F12</see>.
    /// </summary>
    public readonly struct F12 : K_Key<F12> { public static ConsoleKey Value => ConsoleKey.F12; }

    /// <summary>
    /// The <see cref="F13"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F13</see>.
    /// </summary>
    public readonly struct F13 : K_Key<F13> { public static ConsoleKey Value => ConsoleKey.F13; }

    /// <summary>
    /// The <see cref="F14"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F14</see>.
    /// </summary>
    public readonly struct F14 : K_Key<F14> { public static ConsoleKey Value => ConsoleKey.F14; }

    /// <summary>
    /// The <see cref="F15"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F15</see>.
    /// </summary>
    public readonly struct F15 : K_Key<F15> { public static ConsoleKey Value => ConsoleKey.F15; }

    /// <summary>
    /// The <see cref="F16"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F16</see>.
    /// </summary>
    public readonly struct F16 : K_Key<F16> { public static ConsoleKey Value => ConsoleKey.F16; }

    /// <summary>
    /// The <see cref="F17"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F17</see>.
    /// </summary>
    public readonly struct F17 : K_Key<F17> { public static ConsoleKey Value => ConsoleKey.F17; }

    /// <summary>
    /// The <see cref="F18"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F18</see>.
    /// </summary>
    public readonly struct F18 : K_Key<F18> { public static ConsoleKey Value => ConsoleKey.F18; }

    /// <summary>
    /// The <see cref="F19"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F19</see>.
    /// </summary>
    public readonly struct F19 : K_Key<F19> { public static ConsoleKey Value => ConsoleKey.F19; }

    /// <summary>
    /// The <see cref="F20"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F20</see>.
    /// </summary>
    public readonly struct F20 : K_Key<F20> { public static ConsoleKey Value => ConsoleKey.F20; }

    /// <summary>
    /// The <see cref="F21"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F21</see>.
    /// </summary>
    public readonly struct F21 : K_Key<F21> { public static ConsoleKey Value => ConsoleKey.F21; }

    /// <summary>
    /// The <see cref="F22"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F22</see>.
    /// </summary>
    public readonly struct F22 : K_Key<F22> { public static ConsoleKey Value => ConsoleKey.F22; }

    /// <summary>
    /// The <see cref="F23"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F23</see>.
    /// </summary>
    public readonly struct F23 : K_Key<F23> { public static ConsoleKey Value => ConsoleKey.F23; }

    /// <summary>
    /// The <see cref="F24"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.F24</see>.
    /// </summary>
    public readonly struct F24 : K_Key<F24> { public static ConsoleKey Value => ConsoleKey.F24; }

    #endregion Function Keys

    #region Browser Keys

    /// <summary>
    /// The <see cref="BrowserBack"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserBack</see>.
    /// </summary>
    public readonly struct BrowserBack : K_Key<BrowserBack> { public static ConsoleKey Value => ConsoleKey.BrowserBack; }

    /// <summary>
    /// The <see cref="BrowserForward"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserForward</see>.
    /// </summary>
    public readonly struct BrowserForward : K_Key<BrowserForward> { public static ConsoleKey Value => ConsoleKey.BrowserForward; }

    /// <summary>
    /// The <see cref="BrowserRefresh"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserRefresh</see>.
    /// </summary>
    public readonly struct BrowserRefresh : K_Key<BrowserRefresh> { public static ConsoleKey Value => ConsoleKey.BrowserRefresh; }

    /// <summary>
    /// The <see cref="BrowserStop"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserStop</see>.
    /// </summary>
    public readonly struct BrowserStop : K_Key<BrowserStop> { public static ConsoleKey Value => ConsoleKey.BrowserStop; }

    /// <summary>
    /// The <see cref="BrowserSearch"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserSearch</see>.
    /// </summary>
    public readonly struct BrowserSearch : K_Key<BrowserSearch> { public static ConsoleKey Value => ConsoleKey.BrowserSearch; }

    /// <summary>
    /// The <see cref="BrowserFavorites"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserFavorites</see>.
    /// </summary>
    public readonly struct BrowserFavorites : K_Key<BrowserFavorites> { public static ConsoleKey Value => ConsoleKey.BrowserFavorites; }

    /// <summary>
    /// The <see cref="BrowserHome"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.BrowserHome</see>.
    /// </summary>
    public readonly struct BrowserHome : K_Key<BrowserHome> { public static ConsoleKey Value => ConsoleKey.BrowserHome; }

    #endregion Browser Keys

    #region Volume & Media Keys

    /// <summary>
    /// The <see cref="VolumeMute"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.VolumeMute</see>.
    /// </summary>
    public readonly struct VolumeMute : K_Key<VolumeMute> { public static ConsoleKey Value => ConsoleKey.VolumeMute; }

    /// <summary>
    /// The <see cref="VolumeDown"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.VolumeDown</see>.
    /// </summary>
    public readonly struct VolumeDown : K_Key<VolumeDown> { public static ConsoleKey Value => ConsoleKey.VolumeDown; }

    /// <summary>
    /// The <see cref="VolumeUp"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.VolumeUp</see>.
    /// </summary>
    public readonly struct VolumeUp : K_Key<VolumeUp> { public static ConsoleKey Value => ConsoleKey.VolumeUp; }

    /// <summary>
    /// The <see cref="LaunchMediaSelect"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.LaunchMediaSelect</see>.
    /// </summary>
    public readonly struct LaunchMediaSelect : K_Key<LaunchMediaSelect> { public static ConsoleKey Value => ConsoleKey.LaunchMediaSelect; }

    /// <summary>
    /// The <see cref="MediaNext"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.MediaNext</see>.
    /// </summary>
    public readonly struct MediaNext : K_Key<MediaNext> { public static ConsoleKey Value => ConsoleKey.MediaNext; }

    /// <summary>
    /// The <see cref="MediaPrevious"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.MediaPrevious</see>.
    /// </summary>
    public readonly struct MediaPrevious : K_Key<MediaPrevious> { public static ConsoleKey Value => ConsoleKey.MediaPrevious; }

    /// <summary>
    /// The <see cref="MediaStop"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.MediaStop</see>.
    /// </summary>
    public readonly struct MediaStop : K_Key<MediaStop> { public static ConsoleKey Value => ConsoleKey.MediaStop; }

    /// <summary>
    /// The <see cref="MediaPlay"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.MediaPlay</see>.
    /// </summary>
    public readonly struct MediaPlay : K_Key<MediaPlay> { public static ConsoleKey Value => ConsoleKey.MediaPlay; }

    /// <summary>
    /// The <see cref="Select"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.SelectMedia</see>.
    /// </summary>
    public readonly struct SelectMedia : K_Key<SelectMedia> { public static ConsoleKey Value => ConsoleKey.Select; }

    /// <summary>
    /// The <see cref="Play"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Play</see>.
    /// </summary>
    public readonly struct Play : K_Key<Play> { public static ConsoleKey Value => ConsoleKey.Play; }

    #endregion Volume & Media Keys

    #region Application Keys

    /// <summary>
    /// The <see cref="LaunchMail"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.LaunchMail</see>.
    /// </summary>
    public readonly struct LaunchMail : K_Key<LaunchMail> { public static ConsoleKey Value => ConsoleKey.LaunchMail; }

    /// <summary>
    /// The <see cref="LaunchApp1"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.LaunchApp1</see>.
    /// </summary>
    public readonly struct LaunchApp1 : K_Key<LaunchApp1> { public static ConsoleKey Value => ConsoleKey.LaunchApp1; }

    /// <summary>
    /// The <see cref="LaunchApp2"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.LaunchApp2</see>.
    /// </summary>
    public readonly struct LaunchApp2 : K_Key<LaunchApp2> { public static ConsoleKey Value => ConsoleKey.LaunchApp2; }

    #endregion Application Keys

    #region OEM Keys

    /// <summary>
    /// The <see cref="Oem1"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem1</see>.
    /// </summary>
    public readonly struct Oem1 : K_Key<Oem1> { public static ConsoleKey Value => ConsoleKey.Oem1; }

    /// <summary>
    /// The <see cref="Oem2"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem2</see>.
    /// </summary>
    public readonly struct Oem2 : K_Key<Oem2> { public static ConsoleKey Value => ConsoleKey.Oem2; }

    /// <summary>
    /// The <see cref="Oem3"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem3</see>.
    /// </summary>
    public readonly struct Oem3 : K_Key<Oem3> { public static ConsoleKey Value => ConsoleKey.Oem3; }

    /// <summary>
    /// The <see cref="Oem4"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem4</see>.
    /// </summary>
    public readonly struct Oem4 : K_Key<Oem4> { public static ConsoleKey Value => ConsoleKey.Oem4; }

    /// <summary>
    /// The <see cref="Oem5"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem5</see>.
    /// </summary>
    public readonly struct Oem5 : K_Key<Oem5> { public static ConsoleKey Value => ConsoleKey.Oem5; }

    /// <summary>
    /// The <see cref="Oem6"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem6</see>.
    /// </summary>
    public readonly struct Oem6 : K_Key<Oem6> { public static ConsoleKey Value => ConsoleKey.Oem6; }

    /// <summary>
    /// The <see cref="Oem7"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem7</see>.
    /// </summary>
    public readonly struct Oem7 : K_Key<Oem7> { public static ConsoleKey Value => ConsoleKey.Oem7; }

    /// <summary>
    /// The <see cref="Oem8"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.Oem8</see>.
    /// </summary>
    public readonly struct Oem8 : K_Key<Oem8> { public static ConsoleKey Value => ConsoleKey.Oem8; }

    /// <summary>
    /// The <see cref="OemPlus"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.OemPlus</see>.
    /// </summary>
    public readonly struct OemPlus : K_Key<OemPlus> { public static ConsoleKey Value => ConsoleKey.OemPlus; }

    /// <summary>
    /// The <see cref="OemMinus"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.OemMinus</see>.
    /// </summary>
    public readonly struct OemMinus : K_Key<OemMinus> { public static ConsoleKey Value => ConsoleKey.OemMinus; }

    /// <summary>
    /// The <see cref="OemClear"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.OemClear</see>.
    /// </summary>
    public readonly struct OemClear : K_Key<OemClear> { public static ConsoleKey Value => ConsoleKey.OemClear; }

    /// <summary>
    /// The <see cref="OemComma"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.OemComma</see>.
    /// </summary>
    public readonly struct OemComma : K_Key<OemComma> { public static ConsoleKey Value => ConsoleKey.OemComma; }

    /// <summary>
    /// The <see cref="OemPeriod"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolekey">System.ConsoleKey.OemPeriod</see>.
    /// </summary>
    public readonly struct OemPeriod : K_Key<OemPeriod> { public static ConsoleKey Value => ConsoleKey.OemPeriod; }

    #endregion OEM Keys
}
