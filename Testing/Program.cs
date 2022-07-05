public class Transport
{
    public string Name;
    public string TransportType = "Transport";
    public double Speed;
public virtual void PrintDrivingInfo(double distance)
{
    Console.WriteLine(TransportType + " will travel " + distance + " km");
}

}
public class Car : Transport
{
    public Car(double consumption)
    {
        TransportType = "Car";
        LitersPer100Km = consumption;
    }
    public Car(): this(7)
    {
       
    }
    public double LitersPer100Km;
    public override void PrintDrivingInfo(double distance)
    {
        base.PrintDrivingInfo(distance);
        Console.WriteLine("Skoda ftw " + LitersPer100Km);
    }
}
public class Bicycle : Transport
{
    public Bicycle()
    {
        TransportType = "Bicycle";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        for(int x = 0; x < args.Length; x++)
        {
            Console.WriteLine(args[x]);
        }
        Bicycle lehaBike = new Bicycle();
        lehaBike.Name = "Merida";
        lehaBike.Speed = 20;

        Car lehaCar = new Car();
        lehaCar.Name = "Skoda Octavia";
        lehaCar.Speed = 100;

        lehaBike.PrintDrivingInfo(20);
        lehaCar.PrintDrivingInfo(20);
    }
}