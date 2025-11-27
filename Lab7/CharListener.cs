public class CharListener
{
    private char key;

    public CharListener(char key, InputReader inputReader)
    {
        this.key = key;
        inputReader.OnKeyPressed += HandleKeyPressed;
    }

    public void HandleKeyPressed(object sender, KeyboardInputEventArgs input)
    {
        bool found = false;
        foreach(char character in input.InputString)
        {
            if(character == key)
            {
                found = true;
                break;
            }
        }

        if(found == true)
        {
            Console.WriteLine($"Caracterul '{key}' a fost gasit in sirul dat");
        } else {
            Console.WriteLine($"Caracterul '{key}' nu a fost gasit in sir");
        }

    }
}