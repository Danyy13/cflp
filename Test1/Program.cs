using Microsoft.VisualBasic;

public class Program
{
    // Problema 1
    public static void Juliet42(ref double a, ref double b)
    {
        if(a > 95 && b > 95)
        {
            double aux = a;
            a = b;
            b = a;
        }
    }

    // Problema 2
    public delegate bool Condition(ushort number);
    public delegate ushort Function(ushort number);

    public static bool isEven(ushort number)
    {
        return number % 2 == 0;
    }

    public static ushort addOne(ushort number)
    {
        return (ushort)(number + 1);
    }

    public static List<ushort> Lima03(List<ushort> list, Condition condition, Function function)
    {
        for(int i=0;i<list.Count;i++)
        {
            if(condition(list[i]) == false)
            {
                list[i] = function(list[i]);
            }
        }

        return list;
    }

    public static void printList(List<ushort> list)
    {
        foreach(ushort item in list)
        {
            Console.Write($"{item} ");
        }
        Console.Write("\n");
    }

    public static void Main()
    {
        // Problema 1
        // Cazul fara swap
        // double a = 100;
        // double b = 10;

        // Console.WriteLine($"Inainte: a={a}, b={b}");    
        // Juliet42(ref a, ref b);
        // Console.WriteLine($"Dupa: a={a}, b={b}");

        // // Cazul cu swap (a si b mai mari decat 95)
        // a = 100;
        // b = 110;

        // Console.WriteLine($"Inainte: a={a}, b={b}");    
        // Juliet42(ref a, ref b);
        // Console.WriteLine($"Dupa: a={a}, b={b}");

        // Problema 2
        // const int LIST_SIZE = 15;
        // const int MAX_VALUE = 100;
        // var rand = new Random();
        // List<ushort> list = new List<ushort>();
        // for(int i=0;i<LIST_SIZE;i++)
        // {
        //     list.Add((ushort)(rand.Next() % MAX_VALUE)); // initializare lista cu valori random pana la maxValue
        // }
        // Condition condition = isEven;
        // Function function = addOne;

        // printList(list);
        // list = Lima03(list, condition, function);
        // printList(list);

        // Problema 3
        List<Elev> list = new List<Elev>();
        
        Elev andrei = new ElevPremiant("Pop", "Andrei", "5030406428871", 9.25, 5);
        Elev matei  = new ElevCampion("Popa", "Matei", "5010503593534", 9.25, 2);
        Elev ionut  = new ElevCampion("Popescu", "Ionut", "5020503223344", 8.75, 4);
        Elev paul   = new ElevPremiant("Bob", "Paul", "5030409897644", 8.5, 7);

        list.Add(andrei);
        list.Add(matei);
        list.Add(ionut);
        list.Add(paul);

        for(int i=0;i<list.Count;i++)
        {
            list[i].Salut();
        }

        for(int i=0;i<list.Count;i++)
        {
            Console.WriteLine(list[i].ToString());
        }
    }
    
}