public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("I'm flying!");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        Console.WriteLine("I cannot fly.");
    }
}


class Program
{
    public static void MakeBirdFly(Bird b)
    {
        b.Fly();
    }

    public static void Main()
    {
        Bird sparrow = new Bird();
        Penguin penguin = new Penguin();

        MakeBirdFly(sparrow);
        MakeBirdFly(penguin);
    }
}