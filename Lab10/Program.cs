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
        
        // Console.WriteLine("Procedural");
        // List<Car> recentCars = dealership.getRecentCars(year);
        // Console.WriteLine($"Automobile fabricate dupa anul {year}");
        // printCars(recentCars);

        // Console.WriteLine("Declarativ");
        // var recentCarsDeclarative = (from car in cars
        //                             where car.year > year
        //                             select car).ToList();
        // printCars(recentCarsDeclarative);
        
        // 2
        // string fuelType = "Electric";

        // Console.WriteLine("Procedural");        
        // List<Car> electricCars = dealership.getCarsByFuelType(fuelType);
        // Console.WriteLine($"Automobile cu tipul de combustibil {fuelType}");
        // printCars(electricCars);

        // Console.WriteLine("Declarativ");
        // var electricCarsDeclarative = (from car in cars
                                    //   where car.fuelType == fuelType
                                    //   select car).ToList();
        // printCars(electricCarsDeclarative);

        // 3
        // Console.WriteLine("Procedural");        
        // Car mostExpensive = dealership.getMostExpensiveCar();
        // Console.WriteLine($"Cea mai scumpa masina este\n{mostExpensive}");
    
        // Console.WriteLine("Declarativ");
        // var mostExpensiveDeclarative = (from car in cars
        //                                    orderby car.price descending
        //                                    select car).FirstOrDefault();
        // Console.WriteLine($"Cea mai scumpa masina este\n{mostExpensiveDeclarative}");
        
        // 4
        // int mileageLimit = 50000;

        // Console.WriteLine("Procedural");        
        // decimal averagePrice = dealership.averagePriceOfCarsUnderMileage(mileageLimit);
        // Console.WriteLine($"Pretul mediu al masinilor cu mai putin de {mileageLimit} km: {averagePrice:C}");

        // Console.WriteLine("Declarativ");
        // var averagePriceDeclarative = (from car in cars
                                    //    where car.mileage < mileageLimit
                                    //    select (decimal?)car.price)
                                    //    .Average();
        // Console.WriteLine($"Pretul mediu al masinilor cu mai putin de {mileageLimit} km: {averagePriceDeclarative:C}");

        // 5
        // Console.WriteLine("Procedural");        
        // var fuelTypes = dealership.getCarCountsByFuelType();
        // foreach(var type in fuelTypes)
        // {
        //     Console.WriteLine($"Combustibil: {type.Key} - {type.Value} masini");
        // }

        // Console.WriteLine("Declarativ");
        // var fuelTypesDeclarative = from car in cars
        //                                group car by car.fuelType into g
        //                                select new { FuelType = g.Key, Count = g.Count() };
        // foreach(var type in fuelTypesDeclarative)
        // {
        //     Console.WriteLine($"Combustibil: {type.FuelType} - {type.Count} masini");
        // }

        // 6
        // decimal priceLimit = 20000;

        // Console.WriteLine("Procedural");
        // string modelsInfo = dealership.selectModelAndYearUnderPrice(priceLimit);
        // Console.WriteLine($"Info modele sub pretul {priceLimit:C}: \n{modelsInfo}");

        // Console.WriteLine("Declarativ");
        // var modelsInfoDeclarative = from car in cars
        //                                   where car.price < priceLimit
        //                                   select new { car.model, car.year, car.price };
        // foreach (var car in modelsInfoDeclarative)
        // {
        //     Console.WriteLine($"Model: {car.model}\tAn: {car.year}\tPret: {car.price:C}");
        // }

        // 7
        // List<string> makes = new List<string>{"Toyota", "Honda"};

        // Console.WriteLine("Procedural");        
        // List<Car> carsByMake = dealership.carsMadeBy(makes);
        // printCars(carsByMake);

        // var carsByMakeDeclarative = (from car in cars
                                    //  where makes.Contains(car.make!)
                                    //  select car).ToList();
        // Console.WriteLine("Declarativ");
        // printCars(carsByMakeDeclarative);

        // 8
        // Console.WriteLine("Procedural");        
        // List<Car> orderedCars = dealership.orderDescendingByYear();
        // Console.WriteLine("Masini ordonate descrescator dupa an:");
        // printCars(orderedCars, PrintModes.SHORT);

        // Console.WriteLine("Declarativ");
        // var orderedCarsDeclarative = (from car in cars
        //                             orderby car.year descending
        //                             select car).ToList();
        // Console.WriteLine("Masini ordonate descrescator dupa an:");
        // printCars(orderedCarsDeclarative);

        // 9
        // int highMileage = 80000;

        // Console.WriteLine("Procedural");        
        // string ids = dealership.getIdHigherMileage(highMileage);
        // Console.WriteLine($"ID-urile masinilor cu peste {highMileage} km: {ids}");

        // Console.WriteLine("Declarativ");
        // var idHigherMileageDeclarative = from car in cars
        //                                 where car.mileage > highMileage
        //                                 select car.id;
        // string ids = string.Join(", ", idHigherMileageDeclarative);
        // Console.WriteLine($"ID-urile masinilor cu peste {highMileage} km: {ids}");

        // 10
        int yearLimitSum = 2015;

        // Console.WriteLine("Procedural");
        // decimal totalPrice = dealership.getSumOfPriceLowerYear(yearLimitSum);
        // Console.WriteLine($"Suma totala a preturilor masinilor fabricate inainte de {yearLimitSum}: {totalPrice:C}");
    
        // Console.WriteLine("Declarativ");
        var totalPriceDeclarative = (from car in cars
                                        where car.year < 2015
                                        select car.price)
                                        .Sum();
        Console.WriteLine($"Suma totala a preturilor masinilor fabricate inainte de {yearLimitSum}: {totalPriceDeclarative:C}");
            
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
        if (printMode == PrintModes.SHORT)
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