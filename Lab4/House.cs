using System.Data;

public class House : Property
{
    private double outdoorArea;
    private double totalArea;

    public House(string address, double indoorArea, double propertyValue, double outdoorArea) : base(address, indoorArea, propertyValue)
    {
        this.outdoorArea = outdoorArea;
        this.totalArea = outdoorArea + indoorArea;
    }

    public override string ToString()
    {
        return $"Property type: {this.GetType().Name}\n" + base.ToString() + $"Outdoor Area: {this.outdoorArea}\nTotal Area: {this.totalArea}";
    }
}