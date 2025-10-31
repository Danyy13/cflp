public class MainClass
{
    public static void Main()
    {
        // Console.WriteLine("Hello World!");

        Property house = new House("Strada 1", 100, 150000, 54);
        Property apartment = new Apartment("Strada 25", 51, 100000, 2, false);
        Property rentableApartment = new RentableApartment("Strada 19", 52, 95000, 3, true, false, 250);
        Property unrentableApartment = new RentableApartment("Strada 22", 45, 98000, 3, false, true, 300);
        // Console.WriteLine(house.ToString());
        // Console.WriteLine(rentableApratment.ToString());

        RealEstateAgency realEstateAgency = new RealEstateAgency();
        realEstateAgency.addProperty(house);
        realEstateAgency.addProperty(apartment);
        realEstateAgency.addProperty(rentableApartment);
        realEstateAgency.addProperty(unrentableApartment);

        realEstateAgency.rentProperty("Strada 19");
        realEstateAgency.rentProperty("Strada 22");
    }
}