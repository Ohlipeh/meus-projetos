using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Dia {Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo}
    public class Semana
    {
        public string Titulo;
        public Dia DiaDaSemana; 
    } 
    class Enumeracoes
    {
        public static void Executar()
        {
            int id = (int)Dia.Sexta;
            Console.WriteLine(id);

            var aulaDeIngles = new Semana();
            aulaDeIngles.Titulo = "Inglês";
            aulaDeIngles.DiaDaSemana = Dia.Quarta;
            Console.WriteLine("{0} é {1}!",aulaDeIngles.Titulo, aulaDeIngles.DiaDaSemana);
        }
    }
}