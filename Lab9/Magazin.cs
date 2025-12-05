public class Magazin
{
    List<Joc> jocuri = new List<Joc>();

    public void adaugaJoc(Joc joc)
    {
        jocuri.Add(joc);
    }

    public List<Joc> JocuriInainteDe(DateTime data)
    {
        IEnumerable<Joc> ret = this.jocuri.Where(joc => (joc.dataLansare.Year < data.Year && joc.dataLansare.Month < data.Month && joc.dataLansare.Day < data.Day));

        return ret.ToList();
    }

    public int JocuriIntre(int an1, int an2)
    {
        IEnumerable<Joc> ret = this.jocuri.Where(joc => (joc.dataLansare.Year > an1 && joc.dataLansare.Year < an2));

        return ret.Count();
    }

    public List<Joc> OrdoneazaDupaDezvoltatorSiNume()
    {
        IEnumerable<Joc> ret = jocuri.OrderBy(joc => joc.dezvoltator).ThenBy(joc => joc.nume);

        return ret.ToList();
    }

    public List<Joc> JocuriDupaDezvoltatorOrdonateDupaPret(string dezvoltator, bool descrescator = false)
    {
        IEnumerable<Joc> ret = jocuri.Where(joc => joc.dezvoltator.Equals(dezvoltator));

        if(descrescator)
        {
            return ret.OrderByDescending(joc => joc.pret).ToList();
        }

        return ret.OrderBy(joc => joc.pret).ToList();
    }

    public Joc? PrimulJocAlDezvoltatorului(string dezvoltator)
    {
        Joc ret = jocuri.Where(joc => joc.dezvoltator.Equals(dezvoltator)).MinBy(joc => joc.dataLansare);

        return ret;
    }

    public bool JocMaiScumpDecat(float pret)
    {
        return jocuri.Any(joc => (joc.pret > pret));
    }

    public float SumaPreturilorPentruJocurileCuEticheta(string eticheta)
    {
        float ret = jocuri.Where(joc => joc.etichete.Contains(eticheta)).Sum(joc => joc.pret);

        return ret;
    }

    public List<Joc> JocuriCareContinCelPutinOEticheta(List<string> etichete)
    {
        IEnumerable<Joc> ret = jocuri.Where(j => j.etichete.Intersect(etichete).Any());

        return ret.ToList();
    }
}