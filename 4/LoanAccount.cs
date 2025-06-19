public class LoanAccount : IAccount
{
    private decimal debt;

    public LoanAccount(decimal debt)
    {
        this.debt = Math.Abs(debt);
    }

    public decimal GetAmount()
    {
        return debt;
    }
}