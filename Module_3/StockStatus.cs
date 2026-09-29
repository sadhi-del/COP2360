using System;

public enum StockStatus
{
    Gain,
    Loss,
    Unchanged
}

public class Stock
{
    public decimal CurrentPrice { get; set; }
    public decimal SharesOwned { get; set; }
    public StockStatus Status { get; set; }

    public decimal Worth
    {
        get { return CurrentPrice * SharesOwned; }
    }
}

class Program
{
    static void Main()
    {
        Stock stock1 = new Stock
        {
            CurrentPrice = 50,
            SharesOwned = 100,
            Status = StockStatus.Gain
        };

        Stock stock2 = new Stock
        {
            CurrentPrice = 25,
            SharesOwned = 75,
            Status = StockStatus.Loss
        };

        Console.WriteLine("Stock 1");
        Console.WriteLine("Current Price: $" + stock1.CurrentPrice);
        Console.WriteLine("Shares Owned: " + stock1.SharesOwned);
        Console.WriteLine("Total Worth: $" + stock1.Worth);
        Console.WriteLine("Status: " + stock1.Status);

        Console.WriteLine();

        Console.WriteLine("Stock 2");
        Console.WriteLine("Current Price: $" + stock2.CurrentPrice);
        Console.WriteLine("Shares Owned: " + stock2.SharesOwned);
        Console.WriteLine("Total Worth: $" + stock2.Worth);
        Console.WriteLine("Status: " + stock2.Status);
    }
}
