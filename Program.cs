using System;

namespace Aula25Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci rec = new Fibonacci();
            rec.GerarSequeunciaDeFibonacci(0,1,15);
            System.Console.WriteLine(rec.GerarFatorial(5));
        }
    }
}
