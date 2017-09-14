using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._1_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos criar um dicionário de alunos
            //VT, Vanessa, 34672
            //AL, Ana, 5617
            //RN, Rafael, 17645
            //WM, Wanderson, 11287
            IDictionary<string, Aluno> alunos
                = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            //imprimindo...
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //vamos remover: AL
            alunos.Remove("AL");
            //vamos adicionar: MO
            alunos.Add("MO", new Aluno("Marcelo", 12345));
            Console.WriteLine();
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //como é internamente um Dictionary?
            ///<image url="$(ProjectDir)\Slides\img1.png" scale=""/>

            //apresentando nova coleção...SortedList

            IDictionary<string, Aluno> sorted
                = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            ///<image url="$(ProjectDir)\Slides\img2.png" scale=""/>
        }
    }
}
