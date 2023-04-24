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

        public int idade;

        public string rg;
        
        public bool bolsa;

        public float mediaFinal;
        public float mensalidade;

        public float VerMediaFinal()
        {
            return mediaFinal;
        }

        public float VerMensalidade()
        {
            switch (bolsa)
            {
                case true:
                 if (mediaFinal >= 8)
                 {
                    mensalidade = (mensalidade * 0.5f);
                 }
                 else if (mediaFinal > 6 && mediaFinal < 8)
                 {
                    mensalidade = mensalidade - (mensalidade * 0.3f);
                 }
                 else
                 {
                    mensalidade = mensalidade;
                 }
                    break;
                default:
                mensalidade = mensalidade;
                    break;
            }
            return mensalidade;
            
        }

    }
}