using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_de_aluno
{
    public class Aluno
    {
        public string nome;
        public string curso;

        public string idade;

        public string rg;

        public bool bolsa;

        public float mediaFinal;
        public float mensalidade;

        public void VerMediaFinal()
        {
            Console.WriteLine($"A média final do(a) aluno(a) {nome} é de {mediaFinal}");
        }

        public float VerMensalidade()
        {

            if (bolsa && mediaFinal >= 8)
            {
                mensalidade = (mensalidade * 0.5f);
            }
            else if (bolsa && mediaFinal > 6)
            {
                mensalidade = mensalidade - (mensalidade * 0.3f);
            }
            else
            {
                mensalidade = mensalidade;
            }
            return mensalidade;
        }
    }
}