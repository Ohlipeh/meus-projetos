using System;
using System.Collections.Generic;
using System.Text;

using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main() {
            Console.Clear();
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
              //                   Classes e Metodos
                { "Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosERetornos.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstatico.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
            });

            central.SelecionarEExecutar();
        }
    }

}
