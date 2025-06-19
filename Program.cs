class Program
{
    // 1
    // public static void MakeBirdFly(ICanFly bird)
    // {
    //     bird.Fly();
    // }

    // public static void Main()
    // {
    //     Sparrow sparrow = new Sparrow();
    //     Penguin penguin = new Penguin();

    //     MakeBirdFly(sparrow);
    //     MakeBirdFly(penguin); // COMPILE ERROR: PENGUIN DOES NOT IMPLEMENT ICanFly
    // }

    // 2
    public static void TestArea(Rectangle shape)
    {
        shape.Width = 5;
        shape.Height = 10;
        Console.WriteLine(shape.Area());
    }

    public static void Main()
    {
        Rectangle rectangle = new Rectangle();
        Square square = new Square();

        TestArea(rectangle); // 50
        TestArea(square); // Output will be 50 but wrong
    }
}