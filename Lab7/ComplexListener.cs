public class ComplexListener
{
    private int strNo;
    private List<string> list = new List<string>();

    public ComplexListener(int strNo, InputReader reader)
    {
        this.strNo = strNo;
        reader.OnKeyPressed += HandleKeyPressed;
    }

    public void HandleKeyPressed(object sender, KeyboardInputEventArgs args)
    {
        string inputString = args.InputString;

        if(inputString == "print all")
        {
            printList(list);
            return;
        }

        if(inputString == "print last")
        {
            Console.WriteLine("Last string is: " + list.Last());
            return;
        }

        // daca este oricare alt string se adauga in lista
        if(list.Count >= strNo)
        {
            list.RemoveAt(0);
        }
        list.Add(inputString);
    }

    void printList(List<string> list)
    {
        Console.WriteLine("List is:");
        for(int i=0;i<list.Count;i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}