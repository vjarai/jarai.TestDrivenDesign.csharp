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
            // Dora hat drei Fünfen und zwei Dreien gewürfelt.
            // Sie hat nun vier Möglichkeiten:
            // ■ 25 Punkte für „Full House
            // ■ 21 Punkte für „Dreierpasch“
            // ■ 15 Punkte für die Fünfen
            // ■  6 Punkte für die Dreien

            var wurf = new Wurf(5, 5, 5, 3, 3);
            //var wurf = new Wurf(3, 3, 3, 3, 3);
            //var wurf = new Wurf(4, 3, 2, 5,  1 );
            var scoringService = new KniffelScoringService();

            var scorings = scoringService.CalculateScorings(wurf);

            Console.WriteLine(wurf);

            foreach (var scoring in scorings)
            {
                Console.WriteLine(scoring);
            }
        }
    }
}
