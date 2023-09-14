namespace Uppgift_Fordon
{
    public class Mobed : Fordon
    {
        public Mobed(string Model, int År, int Vikt) : base(Model, År, Vikt)
        {
        }

        public override void SkrivUt()
        {
            Console.WriteLine("Mobed:");
            Console.WriteLine("Model är: " +model+".");
            Console.WriteLine("År är: " +år+".");
            Console.WriteLine("Vikt är: " +vikt+".");
        }
    }
}