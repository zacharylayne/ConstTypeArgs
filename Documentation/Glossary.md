# Glossary

**Const Type Arguments:**  Types that implement [`IConstTypeArg<T>`](..\Source\ConstTypeArgs.Core\IConstTypeArg.cs) which are used as type arguments in order to "pass" values to generic types & methods. These values can be leveraged in a variety of ways, such as "passing" data to static constructors, field & property initialization, configuration, algorithm specialization and more. This term can refer to types holding the values or the values themselves.
  Values are meant to be literals or constants and ***SHOULD ALWAYS BE IMMUTABLE***. This term is interchangable with the values const type arguments define. Also called *const type args*.

**Argument Providers:** A more specific term for *const type arguments* that refers to concrete implementations of `IConstTypeArg<T>`. Also called *arg providers*.

**Argument Values:** A more specific term for *const type arguments* that refers to the value an argument provider defines. Values are meant to be literals or constants and ***SHOULD ALWAYS BE IMMUTABLE***. Also called *arg values*.

**Const Type Parameters:** Generic type parameters that are constrained to const type arguments. Also referred to as *const type params*.

**Argument Consumers:** Generic types & methods with const type parameters, and can *consume* const type arguments. Also called *arg consumers*.

**Argument Types:** Types that inherit from a base interface, `IConstTypeArg<TValue>`, which has a static abstract property `Value`. Argument types are sometimes referred to as *arg types*. Concrete argument types are known as *argument providers*. 

**Argument Holders:** Argument providers that wrap other argument providers. Argument holders can be used to create domain-specific const type arguments for minimums, maximums, defaults, and more. Also called *arg holders* and sometimes referred to as *domain-specific type arguments*.

**Discard Argument:** A type that is used to signify the absence of a const type argument. These types implement a large number of const type interfaces to increase their versatility, and can be used to provide union-like functionality. Also called *discard arg* or *discard*.
