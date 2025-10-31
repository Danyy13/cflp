using System.Data;

public class RentableApartment : Apartment
{
    private bool isRented;
    private double monthlyRent;

    public RentableApartment(string address, double indoorArea, double propertyValue, int floor, bool hasElevator, bool isRented, double monthlyRent) : base(address, indoorArea, propertyValue, floor, hasElevator)
    {
        this.isRented = isRented;
        this.monthlyRent = monthlyRent;
    }

    public bool getIsRented()
    {
        return this.isRented;
    }
    public void setIsRented(bool isRented)
    {
        this.isRented = isRented;
    }

    public override string ToString()
    {
        return base.ToString() + $"Is rented: {this.isRented}\nMonthly Rent: {this.monthlyRent}\n";
    }
}