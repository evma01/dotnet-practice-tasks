internal class FizzBuzzLine
{
    public static string Generate(int n)
    {
        string result = string.Empty;
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                result += "Fizz Buzz";
            }
            else if (i % 5 == 0)
            {
                result += "Buzz";
            }
            else if (i % 3 == 0)
            {
                result += "Fizz";
            }
            else
            {
                result += i;
            }

            if (i < n)
            {
                result += ", ";
            }
        }
        return result;
    }
}