using System.Runtime.Versioning;

public class Program
{
    //Problema 1
    public delegate bool DelegateCondition(int number);

    public static List<int> GenerateRandomList(int size, int maxValueOfItem)
    {
        List<int> list = new List<int>();
        var rand = new Random();

        for (int i = 0; i < size; i++)
        {
            list.Add(rand.Next() % maxValueOfItem);
        }

        return list;
    }

    public static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write($"{item} ");
        }
        Console.Write("\n");
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    public static List<int> filter(DelegateCondition condition, List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!condition(list[i]))
            {
                list.RemoveAt(i);
                i--;
            }
        }

        return list;
    }

    // Problema 2
    public delegate float DelegateFunctionFloat(float x);

    public static float FGX(DelegateFunctionFloat delegate1, DelegateFunctionFloat delegate2, float x)
    {
        return delegate1(delegate2(x));
    }

    public static float f(float x)
    {
        return x * 3;
    }

    public static float g(float x)
    {
        return x - 2;
    }

    // Problema 3
    public delegate int DelegateComposition(int x);

    public static DelegateComposition Comp(DelegateComposition f, DelegateComposition g)
    {
        return (int x) => f(g(x));
    }

    public static int f(int x)
    {
        return x * 3;
    }

    public static int g(int x)
    {
        return x - 2;
    }

    public static void Main()
    {
        // Problema 1
        // const int LIST_SIZE = 20;
        // const int MAX_VALUE_OF_ITEM = 500;
        // DelegateCondition isOdd = IsOdd;

        // List<int> list = GenerateRandomList(LIST_SIZE, MAX_VALUE_OF_ITEM);
        // PrintList(list);

        // List<int> evenList = filter(IsEven, list);
        // PrintList(evenList);

        // Problema 2
        // DelegateFunctionFloat function1 = f;
        // DelegateFunctionFloat function2 = g;
        // float x = 100.3f;

        // x = FGX(function1, function2, x);

        // Console.WriteLine(x);

        // Problema 3
        DelegateComposition function1 = f;
        DelegateComposition function2 = g;
        int x = 100;

        DelegateComposition fCompG = Comp(f, g);
        x = fCompG(x);

        Console.WriteLine(x);
    }
}