public class StrictValidator : Validator
{
    public override bool IsValid(string input)
    {
        if (string.IsNullOrEmpty(input))
            throw new ArgumentException("Input cannot be empty.");
        return input.Length > 3;
    }
}