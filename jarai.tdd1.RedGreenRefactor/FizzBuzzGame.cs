namespace jarai.tdd1.RedGreenRefactor
{
    public class FizzBuzzGame
    {
        public object GetResponse(int number)
        {
            if (number is < 1 or > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }


            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number;
        }
    }
}
