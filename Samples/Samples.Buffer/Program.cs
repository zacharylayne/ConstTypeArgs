using ConstTypeArgs.Bools;
using ConstTypeArgs.Ints;
using Samples.Buffer;

using static Samples.SampleConsoleHelper;

WriteTitle("Buffer Sample");

WriteLine($"Creating a buffer of size {_5.Value}.", 0, 1);

var smallBuffer = new SimpleBuffer<_5>(); // SimpleBuffer<Size>
smallBuffer.Fill(1);
smallBuffer.Print();
WriteSeparator();

WriteLine($"Creating a larger buffer of size {_32.Value}.", 1);

var largerBuffer = new SimpleBuffer<_32>();
largerBuffer.Fill(2);
largerBuffer.Print();
WriteSeparator();

WriteLine($"Creating a resizable buffer of size {_16.Value} and a maximum size of {_64.Value}.", 1);

var resizableBuffer = new BufferEx<_16, True, _64>(); // BufferEx<Min, Resizable, Max>
resizableBuffer.Fill(3);
resizableBuffer.Print();
WriteSeparator();

WriteLine("Resizing the buffer by 16!");

resizableBuffer.Resize(32);
resizableBuffer.Fill(4);
resizableBuffer.Print();
WriteSeparator();

WriteLine("Attempting to resize the buffer by 64!");

resizableBuffer.Resize(64);
resizableBuffer.Fill(5);
resizableBuffer.Print();
WriteSeparator();

WriteLine("Attempting to resize the buffer by 128!");

resizableBuffer.Resize(128);
resizableBuffer.Fill(6);
resizableBuffer.Print();
WriteEmptyLine(2);

WaitForKeyPress();
