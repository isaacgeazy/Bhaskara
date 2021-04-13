using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;
          

            Console.Write("Digite o Valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de C: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine();
            Console.Write("x1 é ");
            Console.WriteLine(Math.Round(x1, 2));

            Console.Write("x2 é ");
            Console.WriteLine(Math.Round(x2, 2));

            if (a == 0){

                Console.Write("Não é uma equação do segundo grauuu");

            }else if (delta < 0) {

                Console.Write($"Como delta = {delta}, a equação não possui raízes reais!");

            }
        }
    }
}
