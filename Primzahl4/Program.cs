using System.Diagnostics;
using static System.Math;

const int maxNumberOfPrimes = 100;


var primes = new int[maxNumberOfPrimes];
primes[0] = 2;
var candidate = 3;
var primesCount = 1;

var stopWatch = Stopwatch.StartNew();

while (primesCount < maxNumberOfPrimes)
{
    var maxTeiler = Round(Sqrt(candidate));
    var isPrime = true;

    for (var i = 0; i < primesCount; i++)
    {
        if (primes[i] > maxTeiler) break;
        if (candidate % primes[i] == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        primes[primesCount] = candidate;
        primesCount++;
    }

    candidate += 2;
}

stopWatch.Stop();

Console.WriteLine(stopWatch.Elapsed);

Array.ForEach(primes, p => Console.Write(p + " "));