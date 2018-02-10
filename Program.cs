using System;
using System.Threading.Tasks;

namespace AsyncAwaitBehaviourDemo
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine(" Demo 1: Awaiting call to long operation:");
            MethodWithAwait().Wait();

            Console.WriteLine(" Demo 2: NOT awaiting call to long operation:");
            MethodWithoutAwait().Wait();

            Console.ReadKey();
        }

        private static async Task MethodWithAwait()
        {
            Console.WriteLine(" MethodWithAwait() entered.");

            Console.WriteLine(" Awaiting call to LongOperation().");
            await LongOperation();

            Console.WriteLine(" Pretending to do other work in MethodWithAwait()...");
        }

        private static async Task MethodWithoutAwait()
        {
            Console.WriteLine(" MethodWithoutAwait() entered.");

            Console.WriteLine(" Call made to LongOperation() with NO await.");
            Task task = LongOperation();

            Console.WriteLine(" Do some other work in MethodWithoutAwait() after calling LongOperation()...");
        }

        private static async Task LongOperation()
        {
            Console.WriteLine(" LongOperation() entered.");

            Console.WriteLine(" Starting the long (3 second) process in LongOperation()...");
            await Task.Delay(4000);
            Console.WriteLine(" Completed the long (3 second) process in LongOperation()...");
        }
    }
}



