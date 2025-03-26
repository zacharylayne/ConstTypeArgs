using static System.Console;

namespace Samples;

/// <summary>
/// The <see cref="SampleConsoleHelper"/> class provides a helper class
/// for formatting console output in sample demos. Includes methods for writing titles,
/// separators, spacing, and more.
/// </summary>
public static class SampleConsoleHelper
{
    static SampleConsoleHelper()
    {
        OutputEncoding = System.Text.Encoding.UTF8;
    }

    /// <summary>
    /// Writes a specified number of empty lines to the console.
    /// </summary>
    /// <param name="count">
    /// The number of blank lines to write.
    /// </param>
    public static void WriteLine(int count)
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine();
    }

    /// <summary>
    /// Writes the specified line to the console, then writes
    /// the specified number of additional blank lines.
    /// </summary>
    /// <param name="line">
    /// The line of text to write.
    /// </param>
    /// <param name="skip">
    /// How many blank lines to insert after writing the line.
    /// </param>
    public static void WriteLine(string line, int skip = 1)
    {
        Console.WriteLine(line);
        WriteLine(skip);
    }

    /// <summary>
    /// Writes the specified line to the console, preceded and followed by
    /// the specified number of blank lines.
    /// </summary>
    /// <param name="line">
    /// The line of text to write.
    /// </param>
    /// <param name="emptyLinesBefore">
    /// The number of blank lines to insert before writing the line.
    /// </param>
    /// <param name="emptyLinesAfter">
    /// The number of blank lines to insert after writing the line.
    /// </param>
    public static void WriteLine(string line, int emptyLinesBefore, int emptyLinesAfter)
    {
        WriteLine(emptyLinesBefore);
        Console.WriteLine(line);
        WriteLine(emptyLinesAfter);
    }

    /// <summary>
    /// Writes the specified number of blank lines to the console.
    /// </summary>
    /// <param name="count">
    /// The number of blank lines to write.
    /// </param>
    public static void WriteEmptyLine(int count = 1)
        => WriteLine(count);

    /// <summary>
    /// Writes a title line, then a line of repeated characters matching the title's length,
    /// followed by two blank lines.
    /// </summary>
    /// <param name="title">
    /// The text of the title to display.
    /// </param>
    /// <param name="character">
    /// The character to repeat for the underline.
    /// </param>
    public static void WriteTitle(string title, char character = '=')
    {
        Console.WriteLine(title);
        Console.WriteLine(new string(character, title.Length));
        Console.WriteLine();
    }

    /// <summary>
    /// Writes a blank line, then a separator line of the specified size and character,
    /// followed by another blank line.
    /// </summary>
    /// <param name="size">
    /// The number of characters in the separator line.
    /// </param>
    /// <param name="character">
    /// The character to repeat for the separator.
    /// </param>
    public static void WriteSeparator(int size = 32, char character = '-')
    {
        Console.WriteLine();
        Console.WriteLine(new string(character, size));
        Console.WriteLine();
    }

    /// <summary>
    /// Writes the specified text as a "section header." This is
    /// purely decorative but can be handy for chunking sample output.
    /// </summary>
    /// <param name="section">
    /// The section header text to display.
    /// </param>
    /// <param name="character">
    /// The separator character, e.g. '-' or '~'.
    /// </param>
    public static void WriteSectionTitle(string section, char character = '-')
    {
        Console.WriteLine();
        Console.WriteLine($"[{section}]");
        Console.WriteLine(new string(character, section.Length + 2));
        Console.WriteLine();
    }

    /// <summary>
    /// Optionally waits for the user to press any key to continue.
    /// Useful in demos when you want to pause output.
    /// </summary>
    /// <param name="prompt">
    /// Prompt message for the user, or null for default text.
    /// </param>
    public static void WaitForKeyPress(string prompt = "Press any key to continue...")
    {
        Console.WriteLine(prompt);
        ReadKey(true);
        Console.WriteLine();
    }
}
