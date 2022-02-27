// See https://aka.ms/new-console-template for more information

using CarAndPredicates;

List<Car> allCars = Car.GetRandomCars();
List<Car> carWithLessThan200EngineSizes = allCars.FindAll(car => car.EngineSize < 200);
List<Car> yellowOrBlueColoredCars = allCars.FindAll(car => car.Color.Equals("Yellow") || car.Color.Equals("Blue")); 
List<Car> onlyManualShiftCars = allCars.FindAll(car => car.IsManualShift);


foreach (var i in carWithLessThan200EngineSizes) {
    Console.WriteLine(i);
}
         // This is the easier way to loop in a list...
carWithLessThan200EngineSizes.ForEach(car => Console.WriteLine(car));

      // This is the traditional way to loop through a list...
foreach (var i in yellowOrBlueColoredCars) {
    Console.WriteLine(i);
}
foreach (var i in onlyManualShiftCars) {
    Console.WriteLine(i);
}