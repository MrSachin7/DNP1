// See https://aka.ms/new-console-template for more information

using CarAndPredicates;

List<Car> allCars = Car.GetRandomCars();
List<Car> carWithLessThan200EngineSizes = allCars.FindAll(car => car.EngineSize < 200);
List<Car> yellowOrBlueColoredCars = allCars.FindAll(car => car.Color.Equals("Yellow") || car.Color.Equals("Blue")); 
List<Car> onlyManualShiftCars = allCars.FindAll(car => car.IsManualShift);

// Console.WriteLine(carWithLessThan200EngineSizes);
// Console.WriteLine(yellowOrBlueColoredCars);
// Console.WriteLine(onlyManualShiftCars);

foreach (var i in carWithLessThan200EngineSizes) {
    Console.WriteLine(i);
}
foreach (var i in yellowOrBlueColoredCars) {
    Console.WriteLine(i);
}
foreach (var i in onlyManualShiftCars) {
    Console.WriteLine(i);
}