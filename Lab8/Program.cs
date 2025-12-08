public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");

        InputReader reader = new InputReader();

        Tamagotchi dog = new Tamagotchi("Dog", 4, 2000, 'd', reader);
        Tamagotchi cat = new Tamagotchi("Cat", 7, 3500, 'c', reader);

        Task dogTask = dog.run();
        Task catTask = cat.run();

        reader.ReadKeys();
    }
}