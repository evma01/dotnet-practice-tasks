
internal class FizzBuzzGenerator : IFizzBuzzGenerator
{

    public string GetFizzBuzz(int i)
    {
        if (i != 0 && i % 15 == 0)
        {
            return "Fizz Buzz";
        }
        else if (i != 0 && i % 5 == 0)
        {
            return "Buzz";
        }
        else if (i != 0 && i % 3 == 0)
        {
            return "Fizz";
        }

        return i.ToString();
    }
}