using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4._2_OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Concatenando duas sequências");
            ///<image url="$(ProjectDir)\Slides\img1.png" scale=""/>
            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("União de duas sequências");
            ///<image url="$(ProjectDir)\Slides\img2.png" scale=""/>
            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("União de duas sequências com comparador");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Interseção de duas sequências");
            ///<image url="$(ProjectDir)\Slides\img4.png" scale=""/>
            var consulta4 = seq1.Intersect(seq2);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Exceto: elementos de seq1 que não estão em seq2");
            ///<image url="$(ProjectDir)\Slides\img5.png" scale=""/>
            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
