public class MainClass
{
    // Problema 1
    public static void removeAt(int[] array, ref int length, int n)
    {
        for (int i = n; i < length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        length--;
    }

    public static void printArray(int[] array, int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    // Problema 2
    public static List<int> intersection(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        foreach (int list1Item in list1)
            foreach (int list2Item in list2)
                if (list1Item == list2Item)
                {
                    bool duplicate = false;
                    foreach (int resultListItem in result)
                    {
                        if (resultListItem == list1Item)
                        {
                            duplicate = true;
                            break;
                        }
                    }
                    if (duplicate == false)
                    {
                        result.Add(list1Item);
                        break;
                    }
                }

        return result;
    }

    public static void printList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        // Problema 1
        // int[] array = { 4, 5, 9, 1, 5, 9, 22, 8 };
        // int length = 8;
        // int indexToRemove = 1;

        // printArray(array, length);
        // removeAt(array, ref length, indexToRemove);
        // printArray(array, length);

        // Problema 2
        // List<int> list1 = [1, 4, 6, 1, 7, 8, 1, 3];
        // List<int> list2 = [6, 9, 8, 2, 5, 1, 6, 4];
        // List<int> result = intersection(list1, list2);

        // printList(result);

        // Problema 3
        Stack<int> stack = new Stack<int>();
        int x = 0;
        int y = 0;

        stack.Push(10);
        stack.Push(15);
        stack.Push(30);
        
        x = stack.Pop();
        Console.WriteLine(x);

        x = stack.Pop();
        Console.WriteLine(x);

        y = stack.Peek();
        Console.WriteLine(y);

        x = stack.Pop();
        Console.WriteLine(x);

        bool ret = stack.TryPop(out x);
        if (ret == true)
            Console.WriteLine(x);
        else
            Console.WriteLine("Stack is empty\n");
    }
}