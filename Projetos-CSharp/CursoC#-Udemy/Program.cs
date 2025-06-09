using System;
using System.Collections.Generic;
using System.Text;

using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.ExplorandoApi;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main() {
            Console.Clear();
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
              //                   Classes e Metodos
                { "Construtores - Classes & Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes & Métodos", MetodosERetornos.Executar},
                {"Métodos Estáticos - Classes & Métodos", MetodosEstatico.Executar},
                {"Atributos Estáticos - Classes & Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes & Métodos", DesafioAtributo.Executar},
                {"Params - Classes & Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes & Métodos", ParametrosNomeados.Executar},
                {"Getters e Stters - Classes & Métodos", GetSet.Executar},
                {"Propriedade - Classes & Métodos", Props.Executar},
                {"Atributos Readonly - Classes & Métodos", Readonly.Executar},
                {"Enumerações - Classes & Métodos", Enumeracoes.Executar},
                {"Struct - Classes & Métodos", ExemploStruct.Executar},
                {"Struct Vs Classes - Classes & Métodos", StructVsClasses.Executar},
                {"Valor vs Referência - Classes & Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes & Métodos", ParametrosPorReferencia.Executar},

                //                     Coleções
                {"Arrays - Coleções", Colecoes.Array.Executar},
                {"Coloções de Listas - Coleções", ColecoesList.Executar},
                {"Coleções de Array List - Coleçoes", ColecoesArrayList.Executar},
                {"Set List - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //                  Orientação Objetos
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstrato - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Selead - OO", Sealed.Executar},

                //                  Métodos e funções
                {"Exemplo de Lambda - Métodos & Funções", ExemploDeLambda.Executar},
                {"Lambda e Delegate - Métodos & Funções", DelegateLambda.Executar},
                {"Usando Delegates - Métodos & Funções", UsandoDelegates.Executar},
                {"Delegates e FUnções Anônima - Métodos & Funções", DelegateFunAnonima.Executar},
                {"Delegates Com Parametros - Métodos & Funções", DelegatesComParametros.Executar},
                {"Métodos de extensão - Métodos & Funções", MetodosExtensao.Executar},

                //                      Exceções
                {"Primeira Exceção - Exceção", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceção", ExcecoesPersonalizadas.Executar},

                //                       Api
                {"Primeiro Api - Explorando Api", PrimeiroApi.Executar},

                //                 Tópicos Avançados
                {"LINQ1 - Tópicos Avançados", LINQ.Executar},
                {"LINQ2 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamic - Tópicos Avançados", Dynamics.Executar},
                {"Generics - Tópicos Avançados", Generics.Executar},
            });

            central.SelecionarEExecutar();
        }
    }

}
