using InteracesInPractice;

namespace InterfaceTest 
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello!");
            Bike myBike = new Bike();
            Horse myHorse = new Horse();

            myHorse.Ride();
            myBike.Ride();
        }
    }
}