# Units of Measure Sample

This sample demonstrates a type-safe, compile–time–like approach to working with physical units using the ConstTypeArgs framework. Instead of using raw numbers and magic values for conversions, <abbr title="Types that 'pass' values to generics through generic type parameteres">const type args</abbr> are used to define each unit (meters, kilometers, inches, feet, etc.) as its own type. These types encapsulate both the conversion factor to a base unit (meters) and metadata like the unit’s name, plural name, and abbreviation.

**Key features:**

- **Strongly typed units:**  
  Each unit is a concrete type (e.g. `Meter`, `Kilometer`, `Foot`) that implements a common <abbr title="An interface that derives from IConstTypeArg&lt;T&gt;; const type args implement the 'most derived' interfaces">arg interface</abbr> (`K_Length<TSelf>`), ensuring consistency and type safety across conversions.

- **Compile–time–like configuration:**  
  The conversion factors and descriptive information are embedded in the unit types as static members. This mimics compile-time specialization, allowing your conversion logic to be resolved and optimized without runtime overhead.

- **Seamless unit conversions:**  
  The generic `Length<UnitArg>` class uses the unit type to perform conversions. You can easily convert a measurement from one unit to another, with the conversion process governed by the static properties of the unit types.

- **Readable &amp; self-documenting code:**  
  By replacing raw numeric values with descriptive unit types, your code becomes more intuitive. For example, it’s immediately clear when a measurement is in kilometers or feet, and the formatted output uses the proper unit names and abbreviations.

**Usage:**

```csharp
using Samples.UnitsOfMeasure;
using static Samples.SampleConsoleHelper;

// Create a measurement of 5 kilometers.
var kmDistance = new Length<Kilometer>(5.0);
Console.WriteLine($"Distance: {kmDistance} = {kmDistance.ToMeters()} meters");

// Convert it into miles.
var milesDistance = kmDistance.ConvertTo<Mile>();
Console.WriteLine($"{kmDistance} = {milesDistance} (approx)");

// Convert it into feet.
var feetDistance = kmDistance.ConvertTo<Foot>();
Console.WriteLine($"{kmDistance} = {feetDistance} (approx)");

// Create a measurement in feet and convert it into meters.
var shortDistance = new Length<Foot>(30.0);
Console.WriteLine($"{shortDistance} = {shortDistance.ToMeters()} meters");

WaitForKeyPress()
```

Output:

```
Units of Measure Sample
=======================

Distance: 5 kilometers (km) = 5000 meters

--------------------------------

5 kilometers (km) = 3.1068559611866697 miles (mi) (approx)

--------------------------------

5 kilometers (km) = 16404.199475065616 feet (ft) (approx)

--------------------------------

30 feet (ft) = 9.144 meters

Press any key to continue...
```

This sample illustrates how you can leverage const type arguments to create a flexible and expressive units-of-measure system. By encoding unit conversion factors and metadata at the type level, you achieve a robust solution that minimizes errors and enhances both readability and maintainability.

<br>

## Other samples

[**Buffer**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.Buffer) - Uses const type args for static polymorphism, creating compiled types representing buffers of different sizes &amp; resize functionality.
