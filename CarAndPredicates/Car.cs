namespace CarAndPredicates;

public class Car {
    public string Color { get; set; }
    public int EngineSize { get; set; }
    public double FuelPer100Km { get; set; }
    public bool IsManualShift { get; set; }

    public Car(string color, int engineSize, double fuelPer100Km, bool isManualShift) {
        Color = color;
        EngineSize = engineSize;
        FuelPer100Km = fuelPer100Km;
        IsManualShift = isManualShift;
    }

    public static List<Car> GetRandomCars() {
        string[] possibleColors = new[] {"Yellow", "Green", "Blue", "Red", "Black", "Orange", "Pink"};
        int[] possibleEngineSizes = new[] {220, 245, 210, 175, 195, 320};
        double[] possibleFuelEconomy = new double[] {5, 4, 3, 6.5, 2, 7, 8};
        bool[] possibleIsManualShift = new[] {true, false};
        Random random = new Random();


        List<Car> temp = new List<Car>();
        for (int i = 0; i < 6; i++) {
            temp.Add(new Car(possibleColors[random.Next(possibleColors.Length)],
                possibleEngineSizes[random.Next(possibleEngineSizes.Length)],
                possibleFuelEconomy[random.Next(possibleFuelEconomy.Length)],
                possibleIsManualShift[random.Next(possibleIsManualShift.Length)]));
        }

        return temp;
    }


    public override string ToString() {
        return
            $"Color : {Color} \t Engine size : {EngineSize} \t Fuel Economy : {FuelPer100Km} per 100 km \t Is Manual Shift :{IsManualShift}";
    }
}