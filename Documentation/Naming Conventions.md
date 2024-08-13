# Naming Conventions

The ConstTypeFramework modifies standard naming conventions in order to provide a more expressive and readable codebase, outlined in the following table:

| Convention | |
|:-------------------|-|
| `K_` Prefix | The names of argument interfaces *(i.e. interfaces deriving from `IConstTypeArg<T>`)* use this prefix. This is meant to indicate that rather than define a contract, they are the means to "pass" values via generic type parameters. The prefix refers to how `K` is used in mathematic formulas to denote an unknown constant value. |
| `_` Prefix | Many argument providers *(i.e. concrete types that implement `IConstTypeArg<T>`)* in ConstTypeArg libraries have the prefix `_` followed by a representation of their value *(e.g. _1024, _A, _Blue)*. This helps alphabetize and group similar types together. |
| [`__`](#__) Types | Argument types *(i.e. types deriving from or implementing `IConstTypeArg<T>`)* that implement [`__`](/Core/__.cs) are used as "discards" to indicate they lack a value. These types are simply named `__` and usually explicitly implement multiple arg type interfaces and provide either `default` or `null` values. These can be used with argument consumers providing union-like behavior. |

# See Also

* [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/Glossary.md)
* [Overview](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/README.md)
