namespace Uppgift_Fordon;

public class Fordon
{
    protected string model;
    protected int år;
    protected int vikt;

    public Fordon(string Model, int År, int Vikt)
    {
        model = Model;
        år = År;
        vikt = Vikt;
    }

    public virtual void SkrivUt()
    {
    }
}

