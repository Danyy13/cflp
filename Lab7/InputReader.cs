public class InputReader
{
    public event EventHandler<KeyboardInputEventArgs> OnKeyPressed;

    public void InvokeOnKeyPressed(string input)
    {
        OnKeyPressed?.Invoke(this, new KeyboardInputEventArgs(input));
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

public class KeyboardInputEventArgs : EventArgs
{
    public string InputString { get; private set; }

    public KeyboardInputEventArgs(string input)
    {
        this.InputString = input;
    }
}