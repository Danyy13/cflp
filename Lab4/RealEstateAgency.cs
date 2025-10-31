using System.Runtime.CompilerServices;

public class RealEstateAgency
{
    private List<Property> properties = new List<Property> {};
    public RealEstateAgency()
    {

    }

    public void addProperty(Property property)
    {
        this.properties.Add(property);
    }
    
    public bool rentProperty(string address)
    {
        Property propertyToRent = null;
        foreach (Property property in properties)
        {
            if (property.getAddress().Equals(address))
            {
                propertyToRent = property;
                break;
            }
        }

        if (propertyToRent == null)
        {
            Console.WriteLine("Proprietatea nu a fost gasita\n");
            return false;
        }

        RentableApartment apartmentToRent = propertyToRent as RentableApartment;

        if (apartmentToRent == null)
        {
            Console.WriteLine("Property is not rentable\n");
            return false;
        }
        if(apartmentToRent.getIsRented() == true)
        {
            Console.WriteLine($"Property at address {apartmentToRent.getAddress()} is already rented\n");
            return false;
        }
        {
            apartmentToRent.setIsRented(true);
            Console.WriteLine($"Property at address {apartmentToRent.getAddress()} has been sucessfully rented\n");
            return true;
        }
    }
}