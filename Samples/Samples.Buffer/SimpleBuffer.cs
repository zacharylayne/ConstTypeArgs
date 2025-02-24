using ConstTypeArgs.Ints;

namespace Samples.Buffer;

/// <summary>
/// The <see cref="SimpleBuffer{SIZE}"/> class demonstrates how to use a const type argument
/// to configure a buffer's size.
/// </summary>
/// <typeparam name="SIZE">
/// The buffer's size.
/// </typeparam>
public class SimpleBuffer<SIZE>
    where SIZE : K_Int
{
    protected int[] _Buffer = new int[SIZE.Value];

    public SimpleBuffer()
    {
        WriteConfiguration();
    }

    public virtual void WriteConfiguration()
    {
        Console.WriteLine($"SimpleBuffer<{SIZE.Value}> created.");
        Console.WriteLine($"Buffer size: {SIZE.Value}");
    }

    public virtual void Fill(int value)
    {
        for (int i = 0; i < SIZE.Value; i++)
            _Buffer[i] = value;
    }

    public void Print()
    {
        Console.WriteLine($"Buffer contents: {string.Join(", ", _Buffer)}");
    }
}
