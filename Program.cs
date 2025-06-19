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
    // public static void TestRectangleArea(Rectangle rectangle)
    // {
    //     rectangle.Width = 5;
    //     rectangle.Height = 10;
    //     Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
    // }

    // public static void TestSquareArea(Square square)
    // {
    //     square.Side = 5;
    //     Console.WriteLine($"Square Area: {square.Area()}");
    // }

    // public static void Main()
    // {
    //     Rectangle rectangle = new Rectangle();
    //     Square square = new Square();

    //     TestRectangleArea(rectangle); // 50
    //     TestSquareArea(square); // 25 - Correct!
    // }

    // // 3
    // public static void ExportDocument(IPdfExporter exporter)
    // {
    //     exporter.ExportToPDF();
    // }

    // public static void Main()
    // {
    //     // Working
    //     var pdfExporter = new DocumentExporter();
    //     ExportDocument(pdfExporter);

    //     // Fixing to use interface
    //     var onlineEporter = new OnlineEporter();
    //     onlineEporter.ExportToHTML();
    // }

    // 4
    public static void SumBalance(List<BankAccount> accounts)
    {
        decimal total = 0;
        foreach (var account in accounts)
        {
            total += account.GetAvailableBalance();
        }
        Console.WriteLine($"Total Balance: {total}");
    }

    public static void Main()
    {
        var accounts = new List<BankAccount>
        {
            new BankAccount(1000),
            new BankAccount(500)
        };
        SumBalance(accounts); // 1500

        accounts.Add(new DebtAccount(200));
        SumBalance(accounts); // 1300 is confusing
    }
}