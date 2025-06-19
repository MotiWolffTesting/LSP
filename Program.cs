public class Bird
{
}

public class Penguin : Bird
{
    // CANNOT FLY
}

public class Sparrow : Bird, ICanFly
{
    public void Fly()
    {
        Console.WriteLine("I CAN FLY!");
    }
}


class Program
{
    public static void MakeBirdFly(ICanFly bird)
    {
        bird.Fly();
    }

    public static void Main()
    {
        Sparrow sparrow = new Sparrow();
        Penguin penguin = new Penguin();

        MakeBirdFly(sparrow);
        MakeBirdFly(penguin); // COMPILE ERROR: PENGUIN DOES NOT IMPLEMENT ICanFly
    }
}