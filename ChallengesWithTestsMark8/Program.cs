using System;
using System.Numerics;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            ChallengesSet04 cs4 = new ChallengesSet04();
            BigInteger bi ;
            bi = cs4.Factorial(-3);

            Console.WriteLine(bi);
        }
    }
}
