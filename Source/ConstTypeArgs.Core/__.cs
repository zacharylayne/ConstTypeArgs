namespace ConstTypeArgs;

/// <summary>
/// The <see cref="__"/> interface is a special type of marker interface
/// meant to identify const type args that are used as discards in type parameter
/// list with union-like behavior.
/// </summary>
public abstract class __ : Core.__, IConstTypeArg<object>
{ static object IConstTypeArg<object>.Value => new(); }
