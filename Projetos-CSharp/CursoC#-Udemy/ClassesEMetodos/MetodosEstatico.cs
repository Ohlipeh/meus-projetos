using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
            //Método de classe ou Método estático!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

          //Método de instãncia!
        public int Somar(int a, int b)
        {
            return a + b;
        }

    }

    class MetodosEstatico
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(3, 3);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(50, 50));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 2));
        }
    }
}
