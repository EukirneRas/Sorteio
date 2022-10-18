using System;

namespace Sorteio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int x = randNum.Next();
            int num;
            bool f = true;
            int valorInteiro = randNum.Next(0,100);

            for (int i = 5; i > 0; i--)
            {
                
                Console.WriteLine("Tente a sorte com seu número! De 0 a 100! Você tem " + i + " chance");
                num = int.Parse(Console.ReadLine());

                if (num > valorInteiro)
                {
                    Console.WriteLine("O valor inserido é maior que o valor sorteado");
                    f = false;
                }

                if (num < valorInteiro)
                {
                    Console.WriteLine("O valor inserido é menor que o valor sorteado");
                    f = false;
                }
                if (num == valorInteiro)
                {
                    i = 0;
                    f = true;
                    Console.WriteLine("Parabéns! Você acertou!");
                }
            }
            if (f == false)
            {
                Console.WriteLine("Você Perdeu! O valor era: " + valorInteiro);
            }
        }
    }
}
