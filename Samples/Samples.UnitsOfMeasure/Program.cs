using Samples.UnitsOfMeasure;

using static Samples.SampleConsoleHelper;

WriteTitle("Units of Measure Sample");

// Create a measurement of 5 kilometers.
var kmDistance = new Length<Kilometer>(5.0);
Console.WriteLine($"Distance: {kmDistance} = {kmDistance.ToMeters()} meters");

WriteSeparator();

// Convert it into miles.
var milesDistance = kmDistance.ConvertTo<Mile>();
Console.WriteLine($"{kmDistance} = {milesDistance} (approx)");

WriteSeparator();

// Convert into to feet.
var feetDistance = kmDistance.ConvertTo<Foot>();
Console.WriteLine($"{kmDistance} = {feetDistance} (approx)");

WriteSeparator();

// Create a measurement in feet and convert into meters.
var shortDistance = new Length<Foot>(30.0);
Console.WriteLine($"{shortDistance} = {shortDistance.ToMeters()} meters");

WriteEmptyLine();

WaitForKeyPress();
