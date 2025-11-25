public class Program
{
    public static void Main()
    {
        // Console.WriteLine("Hello");
        
        InputReader reader = new InputReader();
        reader.OnKeyPressed += (sender, s) => Console.WriteLine(s);

        reader.ReadKeys();
    }
}