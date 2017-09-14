using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
    public class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public Aluno(String nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return "[Aluno: " + this.nome + ", matricula: " + this.numeroMatricula + "]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }

        ///<image url="$(ProjectDir)\Slides\image.png" scale=""/>

        //importante: rapidez da busca depende do CÓDIGO DE DISPERSÃO!
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }


        ///obtendo o código de dispersão


        ///comparando código de dispersão de a1 e tonini


        //IMPORTANTE!!
        //Dois objetos que são iguais possuem o mesmo hash code.
        //PORÉM, o contrário não é verdadeiro: 
        //Dois objetos com mesmo hash codes não são necessariamente iguais! 

        ///<image url="$(ProjectDir)\Slides\image.png" scale=""/>
    }
}
