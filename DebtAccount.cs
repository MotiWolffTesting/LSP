public class DebtAccount : BankAccount
{
    
    public DebtAccount(decimal debt) : base(debt) { }

    public override decimal GetAvailableBalance()
    {
        return Balance; // Negative value
    }
}