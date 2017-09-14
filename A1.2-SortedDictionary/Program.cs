using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<image url="$(ProjectDir)\Slides\img1.png" scale=""/>

            IDictionary<string, Aluno> sorted
                = new SortedDictionary<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            ///<image url="$(ProjectDir)\Slides\img2.png" scale=""/>

            ///<image url="$(ProjectDir)\Slides\img3.png" scale=""/>

        }
    }
}
