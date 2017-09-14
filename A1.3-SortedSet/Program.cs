using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._3_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto de alunos:
            ISet<string> alunos
                = new SortedSet<string>(new ComparadorMinusculo())
                {
                    "Vanessa Tonini",
                    "Ana Losnak",
                    "Rafael Nercessian",
                    "Priscila Stuani"
                };

            //adicionar: Rafael Rollo
            alunos.Add("Rafael Rollo");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //adicionar: FABIO GUSHIKEN
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ///<image url="$(ProjectDir)\Slides\img1.png" scale=""/>

            ISet<string> outroConjunto = new HashSet<string>();

            //este conjunto é subconjunto do outro? IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            //este conjunto é superconjunto do outro? IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            //os conjuntos contêm os mesmos elementos? SetEquals
            alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão neste conjunto - ExceptWith
            alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos - IntersectWith
            alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);

        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
