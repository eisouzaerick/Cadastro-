using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJaquelinee
{
    class Pessoa
    {
        private string nome;
        protected TData dataNasc;
        private char sexo;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Pessoa()
        {
            dataNasc = new TData();
        }
        public string MostraPessoa()
        {
            return Nome;
        }
        public string SetDataNasc(int d, int m, int a)
        {
            string aux = "";
            if (dataNasc.GravarData(d, m, a))
            {
                aux = "Data Válida";
            }
            else
            {
                aux = "Data Inválida";
            }
            return aux;
        }
        public string GetDataNasc()
        {
            return dataNasc.MostrarData();
        }

    }
}
