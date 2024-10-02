#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace ConstTypeArgs.Core;

/// <summary>
/// The <see cref="__"/> interface is a special type of marker interface
/// meant to identify const type args that are used as discards in type parameter
/// list with union-like behavior.
/// </summary>
public interface __ : IConstTypeArg;
