namespace Uppgift_Fordon
{
    public class Buss : Fordon
    {
        public Buss(string Model, int År, int Vikt) : base(Model, År, Vikt)
        {
        }

        public override void SkrivUt()
        {
            Console.WriteLine("Buss:");
            Console.WriteLine("Model är: " +model+".");
            Console.WriteLine("År är: " +år+".");
            Console.WriteLine("Vikt är: " +vikt+".");
        }
    }
}