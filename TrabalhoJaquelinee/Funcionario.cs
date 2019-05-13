using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJaquelinee
{
    class Funcionario : Pessoa
    {

        private string turno;
        private string profissão;
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public string Profissão
        {
            get { return profissão; }
            set { profissão = value; }
        }

        public Funcionario() : base() { }

        public string MostraFuncionario()
        {
            string aux = "";
            aux = base.MostraPessoa() + "-" + turno + "-" + profissão;

            return aux;
        }

    }
}
