public class InputReader
{
    public event EventHandler<string> OnKeyPressed;

    public void InvokeOnKeyPressed(string input)
    {
        OnKeyPressed?.Invoke(this, new string(input));
    }

    public void ReadKeys()
    {
        string line;

        while(true)
        {
            line = Console.ReadLine();

            if(string.IsNullOrEmpty(line)) break;

            this.InvokeOnKeyPressed(line);
        }
    }
}