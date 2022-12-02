namespace CarFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BodySport s1 = new BodySport();
            //Koła
            s1.AddWheels(new WheelsSport());
            s1.AddWheels(new WheelsSport());
            s1.AddWheels(new WheelsOffRoad());
            s1.AddWheels(new WheelsOffRoad());
            // Silnik
            s1.AddEngine(new EngineSport());
            s1.AddFuel(33);
            s1.TurnOnEngine();
            s1.ShowCarStats();

            BodyArmy ar1 = new BodyArmy();

            s1.Drive(300);

            s1.ShowCarStats();

            Amphibian a1 = new Amphibian();
            a1.AddEngine(new EngineTruck());
            a1.AddFuel(189);
            a1.TurnOnEngine();
            a1.Drive(500);

            a1.ShowCarStats();
        }
    }
}