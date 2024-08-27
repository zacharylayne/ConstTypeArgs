namespace ConstTypeArgs.Core.Tests;

public partial class ConstTypeArgInterfaceTests
{
    public readonly struct IntConstTypeArg : IConstTypeArg<int, IntConstTypeArg>
    { public static int Value => 42; }

    public readonly struct UintConstTypeArg : IConstTypeArg<uint, UintConstTypeArg>
    { public static uint Value => 42u; }

    public readonly struct  FloatConstTypeArg : IConstTypeArg<float, FloatConstTypeArg>
    { public static float Value => 42.0f; }

    public readonly struct StringArg : IConstTypeArg<string, StringArg>
    { public static string Value => "Hello, World!"; }

    public readonly struct IntArrayArg : K_Array<int>
    { public static int[] Value => [1, 2, 3]; }

    public readonly struct StringArrayArg : K_Array<string>
    { public static string[] Value => ["A", "B", "C"]; }

    public readonly struct StringClassArg : K_Class<string>
    { public static string Value => "Class String!"; }

    public readonly struct ObjectClassArg : K_Class<object>
    { public static object Value => new(); }

    public readonly struct ActionDelegateArg : K_Delegate<Action>
    { public static Action Value => () => Console.WriteLine("Action delegate executed!"); }

    public readonly struct FuncDelegateArg : K_Delegate<Func<int>>
    { public static Func<int> Value => () => 42; }

    public enum TestEnum { A, B, C }

    public readonly struct EnumArg : K_Enum<TestEnum>
    { public static TestEnum Value => TestEnum.B; }

    public readonly struct MulticastDelegateArg : K_MulticastDelegate<Action>
    { public static Action Value => () => Console.WriteLine("Multicast delegate executed!"); }

    public readonly struct IntNumberArg : K_Number<int>
    { public static int Value => 10; }

    public readonly struct FloatNumberArg : K_Number<float>
    { public static float Value => 3.14f; }

    public readonly struct StringReadOnlyMemoryArg : K_ReadOnlyMemory<string>
    { public static ReadOnlyMemory<string> Value => new[] { "Hello", "World" }; }

    public readonly struct StringReadOnlyMemoryArrayArg : K_ReadOnlyMemoryArray<string>
    {
        public static ReadOnlyMemory<string>[][] Value =>
            [
                [ new ReadOnlyMemory<string>(["Hello", "World"]) ],
                [ new ReadOnlyMemory<string>(["World", "Hello"]) ]
            ];
    }

    public readonly struct StringReadOnlyMemoryTArrayArg : K_ReadOnlyMemoryT_Array<string>
    { public static ReadOnlyMemory<string[]> Value => new[] { new[] { "Hello", "World" } }; }

    public readonly struct PointStructArg : K_Struct<(int X, int Y)>
    { public static (int X, int Y) Value => (10, 20); }

    public readonly struct RectangleStructArg : K_Struct<(int Width, int Height)>
    { public static (int Width, int Height) Value => (100, 200); }

    public readonly struct IntUnmanagedArg : K_Unmanaged<int>
    { public static int Value => 100; }

    public readonly struct FloatUnmanagedArg : K_Unmanaged<float>
    { public static float Value => 1.23f; }
}
