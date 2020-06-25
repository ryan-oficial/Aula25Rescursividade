using System;

namespace Aula25Recursivo
{
    public class Fibonacci
    {
        public void GerarSequeunciaDeFibonacci(int num1, int num2, int vezes){
            if(vezes > 0){
            Console.WriteLine(num1);
            GerarSequeunciaDeFibonacci(num2, num1 + num2, vezes - 1);
            }
        }

        public int GerarFatorial(int numero){
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }
    }
}