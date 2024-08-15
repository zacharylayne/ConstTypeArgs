# Naming Conventions

This document outlines the naming conventions used in the ConstTypeArgs framework, which are used to provide a more expressive and readable codebase.

The following table outlines the naming conventions used in the ConstTypeArgs framework:

| Convention | |
|:-------------------|-|
| `K_` Prefix | The names of argument interfaces *(i.e. interfaces deriving from `IConstTypeArg<T>`)* use this prefix. This is meant to indicate that rather than define a contract, they are the means to "pass" values via generic type parameters. The prefix refers to how `K` is used in mathematic formulas to denote an unknown constant value. |
| `_` Prefix | Many argument providers *(i.e. concrete types that implement `IConstTypeArg<T>`)* in ConstTypeArg libraries have the prefix `_` followed by a representation of their value *(e.g. _1024, _A, _Blue)*. This helps alphabetize and group similar types together. |
| [`__`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/__.cs) Types | Argument types *(i.e. types deriving from or implementing `IConstTypeArg<T>`)* that implement `__` are used as "discards" to indicate they lack a value. These types are simply named `__` and usually explicitly implement multiple arg type interfaces providing either `default` or `null` values. These can be used with argument consumers providing union-like behavior. |

# See Also

* [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/Glossary.md)
* [Overview](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/README.md)
