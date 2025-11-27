public abstract class Elev
{
    private string nume;
    private string prenume;
    private string cnp;
    private double mediaBacalaureat;

    public Elev(string nume, string prenume, string cnp, double mediaBacalaureat)
    {
        this.nume = nume;
        this.prenume = prenume;
        this.cnp = cnp;
        this.mediaBacalaureat = mediaBacalaureat;
    }

    public abstract void Salut();

    public override String ToString()
    {
        return $"nume: {this.nume} prenume: {this.prenume} cnp: {this.cnp} mediaBac: {this.mediaBacalaureat} ";
    }

    // Getters and setters
    public string getNume()
    {
        return this.nume;
    }

    protected void setNume(string nume)
    {
        this.nume = nume;
    }

    public string getPrenumee()
    {
        return this.prenume;
    }

    protected void setPrenume(string prenume)
    {
        this.prenume = prenume;
    }

    public string getCnp()
    {
        return this.cnp;
    }

    protected void setCnp(string cnp)
    {
        this.cnp = cnp;
    }

    public double getMediaBacalaureat()
    {
        return this.mediaBacalaureat;
    }

    protected void setMediaBacalaureat(double mediaBacalaureat)
    {
        this.mediaBacalaureat = mediaBacalaureat;
    }
}