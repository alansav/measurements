# Measurements

This project is a .NET Core class library.

This project is designed to aid developers when working with units of measurements.

At the moment the only unit of measurement is distance, but the plan is to add additional measurements later.

##Usage

In your project use nuget to add a reference to Measurements

`Install-Package Measurements`

###Distance
Distance is used when tracking the distance between two points, regardless of the unit of measurement used the distance between two points is static, for example the distance between London and San Francisco is the same physical distance whether we represent it in mile, kilometers or meters.

Units of measure Available

 * Meters
 * Kilometers
 * Feet
 * Yards
 * Miles

```
var distance = new Savage.Measurements.Distance(5000, Savage.Measurements.UnitsOfMeasure.Distances.Kilometers);

var meters = distance.Convert(Savage.Measurements.UnitsOfMeasure.Distances.Meters); //meters.Value = 5000000

var miles = distance.Convert(Savage.Measurements.UnitsOfMeasure.Distances.Miles); //miles.Value = 3106.85596118667
var yards = distance.Convert(Savage.Measurements.UnitsOfMeasure.Distances.Yards); // yards.Value = 5468066.4916885393
var feet = distance.Convert(Savage.Measurements.UnitsOfMeasure.Distances.Feet);  // feet.Value = 16404199.475065617
```