using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstOfClients = new List<Score>()
            {
                new Score("Белгазпромбанк", 200,"Катя",18),
                new Score("Белорусьбанк", 300, "Ира", 32),
                new Score("Белгазпромбанк", 500, "Костя", 23),
                new Score("Белгазпромбанк", 100, "Саша", 18),
                new Score("Белгазпромбанк", 700, "Маша", 39),

            };
            var score1 = new Score("Белгазпромбанк", 200,"Катя",34);
            Console.WriteLine(score1);
            Console.WriteLine();
            score1.Balance = score1.Balance.PutOnTheScore(300);
            Console.WriteLine("Счет увеличелся");
            Console.WriteLine(score1);
            Console.WriteLine();
            Console.Write( "Счет уменьшился до:");
            Console.WriteLine(score1.Balance.SendFromScore(100));
            Console.WriteLine();
            Console.WriteLine("18 лет у людей:");
            Console.WriteLine(lstOfClients.FindTheSameAge(18).ConvertToString());
        }
    }
}