public enum PrintModes : int
{
    DEFAULT = 0,
    SHORT
}
public class Program
{
    public static void Main()
    {
        string filePath = "cars.csv";
        List<Car> cars = ReadCarsFromFileCSV(filePath);

        Dealership dealership = new Dealership(cars);

        // 1
        // int year = 2018;
        // List<Car> recentCars = dealership.getRecentCars(year);
        // Console.WriteLine($"Automobile fabricate dupa anul {year}");
        // printCars(recentCars, PrintModes.SHORT);

        // 2
        // string fuelType = "Electric";
        // List<Car> electricCars = dealership.getCarsByFuelType(fuelType);
        // Console.WriteLine($"Automobile cu tipul de combustibil {fuelType}");
        // printCars(electricCars);

        // 3
        // Car mostExpensive = dealership.getMostExpensiveCar();
        // Console.WriteLine($"Cea mai scumpa masina este\n{mostExpensive}");
    
        // 4
        // int mileageLimit = 50000;
        // decimal averagePrice = dealership.averagePriceOfCarsUnderMileage(mileageLimit);
        // Console.WriteLine($"Pretul mediu al masinilor cu mai putin de {mileageLimit} km: {averagePrice:C}");

        // 5
        // var fuelTypes = dealership.getCarCountsByFuelType();
        // foreach(var type in fuelTypes)
        // {
        //     Console.WriteLine($"Combustibil: {type.Key} - {type.Value} masini");
        // }

        // 6
        // decimal priceLimit = 20000;
        // string modelsInfo = dealership.selectModelAndYearUnderPrice(priceLimit);
        // Console.WriteLine($"Info modele sub pretul {priceLimit:C}: \n{modelsInfo}");

        // 7
        List<string> makes = new List<string>{"Toyota", "Honda"};
        List<Car> carsByMake = dealership.carsMadeBy(makes);
        printCars(carsByMake);

        // 8
        // List<Car> orderedCars = dealership.orderDescendingByYear();
        // Console.WriteLine("Masini ordonate descrescator dupa an:");
        // printCars(orderedCars, PrintModes.SHORT);

        // 9
        // int highMileage = 80000;
        // string ids = dealership.getIdHigherMileage(highMileage);
        // Console.WriteLine($"ID-urile masinilor cu peste {highMileage} km: {ids}");

        // 10
        // int yearLimitSum = 2015;
        // decimal totalPrice = dealership.getSumOfPriceLowerYear(yearLimitSum);
        // Console.WriteLine($"Suma totala a preturilor masinilor fabricate inainte de {yearLimitSum}: {totalPrice:C}");
    }

    public static List<Car> ReadCarsFromFileCSV(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var cars = lines.Skip(1).Select( line =>
        {
            var columns = line.Split(',');
            return new Car
            {
                id = int.Parse(columns[0]),
                make = columns[1],
                model = columns[2],
                year = int.Parse(columns[3]),
                price = decimal.Parse(columns[4]),
                mileage = int.Parse(columns[5]),
                fuelType = columns[6]
            };
        }).ToList();

        return (List<Car>)cars;
    }

        public static void printCars(List<Car> cars, PrintModes printMode = PrintModes.DEFAULT)
    {
        if(printMode == PrintModes.SHORT)
        {
            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.make} {car.model} ({car.year}) - {car.price:C}");
            }
            return;
        }

        foreach(Car car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}