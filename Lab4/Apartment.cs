using System.Data;

public class Apartment : Property
{
    private int floor;
    private bool hasElevator;

    public Apartment(string address, double indoorArea, double propertyValue, int floor, bool hasElevator) : base(address, indoorArea, propertyValue)
    {
        this.floor = floor;
        this.hasElevator = hasElevator;
    }

    public override string ToString()
    {
        return $"Property type: {this.GetType().Name}\n" + base.ToString() + $"Floor: {this.floor}\nHas elevator: {this.hasElevator}\n";
    }
}