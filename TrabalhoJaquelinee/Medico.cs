using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJaquelinee
{
    class Medico : Pessoa
    {

        private string graduação;
        private double salario;
        private List<Paciente> pacientes;

        public string Graduação
        {
            get { return graduação; }
            set { graduação = value; }
        }
       
        public Medico()
        {
            Pacientes = new List<Paciente>();
        }

        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }
        public void AddPaciente(Paciente P)
        {
            Pacientes.Add(P);
        }
        public string MostraMedico()
        {
            string aux = "";
            aux = base.MostraPessoa() + "-" + graduação;

            return aux;
        }
    }
}
