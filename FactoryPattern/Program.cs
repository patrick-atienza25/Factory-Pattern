namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels would you like to install on the vehicle?");
            var userInput = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);
            vehicle.Drive();
        }
    }
}
