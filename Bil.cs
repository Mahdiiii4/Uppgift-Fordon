namespace Uppgift_Fordon
{
    public class Bil : Fordon
    {
        public Bil(string Model, int År, int Vikt) : base(Model, År, Vikt)
        {
        }

        public override void SkrivUt()
        {
            Console.WriteLine("Bil:");
            Console.WriteLine("Model är: " +model+".");
            Console.WriteLine("År är: " +år+".");
            Console.WriteLine("Vikt är: " +vikt+".");
        }
    }
}