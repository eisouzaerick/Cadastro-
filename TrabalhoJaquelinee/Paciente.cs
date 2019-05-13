using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJaquelinee
{
    class Paciente:Pessoa
    {

        private int numfic;

        public int Nunfic
        {
            get { return numfic; }
            set { numfic = value; }
        }
  
        public Paciente() : base() { }

        public string MostraPaciente()
        {
            string aux = "";
            aux = base.MostraPessoa() + "-" + numfic;

            return aux;
        }
    }
}
