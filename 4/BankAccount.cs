public class BankAccount
{
    protected decimal Balance;

    public BankAccount(decimal balance)
    {
        this.Balance = balance;
    }
    public virtual decimal GetAvailableBalance()
    {
        return Balance;
    }
}