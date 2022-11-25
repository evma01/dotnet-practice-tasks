namespace FizzBuzz.UnitTests;

public class FizzBuzzLineTests
{
    [Fact]
    public void Generate_ReturnsAString()
    {
        // Arrange
        var fizzBuzzLine = new FizzBuzzLine();

        // Act
        var result = fizzBuzzLine.Generate(1);
        
        // Assert
        Assert.NotNull(result);
    }
}
