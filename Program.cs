using System;
using System.Linq;
using ParallelPractice;
using System.Collections.Generic;
using System.Diagnostics;

namespace ParallelPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfObjects = 100000000;
            List<FakeObject> listOfEnumerables = new List<FakeObject>(numberOfObjects);
            for (int i = 0; i < numberOfObjects; i++)
            {
                listOfEnumerables.Add(new FakeObject(i));
            }

            Console.WriteLine("Running Sequential");
            Stopwatch sequential = new Stopwatch();
            sequential.Start();
            foreach (FakeObject fakeObject in listOfEnumerables)
            {
                fakeObject.Square();
            }
            sequential.Stop();
            Console.WriteLine($"Time Elapsed {sequential.Elapsed}");

            Console.WriteLine("Running Parallel");
            Stopwatch parallel = new Stopwatch();
            parallel.Start();
            listOfEnumerables.AsParallel().Select(fo => fo.Square());
            parallel.Stop();
            Console.WriteLine($"Time Elapsed {parallel.Elapsed}");

        }
    }
}