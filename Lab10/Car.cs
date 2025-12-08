public class Car
{
    public int id;
    public string? make;
    public string? model;
    public int year;
    public decimal price;
    public int mileage;
    public string? fuelType;

    public override string ToString()
    {
        return $"ID: {id}\tMake: {make}\tModel: {model}\tYear: {year}\tPrice: {price}\tMileage: {mileage}\tFuel Type: {fuelType}";
    }
}