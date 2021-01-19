using System;
using System.Collections.Generic;

namespace Primzahl2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int MAX_NUMBER_OF_PRIMES = 400000;
            
            int candidate = 3;

            List<int> primes = new List<int>(MAX_NUMBER_OF_PRIMES);
                  
            bool isPrime(int candidate, List<int> primes)
            {
                double maxTeiler = Math.Sqrt(candidate);
                    foreach (int primefactor in primes)
                    {
                        if (primefactor > maxTeiler)
                        {
                            return true;
                        }
                        if (candidate % primefactor == 0 )
                        {
                            return false;
                        }
                    }
                    return true;
            }

            System.Diagnostics.Stopwatch stopWatch = System.Diagnostics.Stopwatch.StartNew();
                       
            while (primes.Count <= MAX_NUMBER_OF_PRIMES)
            {
                if (isPrime(candidate, primes)) 
                {
                    primes.Add(candidate);
                }
                candidate += 2;
            }

            stopWatch.Stop();

           // primes.ForEach(i => Console.Write("{0} ", i));
            
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
