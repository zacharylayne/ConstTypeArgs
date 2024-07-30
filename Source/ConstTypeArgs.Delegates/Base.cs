using ConstTypeArgs.Core;
using ConstTypeArgs.Delegates.Actions;

#pragma warning disable IDE1006 // Naming Styles

namespace ConstTypeArgs.Delegates.Funcs;

public interface K_DelegateArray<out T>
    : K_Array<Delegate>;