using System;
using AccountNameSpace;

public struct Coords
{
    public float X { get; set; }
    public float Y { get; set; }

    public Coords(float x, float y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class MainClass
{
    public static void swap(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }

    public static Coords middle(in Coords a, in Coords b)
    {
        Coords ret = new Coords(0, 0);
        ret.X = (a.X + b.X) / 2;
        ret.Y = (a.Y + b.Y) / 2;

        return ret;
    }

    public static void Main()
    {
        // 1. Test metoda Swap
        // int a = 1;
        // int b = 2;

        // Console.WriteLine("a={0}, b={1}\n", a, b);
        // swap(ref a, ref b);
        // Console.WriteLine("a={0}, b={1}\n", a, b);



        // 2. Test metoda Middle
        // Coords a = new Coords(1, 5);
        // Coords b = new Coords(6, 3);
        // Coords mid = middle(a, b);
        // Console.WriteLine($"Middle: {mid.ToString()}");



        // 3. Test Account
        Account account = new Account("Ion", 150);
        double amountToWithdraw = 200;
        double remainingBalance;
        if(account.withdraw(amountToWithdraw, out remainingBalance) == false)
        {
            Console.WriteLine($"Unable to withdraw {amountToWithdraw}. Balance for account {account.getName()} is {account.getBalance()}");
        } else
        {
            Console.WriteLine($"Succesfuly withdrew {amountToWithdraw} from account {account.getName()}. Balance for account {account.getName()} is {account.getBalance()}");
        }

    }
}