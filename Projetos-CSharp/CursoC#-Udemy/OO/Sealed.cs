using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    class Avo
    {
        public virtual bool HonraDaFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonraDaFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        /*public override bool HonraDaFamilia()
        {
            return false;
        }*/
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonraDaFamilia());
        }
    }
}