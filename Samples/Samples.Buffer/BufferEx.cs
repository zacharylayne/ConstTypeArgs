using ConstTypeArgs.Bools;
using ConstTypeArgs.Ints;

namespace Samples.Buffer;

/// <summary>
/// The <see cref="BufferEx{SIZE, RESIZEABLE, MAX_SIZE}"/> class extends the functionality of the
/// <see cref="SimpleBuffer{SIZE}"/>, adding additional configuration options that can be set through
/// const type arguments.
/// </summary>
public class BufferEx<SIZE, IS_RESIZEABLE, MAX_SIZE>
    : SimpleBuffer<SIZE>
    where SIZE : K_Int
    where IS_RESIZEABLE : K_Bool
    where MAX_SIZE : K_Int
{
    static BufferEx()
    {
        Console.WriteLine($"BufferEx<{SIZE.Value}, {IS_RESIZEABLE.Value}, {MAX_SIZE.Value}> created.");
        Console.WriteLine($"Initial Size: {SIZE.Value}, Resizable: {_IsResizable}, Max Size: {_MaxSize}");
    }

    protected readonly static bool _IsResizable = IS_RESIZEABLE.Value;
    protected readonly static int _MaxSize = MAX_SIZE.Value;

    /// <summary>
    /// Initializes a new <see cref="BufferEx"/> instance.
    /// </summary>
    public BufferEx() { }

    public override void WriteConfiguration()
    {
        // We can write the configuration to console in the type initializer instead of here,
        // since the configuration values are available in static contexts.
    }

    public override void Fill(int value)
    {
        for (int i = 0; i < _Buffer.Length; i++)
            _Buffer[i] = value;
    }

    public bool Resize(int newSize)
    {
        if (!_IsResizable)
        {
            Console.WriteLine("Buffer is not resizable.");
            return false;
        }

        if (newSize > _MaxSize)
        {
            Console.WriteLine($"****CANNOT RESIZE TO {newSize}. MAX SIZE IS {_MaxSize}!!!!****");
            return false;
        }

        Array.Resize(ref _Buffer, newSize);

        Console.WriteLine($"Buffer resized to {newSize}.");
        return true;
    }
}
