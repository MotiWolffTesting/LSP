public class CashAccount : IAccount
{
    private decimal balance;

    public CashAccount(decimal balance)
    {
        this.balance = balance;
    }

    public decimal GetAmount()
    {
        return balance;
    }
}