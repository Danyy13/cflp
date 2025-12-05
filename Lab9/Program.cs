using System.Reflection;

public class Program
{
    public static void printList(List<Joc> list)
    {
        for(int i=0;i<list.Count;i++)
        {
            Console.Write(list[i].ToString());
        }
    }

    public static void Main()
    {
        Magazin magazin = new Magazin();

        Joc cyberpunk = new Joc("Cyberpunk 2077", "CD Projekt Red", new DateTime(2020, 12, 10), 59.99f, new List<string> { "RPG", "Sci-Fi", "Open World", "Futuristic" });
        Joc minecraft = new Joc("Minecraft", "Mojang", new DateTime(2011, 11, 18), 29.99f, new List<string> { "Sandbox", "Survival", "Multiplayer", "Creative" });
        Joc gtav = new Joc("Grand Theft Auto V", "Rockstar North", new DateTime(2013, 9, 17), 29.99f, new List<string> { "Action", "Open World", "Crime", "Multiplayer" });
        Joc gtasa = new Joc("Grand Theft Auto San Andreas", "Rockstar North", new DateTime(2004, 10, 26), 9.99f, new List<string> { "Action", "Open World", "Crime", "Multiplayer" });
        Joc amongUs = new Joc("Among Us", "Innersloth", new DateTime(2018, 6, 15), 3.99f, new List<string> { "Social Deduction", "Multiplayer", "Space", "2D" });

        magazin.adaugaJoc(cyberpunk);
        magazin.adaugaJoc(minecraft);
        magazin.adaugaJoc(gtav);
        magazin.adaugaJoc(gtasa);
        magazin.adaugaJoc(amongUs);

        DateTime dataInainteDe = new DateTime(2013, 6, 25);
        List<Joc> jocInainteDe = magazin.JocuriInainteDe(dataInainteDe).ToList();
        Console.WriteLine($"Jocuri inainte de {dataInainteDe}:");
        printList(jocInainteDe);
        Console.WriteLine();

        int an1 = 2008, an2 = 2015;
        Console.WriteLine($"Intre {an1} si {an2} au fost lansate {magazin.JocuriIntre(an1, an2)} jocuri\n");

        List<Joc> listaOrdontataDupaDezvoltatorSiNume = magazin.OrdoneazaDupaDezvoltatorSiNume();
        Console.WriteLine($"Jocuri ordonate dupa dezvoltator si nume");
        printList(listaOrdontataDupaDezvoltatorSiNume);
        Console.WriteLine();

        String rockstar = "Rockstar North";
        List<Joc> listaOrdonataDupaDezvoltatorDupaPret = magazin.JocuriDupaDezvoltatorOrdonateDupaPret(rockstar);
        Console.WriteLine($"Jocuri ale dezvoltatorului {rockstar} ordonate dupa pret");
        printList(listaOrdonataDupaDezvoltatorDupaPret);
        Console.WriteLine();

        Joc celMaiVechi = magazin.PrimulJocAlDezvoltatorului(rockstar);
        Console.WriteLine($"Cel mai vechi joc al dezvoltatorului {rockstar} este {celMaiVechi.nume}");

        float pretComparatie = 60.0f;
        if(magazin.JocMaiScumpDecat(pretComparatie))
        {
            Console.WriteLine($"Exista jocuri mai scumpe de {pretComparatie}\n");
        } else
        {
            Console.WriteLine($"NU exista jocuri mai scumpe de {pretComparatie}\n");            
        }

        String multiplayer = "Multiplayer";
        List<String> etichete = new List<string>();
        etichete.Add("RPG");
        etichete.Add("Open World");
        
        float suma = magazin.SumaPreturilorPentruJocurileCuEticheta(multiplayer);
        Console.WriteLine($"Suma este {suma}\n");

        List<Joc> listaJocuriCelPutinOEticheta = magazin.JocuriCareContinCelPutinOEticheta(etichete);
        Console.WriteLine($"Jocuri care contin cel putin o eticheta:");
        printList(listaJocuriCelPutinOEticheta);
    }
}