public class Joc
{
    public string nume { get; }
    public string dezvoltator { get; }
    public DateTime dataLansare { get; }
    public float pret { get; }
    public List<string> etichete { get; }

    public Joc(string nume, string dezvoltator, DateTime dataLansare, float pret, List<string> etichete)
    {
        this.nume = nume;
        this.dezvoltator = dezvoltator;
        this.dataLansare = dataLansare;
        this.pret = pret;
        this.etichete = etichete;
    }

    public override string ToString()
    {
        String eticheteConcat = "";
        foreach(String eticheta in etichete)
        {
            eticheteConcat += eticheta + " ";
        }

        return $"Nume: {nume}\tDezvoltator: {dezvoltator}\tData Lansare: {dataLansare}\tPret: {pret}\tEtichete: {eticheteConcat}\n";
    }
}