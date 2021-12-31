using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);
                
            }
        }

        static async void Start()
        {
            var result =  await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return "test";
            });

            Console.WriteLine(result);
        }
    }
}
