public class ElevCampion : Elev
{
    private int numarMedalii;

    public ElevCampion(string nume, string prenume, string cnp, double mediaBacalaureat, int numarMedalii) : base(nume, prenume, cnp, mediaBacalaureat)
    {
        this. numarMedalii = numarMedalii;
    }

    public override void Salut()
    {
        Console.WriteLine($"Salut, sunt ElevCampion");
    }

    public override string ToString()
    {
        return base.ToString() + $"numarPremii: {this.numarMedalii}";
    }

    // Getters and setters
    public int getNumarMedalii()
    {
        return this.numarMedalii;
    }

    protected void setNumarMedalii(int numarMedalii)
    {
        this.numarMedalii = numarMedalii;
    }
}