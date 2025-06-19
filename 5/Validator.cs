public class Validator
{
    public virtual bool IsValid(string input)
    {
        return input != null && input.Length > 3;
    }
}