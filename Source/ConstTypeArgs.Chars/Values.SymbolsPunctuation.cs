namespace ConstTypeArgs.Chars;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="SymbolsPunctuation"/> static class encapsulate char const type arguments
/// for ASCII symbols &amp; punctuation.
/// </summary>
/// <seealso cref="Lower"/>
/// <seealso cref="Upper"/>
/// <seealso cref="Digits"/>
public static class SymbolsPunctuation
{
    /// <summary>
    /// Represents the ASCII character for Space. Integer value: 32, Hex: 0x20.
    /// </summary>
    public readonly struct Space : K_Char<Space> { public static char Value => (char)32; }

    /// <summary>
    /// Represents the ASCII character for Exclamation Mark (!). Integer value: 33, Hex: 0x21.
    /// </summary>
    public readonly struct ExclamationMark : K_Char<ExclamationMark> { public static char Value => (char)33; }

    /// <summary>
    /// Represents the ASCII character for Double Quote ("). Integer value: 34, Hex: 0x22.
    /// </summary>
    public readonly struct DoubleQuote : K_Char<DoubleQuote> { public static char Value => (char)34; }

    /// <summary>
    /// Represents the ASCII character for Number Sign (#). Integer value: 35, Hex: 0x23.
    /// </summary>
    public readonly struct NumberSign : K_Char<NumberSign> { public static char Value => (char)35; }

    /// <summary>
    /// Represents the ASCII character for Dollar Sign ($). Integer value: 36, Hex: 0x24.
    /// </summary>
    public readonly struct DollarSign : K_Char<DollarSign> { public static char Value => (char)36; }

    /// <summary>
    /// Represents the ASCII character for Percent Sign (%). Integer value: 37, Hex: 0x25.
    /// </summary>
    public readonly struct PercentSign : K_Char<PercentSign> { public static char Value => (char)37; }

    /// <summary>
    /// Represents the ASCII character for Ampersand (&amp;). Integer value: 38, Hex: 0x26.
    /// </summary>
    public readonly struct Ampersand : K_Char<Ampersand> { public static char Value => (char)38; }

    /// <summary>
    /// Represents the ASCII character for Apostrophe ('). Integer value: 39, Hex: 0x27.
    /// </summary>
    public readonly struct Apostrophe : K_Char<Apostrophe> { public static char Value => (char)39; }

    /// <summary>
    /// Represents the ASCII character for Left Parenthesis ((). Integer value: 40, Hex: 0x28.
    /// </summary>
    public readonly struct ParenthesisOpening : K_Char<ParenthesisOpening> { public static char Value => (char)40; }

    /// <summary>
    /// Represents the ASCII character for Right Parenthesis ()). Integer value: 41, Hex: 0x29.
    /// </summary>
    public readonly struct ParenthesisClosing : K_Char<ParenthesisClosing> { public static char Value => (char)41; }

    /// <summary>
    /// Represents the ASCII character for Asterisk (*). Integer value: 42, Hex: 0x2A.
    /// </summary>
    public readonly struct Asterisk : K_Char<Asterisk> { public static char Value => (char)42; }

    /// <summary>
    /// Represents the ASCII character for Plus Sign (+). Integer value: 43, Hex: 0x2B.
    /// </summary>
    public readonly struct PlusSign : K_Char<PlusSign> { public static char Value => (char)43; }

    /// <summary>
    /// Represents the ASCII character for Comma (,). Integer value: 44, Hex: 0x2C.
    /// </summary>
    public readonly struct Comma : K_Char<Comma> { public static char Value => (char)44; }

    /// <summary>
    /// Represents the ASCII character for Hyphen (-). Integer value: 45, Hex: 0x2D.
    /// </summary>
    public readonly struct Hyphen : K_Char<Hyphen> { public static char Value => (char)45; }

    /// <summary>
    /// Represents the ASCII character for Period (.). Integer value: 46, Hex: 0x2E.
    /// </summary>
    public readonly struct Period : K_Char<Period> { public static char Value => (char)46; }

    /// <summary>
    /// Represents the ASCII character for Slash (/). Integer value: 47, Hex: 0x2F.
    /// </summary>
    public readonly struct Slash : K_Char<Slash> { public static char Value => (char)47; }

    /// <summary>
    /// Represents the ASCII character for Colon (:). Integer value: 58, Hex: 0x3A.
    /// </summary>
    public readonly struct Colon : K_Char<Colon> { public static char Value => (char)58; }

    /// <summary>
    /// Represents the ASCII character for Semicolon (;). Integer value: 59, Hex: 0x3B.
    /// </summary>
    public readonly struct Semicolon : K_Char<Semicolon> { public static char Value => (char)59; }

    /// <summary>
    /// Represents the ASCII character for Less Than Sign (&lt;). Integer value: 60, Hex: 0x3C.
    /// </summary>
    public readonly struct LessThanSign : K_Char<LessThanSign> { public static char Value => (char)60; }

    /// <summary>
    /// Represents the ASCII character for Equals Sign (=). Integer value: 61, Hex: 0x3D.
    /// </summary>
    public readonly struct EqualsSign : K_Char<EqualsSign> { public static char Value => (char)61; }

    /// <summary>
    /// Represents the ASCII character for Greater Than Sign (&gt;). Integer value: 62, Hex: 0x3E.
    /// </summary>
    public readonly struct GreaterThanSign : K_Char<GreaterThanSign> { public static char Value => (char)62; }

    /// <summary>
    /// Represents the ASCII character for Question Mark (?). Integer value: 63, Hex: 0x3F.
    /// </summary>
    public readonly struct QuestionMark : K_Char<QuestionMark> { public static char Value => (char)63; }

    /// <summary>
    /// Represents the ASCII character for At Symbol (@). Integer value: 64, Hex: 0x40.
    /// </summary>
    public readonly struct AtSign : K_Char<AtSign> { public static char Value => (char)64; }

    /// <summary>
    /// Represents the ASCII character for Opening Bracket ([). Integer value: 91, Hex: 0x5B.
    /// </summary>
    public readonly struct BracketOpening : K_Char<BracketOpening> { public static char Value => (char)91; }

    /// <summary>
    /// Represents the ASCII character for Backslash (\). Integer value: 92, Hex: 0x5C.
    /// </summary>
    public readonly struct Backslash : K_Char<Backslash> { public static char Value => (char)92; }

    /// <summary>
    /// Represents the ASCII character for Closing Bracket (]). Integer value: 93, Hex: 0x5D.
    /// </summary>
    public readonly struct BracketClosing : K_Char<BracketClosing> { public static char Value => (char)93; }

    /// <summary>
    /// Represents the ASCII character for Caret (^). Integer value: 94, Hex: 0x5E.
    /// </summary>
    public readonly struct Caret : K_Char<Caret> { public static char Value => (char)94; }

    /// <summary>
    /// Represents the ASCII character for Underscore (_). Integer value: 95, Hex: 0x5F.
    /// </summary>
    public readonly struct Underscore : K_Char<Underscore> { public static char Value => (char)95; }

    /// <summary>
    /// Represents the ASCII character for Grave Accent (`). Integer value: 96, Hex: 0x60.
    /// </summary>
    public readonly struct GraveAccent : K_Char<GraveAccent> { public static char Value => (char)96; }

    /// <summary>
    /// Represents the ASCII character for Opening Brace ({). Integer value: 123, Hex: 0x7B.
    /// </summary>
    public readonly struct BraceOpening : K_Char<BraceOpening> { public static char Value => (char)123; }

    /// <summary>
    /// Represents the ASCII character for Vertical Bar (|). Integer value: 124, Hex: 0x7C.
    /// </summary>
    public readonly struct VerticalBar : K_Char<VerticalBar> { public static char Value => (char)124; }

    /// <summary>
    /// Represents the ASCII character for Closing Brace (}). Integer value: 125, Hex: 0x7D.
    /// </summary>
    public readonly struct BraceClosing : K_Char<BraceClosing> { public static char Value => (char)125; }

    /// <summary>
    /// Represents the ASCII character for Tilde (~). Integer value: 126, Hex: 0x7E.
    /// </summary>
    public readonly struct Tilde : K_Char<Tilde> { public static char Value => (char)126; }
}
