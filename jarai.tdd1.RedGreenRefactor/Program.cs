namespace jarai.tdd1.RedGreenRefactor;

internal class Program
{
    private static void Main(string[] args)
    {
        var game = new FizzBuzzGame();

        for (var number = 1; number <= 100; number++)
            Console.WriteLine(game.GetResponse(number));
    }
}