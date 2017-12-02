using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prime.Prime;

namespace Playground {
    public class Program {
        static void Main(string[] args) {
            ulong NumberToCheck;
            bool debug = false;
            for(;;) {
                Console.Write(">> ");
                string Read = Console.ReadLine().ToLower();
                if (Read == "exit") break;
                if(Read == "gen 8") {
                    NumberToCheck = generateLongPrime(debug);
                    Console.WriteLine("Generated the prime {0}", NumberToCheck);
                    continue;
                } else if(Read == "gen 4") {
                    NumberToCheck = generatePrime(debug);
                    Console.WriteLine("Generated the prime {0}", NumberToCheck);
                    continue;
                } else if(Read == "gen 2") {
                    NumberToCheck = generateShortPrime(debug);
                    Console.WriteLine("Generated the prime {0}", NumberToCheck);
                    continue;
                } else if(Read == "gen") {
                    Console.WriteLine("Either type 'gen 2', 'gen 4' or 'gen 8' to get different lengths of prime\n2 is relativly quick(Maximum of half a second) but 4 is really slow(Maximum of 20k seconds) and 8 is incredibly slow(Maximum of 10 Quintillion)\n");
                    continue;
                } else if(Read == "debug") {
                    debug = !debug;
                    Console.WriteLine("Debug set to {0}", debug);
                    continue;
                } else if(Read == "cls") {
                    Console.Clear();
                    continue;
                } else {
                    if(!UInt64.TryParse(Read, out NumberToCheck)) {
                        Console.WriteLine("Either type in a number to check if it's a prime or type 'gen' to get information about how to use the prime generator\nType 'debug' to toggle debug mode");
                        continue;
                    }
                }
                bool Result = isPrime(NumberToCheck, debug, true);
                Console.WriteLine("{0} is{1}prime", NumberToCheck, Result ? " " : " not ");
            }
        }
    }
}
