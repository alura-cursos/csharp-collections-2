using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._2_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var meses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in meses)
            {
                meses[0] = meses[0].ToUpper();
                Console.WriteLine(mes);
            }

            //for (int i = 0; i < meses.Length; i++)
            //{
            //    var mes = meses[i];
            //    ....
            //}
        }
    }
}
