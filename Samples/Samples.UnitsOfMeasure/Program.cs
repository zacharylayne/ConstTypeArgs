using Samples.UnitsOfMeasure;

using static Samples.SampleConsoleHelper;

WriteTitle("Units of Measure Sample");

// Create a measurement of 5 kilometers.
var km = new Length<Kilometer>(5.0);
Console.WriteLine($"Distance: {km} = {km.ToMeters()} meters");
                                                                WriteSeparator();

// Convert it into miles.
var miles = km.ConvertTo<Mile>();
Console.WriteLine($"{km} = {miles} (approx)");
                                                                WriteSeparator();

// Convert it to feet.
var feet = km.ConvertTo<Foot>();
Console.WriteLine($"{km} = {feet} (approx)");
                                                                WriteSeparator();

// Create a measurement in feet and convert into meters.
feet = new Length<Foot>(30.0);
Console.WriteLine($"{feet} = {feet.ToMeters()} meters");
                                                                WriteEmptyLine();

WaitForKeyPress();

/**
Output:

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
**/
