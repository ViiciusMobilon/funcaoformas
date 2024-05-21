using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite se é quadrado - trapézio - retangulo - Losango");
           string forma = Console.ReadLine().ToLower();
          switch (forma)
            {
                case "quadrado":
                    Qua();
                    break;
                case "trapezio":
                    trapezio();
                    break;
                case "retangulo":
                    retangulo();
                    break;
                case "losangulo":
                    losangulo();
                    break;
            }


            Console.ReadKey();
            
           
        }

         static void Qua()
        {
            
           Console.WriteLine("Digite a altura");
           double altura= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * altura;
            Console.WriteLine("A area do quadrado é: " + area);
        }

        static void trapezio() 
        {
            Console.WriteLine("Digite a altura");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro lado");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado");
            double lado2 = double.Parse(Console.ReadLine());
            double area = (lado1 + lado2) * altura / 2;
            Console.WriteLine("A area do trapézio é "+ area);
        }
        static void retangulo()
        {

            Console.WriteLine("Digite a altura");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * altura;
            Console.WriteLine("A area do retangulo é: " + area);
            
        
        }
        static void losangulo()
        {
            Console.WriteLine("Digite a altura");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro lado");
            double lado = double.Parse(Console.ReadLine());

            double area = (lado * altura ) / 2;
            Console.WriteLine("A area do losangulo "+area);
        }
    }
}
