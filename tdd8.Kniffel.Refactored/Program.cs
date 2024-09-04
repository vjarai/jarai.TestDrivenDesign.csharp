using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarai.tdd8.KniffelRefactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wurf = new Wurf(1, 2, 3, 4, 5);
            var sut = new KniffelScoringService();

            var result = sut.CalculateScore(wurf);

            foreach (var scoringResult in result)
            {
                Console.WriteLine(scoringResult);
            }
        }
    }
}
