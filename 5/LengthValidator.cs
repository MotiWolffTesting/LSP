public class LengthValidator : IValidator
{
    public bool IsValid(string input)
    {
        return input != null && input.Length > 3;
    }
}