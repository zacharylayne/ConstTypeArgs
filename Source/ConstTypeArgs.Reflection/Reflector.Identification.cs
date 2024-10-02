namespace ConstTypeArgs.Reflection;

using static WellKnownConstTypes;

public sealed partial class Reflector
{
    // #QUESTION?: Should there be entries for Func, Action, Predicate, Converter, RefFunc, RefAction,
    //             arrays, ReadOnlyMemory, etc.?

    // This isn't ideal but we aren't going to reference every package that has well-known types in it
    // just to get names.
    // TypeNamesToWellKnownConstTypes will need to be manually updated should any new well-known const types
    // be added or are renamed.

    /// <summary>
    /// A map of the names of well-known types to their equivalent <see cref="WellKnownConstTypes"/> fields.
    /// </summary>
    private static readonly Dictionary<string, WellKnownConstTypes> TypeNamesToWellKnownConstTypes = new()
    {
        { nameof(K_Bool),        K_Bool        },
        { nameof(K_Byte),        K_Byte        },
        { nameof(K_Char),        K_Char        },
        { nameof(K_Decimal),     K_Decimal     },
        { nameof(K_Double),      K_Double      },
        { nameof(K_Float),       K_Float       },
        { nameof(K_Half),        K_Half        },
        { nameof(K_Int),         K_Int         },
        { nameof(K_Int128),      K_Int128      },
        { nameof(K_Long),        K_Long        },
        { nameof(K_Nint),        K_Nint        },
        { nameof(K_Nuint),       K_Nuint       },
        { nameof(K_Sbyte),       K_Sbyte       },
        { nameof(K_Short),       K_Short       },
        { nameof(K_String),      K_String      },
        { nameof(K_Type),        K_Type        },
        { nameof(K_Uint),        K_Uint        },
        { nameof(K_UInt128),     K_UInt128     },
        { nameof(K_Ulong),       K_Ulong       },
        { nameof(K_Ushort),      K_Ushort      },
        { nameof(IConstTypeArg), IConstTypeArg },
        { nameof(K),             K             },
        { nameof(__),            __            },
    };

    public sealed partial class Type<T>;
}
