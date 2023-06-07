interface IRideable
{
    void Ride();
}

class Horse: IRideable
{
    public void Ride()
    {
        System.Console.WriteLine("You're riding a Horse!");
    }
}


class Bike: IRideable
{
    public void Ride()
    {
        System.Console.WriteLine("You're riding a bike, honk honk!");
    }
}