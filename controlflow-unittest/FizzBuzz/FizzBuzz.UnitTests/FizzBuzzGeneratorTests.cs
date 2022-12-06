namespace FizzBuzz.UnitTests
{
    public class FizzBuzzGeneratorTests
    {
        private readonly FizzBuzzGenerator _fizzBuzzGenerator;
        public FizzBuzzGeneratorTests()
        {
             _fizzBuzzGenerator = new FizzBuzzGenerator();
        }

        [Theory]
        [InlineData(0,"0")]
        [InlineData(3,"Fizz")]
        [InlineData(5,"Buzz")]
        [InlineData(15,"Fizz Buzz")]
        public void Test1(int input, string expected)
        {
            var actual = _fizzBuzzGenerator.GetFizzBuzz(input);
            Assert.Equal(expected, actual);
        }
    }
}
