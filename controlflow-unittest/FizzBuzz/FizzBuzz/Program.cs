Console.WriteLine("Generate a list of numbers according to the rules of FizzBuzz.");
Console.WriteLine("How many item should be generated?");

string? userInput = Console.ReadLine();

if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("Invalid input. Please provide a number");
}
else {
    int fizzbuzzSize = int.Parse(userInput);
    string result = new FizzBuzzLine(new FizzBuzzGenerator()).Generate(fizzbuzzSize);
    Console.WriteLine(result);
}


// Finish the program so it will print a line
// with the provided element count according to
// the FizzBuzz rule. Use the FizzBuzzLineGenerator.
// Example for input 15:
// 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz