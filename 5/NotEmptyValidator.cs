public class NotEmptyValidator : IValidator
{
    public bool IsValid(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;
        return input.Length > 3;
    }
}