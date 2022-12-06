namespace FizzBuzz.UnitTests;

public class FizzBuzzLineTests
{
    [Fact]
    public void Generate_Zero()
    {
        var actual = FizzBuzzLine.Generate(0);
        var expected = "";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Generate_Fifteen()
    {
        var actual = FizzBuzzLine.Generate(15);
        var expected = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz";
        Assert.Equal(expected, actual);
    }
}
