internal class FizzBuzzLine
{
    private readonly IFizzBuzzGenerator _fizzBuzzGenerator;

    public FizzBuzzLine(IFizzBuzzGenerator fizzBuzzGenerator)
    {
        _fizzBuzzGenerator = fizzBuzzGenerator;
    }

    public string Generate(int n)
    {

        string result = string.Empty;
        for (int i = 1; i <= n; i++)
        {
            result += _fizzBuzzGenerator.GetFizzBuzz(i);
            if (i < n)
            {
                result += ", ";
            }

        }
        return result;
    }
}