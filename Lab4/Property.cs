public abstract class Property
{
    private string address;
    private double indoorArea;
    private double propertyValue;
    public Property(string address, double indoorArea, double propertyValue)
    {
        this.address = address;
        this.indoorArea = indoorArea;
        this.propertyValue = propertyValue;
    }

    public string getAddress() => address;
    public double getIndoorArea() => indoorArea;
    public double getPropertyValue() => propertyValue;
    

    public override string ToString()
    {
        return $"Property at address: {this.getAddress()}\nProperty value: {this.getPropertyValue()}\nIndoor Area: {this.getIndoorArea()}\n";
    }
}
