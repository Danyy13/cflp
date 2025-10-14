// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// public class Sum
// {
//     public static void Main(string[] args)
//     {
//         int n = 0;
//         int sum = 0;

//         n = int.Parse(Console.ReadLine());
//         for(int i=0;i<n;i++) {
//             sum += int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine(sum);

//     }
// }

// public class Ecuation
// {
//     public static void Main(string[] args)
//     {
//         double a = double.Parse(Console.ReadLine());
//         double b = double.Parse(Console.ReadLine());
//         double c = double.Parse(Console.ReadLine());

//         if(a == 0) {
//             if (b == 0)
//             {
//                 Console.WriteLine("Nu exista necunoscute");
//             } else {
//                 double x = -c / b;
//                 Console.WriteLine("Singura solutie este x = {0}", x);
//             }
//         } else
//         {
//             double delta = b * b - 4 * a * c;

//             if(delta < 0) {
//                 Console.WriteLine("Delta este negativ => Nu exista solutii reale");
//             } else
//             {
//                 double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//                 double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//                 Console.WriteLine("Solutiile sunt:\nx1: {0}\nx2: {1}", x1, x2);            
//             }
//         }

//         // Console.WriteLine(a + " " + b + " " + c);
//     }
// }

public class Student
{
    string name;
    int year;
    double grade1;
    double grade2;
    double grade3;

    public Student(string name, int year, double grade1, double grade2, double grade3)
    {
        this.name = name;
        this.year = year;
        this.grade1 = grade1;
        this.grade2 = grade2;
        this.grade3 = grade3;
    }

    public double calculeazaMedia()
    {
        return (this.grade1 + this.grade2 + this.grade3) / 3;
    }

    public override string ToString()
    {
        return $"Name: {this.name}\nYear: {this.year}\nGrades: {this.grade1} {this.grade2} {this.grade3}";
    }

}

public class Whatever
{
    public static void Main(String[] args)
    {
        int n = 0;
        Student[] students = new Student[100];

        Console.WriteLine("n=");
        n = int.Parse(Console.ReadLine());

        // Console.WriteLine(n);

        // Citire studenti
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Input: name, year, grade1, grade2, grade3 for student {0}", i);
            string name = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double grade1 = double.Parse(Console.ReadLine());
            double grade2 = double.Parse(Console.ReadLine());
            double grade3 = double.Parse(Console.ReadLine());
            Student student = new Student(name, year, grade1, grade2, grade3);
            students[i] = student;
        }

        // Afisare studenti
        for(int i=0;i<n;i++)
        {
            // Console.WriteLine(students[i].ToString());
            Console.WriteLine(students[i].calculeazaMedia());
        }

        // Maxim
        double maxMedie = 0;
        Student maxStudent = students[0];
        for (int i = 1; i < n; i++)
        {
            double mediaStudent = students[i].calculeazaMedia();
            if (mediaStudent > maxMedie)
            {
                maxMedie = mediaStudent;
                maxStudent = students[i];
            }
        }

        Console.WriteLine("Studentul cu media maxima este\n{0}", maxStudent.ToString());
    }
}