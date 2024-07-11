namespace ConstTypeArgs.Chars.Control;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// Ignore Spelling: Enquiry

/// <summary>
/// Represents the ASCII character for Null (NUL). Integer value: 0, Hex: 0x00.
/// </summary>
public readonly struct NullChar : K_Char<NullChar> { public static char Value => (char)0; }

/// <summary>
/// Represents the ASCII character for Start of Header (SOH). Integer value: 1, Hex: 0x01.
/// </summary>
public readonly struct StartOfHeader : K_Char<StartOfHeader> { public static char Value => (char)1; }

/// <summary>
/// Represents the ASCII character for Start of Text (STX). Integer value: 2, Hex: 0x02.
/// </summary>
public readonly struct StartOfText : K_Char<StartOfText> { public static char Value => (char)2; }

/// <summary>
/// Represents the ASCII character for End of Text (ETX). Integer value: 3, Hex: 0x03.
/// </summary>
public readonly struct EndOfText : K_Char<EndOfText> { public static char Value => (char)3; }

/// <summary>
/// Represents the ASCII character for End of Transmission (EOT). Integer value: 4, Hex: 0x04.
/// </summary>
public readonly struct EndOfTransmission : K_Char<EndOfTransmission> { public static char Value => (char)4; }

/// <summary>
/// Represents the ASCII character for Enquiry (ENQ). Integer value: 5, Hex: 0x05.
/// </summary>
public readonly struct Enquiry : K_Char<Enquiry> { public static char Value => (char)5; }

/// <summary>
/// Represents the ASCII character for Acknowledge (ACK). Integer value: 6, Hex: 0x06.
/// </summary>
public readonly struct Acknowledge : K_Char<Acknowledge> { public static char Value => (char)6; }

/// <summary>
/// Represents the ASCII character for Bell (BEL). Integer value: 7, Hex: 0x07.
/// </summary>
public readonly struct Bell : K_Char<Bell> { public static char Value => (char)7; }

/// <summary>
/// Represents the ASCII character for Backspace (BS). Integer value: 8, Hex: 0x08.
/// </summary>
public readonly struct Backspace : K_Char<Backspace> { public static char Value => (char)8; }

/// <summary>
/// Represents the ASCII character for Horizontal Tab (HT). Integer value: 9, Hex: 0x09.
/// </summary>
public readonly struct HorizontalTab : K_Char<HorizontalTab> { public static char Value => (char)9; }

/// <summary>
/// Represents the ASCII character for Line Feed (LF). Integer value: 10, Hex: 0x0A.
/// </summary>
public readonly struct LineFeed : K_Char<LineFeed> { public static char Value => (char)10; }

/// <summary>
/// Represents the ASCII character for Vertical Tab (VT). Integer value: 11, Hex: 0x0B.
/// </summary>
public readonly struct VerticalTab : K_Char<VerticalTab> { public static char Value => (char)11; }

/// <summary>
/// Represents the ASCII character for Form Feed (FF). Integer value: 12, Hex: 0x0C.
/// </summary>
public readonly struct FormFeed : K_Char<FormFeed> { public static char Value => (char)12; }

/// <summary>
/// Represents the ASCII character for Carriage Return (CR). Integer value: 13, Hex: 0x0D.
/// </summary>
public readonly struct CarriageReturn : K_Char<CarriageReturn> { public static char Value => (char)13; }

/// <summary>
/// Represents the ASCII character for Shift Out / X-On (SO). Integer value: 14, Hex: 0x0E.
/// </summary>
public readonly struct ShiftOut : K_Char<ShiftOut> { public static char Value => (char)14; }

/// <summary>
/// Represents the ASCII character for Shift In / X-Off (SI). Integer value: 15, Hex: 0x0F.
/// </summary>
public readonly struct ShiftIn : K_Char<ShiftIn> { public static char Value => (char)15; }

/// <summary>
/// Represents the ASCII character for Data Link Escape (DLE). Integer value: 16, Hex: 0x10.
/// </summary>
public readonly struct DataLinkEscape : K_Char<DataLinkEscape> { public static char Value => (char)16; }

/// <summary>
/// Represents the ASCII character for Delete (DEL). Integer value: 127, Hex: 0x7F.
/// </summary>
public readonly struct Delete : K_Char<Delete> { public static char Value => (char)127; }

/// <summary>
/// Represents the ASCII character for Device Control 1 (DC1). Integer value: 17, Hex: 0x11.
/// </summary>
public readonly struct DeviceControl1 : K_Char<DeviceControl1> { public static char Value => (char)17; }

/// <summary>
/// Represents the ASCII character for Device Control 2 (DC2). Integer value: 18, Hex: 0x12.
/// </summary>
public readonly struct DeviceControl2 : K_Char<DeviceControl2> { public static char Value => (char)18; }

/// <summary>
/// Represents the ASCII character for Device Control 3 (DC3). Integer value: 19, Hex: 0x13.
/// </summary>
public readonly struct DeviceControl3 : K_Char<DeviceControl3> { public static char Value => (char)19; }

/// <summary>
/// Represents the ASCII character for Device Control 4 (DC4). Integer value: 20, Hex: 0x14.
/// </summary>
public readonly struct DeviceControl4 : K_Char<DeviceControl4> { public static char Value => (char)20; }

/// <summary>
/// Represents the ASCII character for Negative Acknowledgement (NAK). Integer value: 21, Hex: 0x15.
/// </summary>
public readonly struct NegativeAcknowledgment : K_Char<NegativeAcknowledgment> { public static char Value => (char)21; }

/// <summary>
/// Represents the ASCII character for Synchronous Idle (SYN). Integer value: 22, Hex: 0x16.
/// </summary>
public readonly struct SynchronousIdle : K_Char<SynchronousIdle> { public static char Value => (char)22; }

/// <summary>
/// Represents the ASCII character for End of Transmission Block (ETB). Integer value: 23, Hex: 0x17.
/// </summary>
public readonly struct EndOfTransmissionBlock : K_Char<EndOfTransmissionBlock> { public static char Value => (char)23; }

/// <summary>
/// Represents the ASCII character for Cancel (CAN). Integer value: 24, Hex: 0x18.
/// </summary>
public readonly struct Cancel : K_Char<Cancel> { public static char Value => (char)24; }

/// <summary>
/// Represents the ASCII character for End of Medium (EM). Integer value: 25, Hex: 0x19.
/// </summary>
public readonly struct EndOfMedium : K_Char<EndOfMedium> { public static char Value => (char)25; }

/// <summary>
/// Represents the ASCII character for Substitute (SUB). Integer value: 26, Hex: 0x1A.
/// </summary>
public readonly struct Substitute : K_Char<Substitute> { public static char Value => (char)26; }

/// <summary>
/// Represents the ASCII character for Escape (ESC). Integer value: 27, Hex: 0x1B.
/// </summary>
public readonly struct Escape : K_Char<Escape> { public static char Value => (char)27; }

/// <summary>
/// Represents the ASCII character for File Separator (FS). Integer value: 28, Hex: 0x1C.
/// </summary>
public readonly struct FileSeparator : K_Char<FileSeparator> { public static char Value => (char)28; }

/// <summary>
/// Represents the ASCII character for Group Separator (GS). Integer value: 29, Hex: 0x1D.
/// </summary>
public readonly struct GroupSeparator : K_Char<GroupSeparator> { public static char Value => (char)29; }

/// <summary>
/// Represents the ASCII character for Record Separator (RS). Integer value: 30, Hex: 0x1E.
/// </summary>
public readonly struct RecordSeparator : K_Char<RecordSeparator> { public static char Value => (char)30; }

/// <summary>
/// Represents the ASCII character for Unit Separator (US). Integer value: 31, Hex: 0x1F.
/// </summary>
public readonly struct UnitSeparator : K_Char<UnitSeparator> { public static char Value => (char)31; }
