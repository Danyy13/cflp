public class ElevPremiant : Elev
{
    private int numarPremii;

    public ElevPremiant(string nume, string prenume, string cnp, double mediaBacalaureat, int numarPremii) : base(nume, prenume, cnp, mediaBacalaureat)
    {
        this.numarPremii = numarPremii;
    }

    public override void Salut()
    {
        Console.WriteLine($"Salut, sunt ElevPremiant");
    }

    public override string ToString()
    {
        return base.ToString() + $"numarPremii: {this.numarPremii}";
    }

    // Getters and setters
    public int getNumarPremii()
    {
        return this.numarPremii;
    }

    protected void setNumarPremii(int numarPremii)
    {
        this.numarPremii = numarPremii;
    }
}