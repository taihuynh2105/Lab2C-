using System;

public class Program
{
    public static void bai2a()
    {
        var userInfp = new
        {
            id = "2024",
            name = "Faker",
            isplaying = false,
            bag = new
            {
                skins = 0,
                cups = 20,
            }
        };
        Console.WriteLine("ID: " + userInfp.id);
        Console.WriteLine("Name: " + userInfp.name);
        Console.WriteLine("isplaying: " + userInfp.isplaying);
        Console.WriteLine("bag skins: " + userInfp.bag.skins);
        Console.WriteLine("bag cups: " + userInfp.bag.cups);

    }

    public static void bai2b()
    {
        int y = 10;
        Action<int> AnonymousMethod = delegate (int x)
        {
            int sum = x + y;
            int sub = x - y;
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("sub: " + sub);

        };
        AnonymousMethod(5);
    }
    public static void Main(string[] args)
    {
        bai2a();
        bai2b();
    }

}