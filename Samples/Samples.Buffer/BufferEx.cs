using ConstTypeArgs.Bools;
using ConstTypeArgs.Ints;

namespace Samples.Buffer;

public class BufferEx<SIZE, RESIZABLE, MAX>
    : SimpleBuffer <SIZE>
    where SIZE        : K_Int
    where RESIZABLE   : K_Bool
    where MAX         : K_Int
{
    static BufferEx()
    {
        Console.WriteLine($"BufferEx<{SIZE.Value}, {RESIZABLE.Value}, {MAX.Value}> created.");
        Console.WriteLine($"Initial Size: {SIZE.Value}, Resizable: {_IsResizable}, Max Size: {_MaxSize}");
    }

    // We don't have to assign these to their own properties, but we're demonstrating how to access
    // the const type argument values in a static context.
    protected readonly static bool _IsResizable = RESIZABLE.Value;
    protected readonly static int _MaxSize = MAX.Value;

    public override void WriteConfiguration()
    {
        // To demonstrate, we can simply write the configuration to console
        // in the type initializer instead of in an instance method,
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
