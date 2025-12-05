public class Program
{
    public static void Main()
    {
        // Console.WriteLine("Hello");
        
        InputReader reader = new InputReader();
        CharListener char1 = new CharListener('d', reader);
        CharListener char2 = new CharListener('a', reader);

        ComplexListener complex1 = new ComplexListener(3, reader);

        reader.ReadKeys();
    }
}