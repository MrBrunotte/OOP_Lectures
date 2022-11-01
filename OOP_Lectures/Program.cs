
// from ClassInheritance.cs
//BaseClass ccc = new Class3();
//Class1 newClass1AsClass2 = new Class2();
//Class2 newClass2AsClass3 = new Class3();

using CarExample;

// use var to implicitly get the correct type
FuelVehicle fuelVehicle2 = new FuelVehicle("ABC123", 50);
var fuelVehicle = new FuelVehicle("ABC123", 50);

fuelVehicle.FuelLevel = -3;             // returns the Max value 0
var level = fuelVehicle.FuelLevel;
Console.WriteLine($"Level : {level}");

fuelVehicle.FuelLevel = 3;              // returns the Max value 3
var level2 = fuelVehicle.FuelLevel;
Console.WriteLine($"Level2 : {level2}");

