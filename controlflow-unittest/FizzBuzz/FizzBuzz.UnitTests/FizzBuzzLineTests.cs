using Moq;

namespace FizzBuzz.UnitTests;

public class FizzBuzzLineTests
{

    private readonly FizzBuzzLine _fizzBuzzLine;
    private readonly Mock<IFizzBuzzGenerator> _fizzBuzzGeneratorMock;

    public FizzBuzzLineTests()
    {
        _fizzBuzzGeneratorMock = new Mock<IFizzBuzzGenerator>();
        _fizzBuzzLine = new FizzBuzzLine(_fizzBuzzGeneratorMock.Object);
    }

    [Fact]
    public void Generate_Zero()
    {
        _fizzBuzzGeneratorMock.Setup(generator => generator.GetFizzBuzz(It.IsAny<int>())).Returns("");
        var actual = _fizzBuzzLine.Generate(0);
        var expected = "";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Generate_Fifteen()
    {
        _fizzBuzzGeneratorMock.Setup(generator => generator.GetFizzBuzz(It.IsAny<int>()))
            .Returns((int input)=> new FizzBuzzGenerator().GetFizzBuzz(input));
        var actual = _fizzBuzzLine.Generate(15);
        var expected = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz";
        Assert.Equal(expected, actual);
    }
}
