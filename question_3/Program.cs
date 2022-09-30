using System;

public interface IVehicle
{
    void Drive();
    bool Refuel(int amt);
}
public class Car : IVehicle
{
    // public int fuel { get; set; }
    int f;
    public Car(int f)
    {
        this.f = f;
    }
    public void Drive()
    {
        if (f > 0)
        {
            Console.WriteLine("Car is driving");
        }
        else
        {
            Console.WriteLine("need to refuel");
        }
    }

    public bool Refuel(int amt)
    {
        if (f > 0)
            return true;
        else
        {
            return false;
        }
    }

}


internal class Program
{
    static void Main()
    {
        int f;
        Console.WriteLine("Enter the amount of fuel");
        f = Convert.ToInt32(Console.ReadLine());
        Car benz = new Car(f);
        benz.Drive();
        Console.WriteLine(benz.Refuel(f));
    }

}