using System.Security.Cryptography;

public class Dealership
{
    private List<Car> cars;

    public Dealership(List<Car> cars)
    {
        this.cars = cars;
    }

    public List<Car> getRecentCars(int year)
    {
        return cars.Where(car => car.year > year).ToList();
    }

    public List<Car> getCarsByFuelType(string fuelType)
    {
        return cars.Where(car => car.fuelType == fuelType).ToList();
    }

    public Car getMostExpensiveCar()
    {
        return cars.MaxBy(car => car.price) ?? throw new InvalidOperationException("Lista de masini este goala.");
    }

    public decimal averagePriceOfCarsUnderMileage(int mileage)
    {
        return cars.Where(car => car.mileage < mileage).Average(car => car.price);
    }

    public Dictionary<string, int> getCarCountsByFuelType()
    {
        return cars.GroupBy(car => car.fuelType).ToDictionary(group => group.Key ?? "Necunoscut", group => group.Count());
    }

    public string selectModelAndYearUnderPrice(decimal price)
    {
        var makeAndYear = cars.Where(car => car.price < price).Select(car => $"Model: {car.model}\tYear: {car.year}\tPrice: {car.price:C}");
        return string.Join("\n", makeAndYear);
    }

    public List<Car> carsMadeBy(List<string> makers)
    {
        return cars.Where(car => makers.Contains(car.make!)).ToList();
    }

    public List<Car> orderDescendingByYear()
    {
        return cars.OrderByDescending(car => car.year).ToList();
    }

    public string getIdHigherMileage(int mileage)
    {
        var ids = cars.Where(car => car.mileage > mileage).Select(car => $"{car.id}");
        return string.Join(", ", ids);
    }

    public decimal getSumOfPriceLowerYear(int year)
    {
        return cars.Where(car => car.year < year).Sum(car => car.price);
    }
}