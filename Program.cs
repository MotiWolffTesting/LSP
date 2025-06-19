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
    public static void TestRectangleArea(Rectangle rectangle)
    {
        rectangle.Width = 5;
        rectangle.Height = 10;
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
    }

    public static void TestSquareArea(Square square)
    {
        square.Side = 5;
        Console.WriteLine($"Square Area: {square.Area()}");
    }

    public static void Main()
    {
        Rectangle rectangle = new Rectangle();
        Square square = new Square();

        TestRectangleArea(rectangle); // 50
        TestSquareArea(square); // 25 - Correct!
    }
}