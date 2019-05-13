using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJaquelinee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> F = new List<Funcionario>();
            List<Medico> M = new List<Medico>();
            List<Paciente> P = new List<Paciente>();


            Funcionario Fu = null;
            Medico Me = null;
            Paciente Pa = null;
            int d, m, a;
            bool aux = false;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Cadastrar Funcionário ");
                Console.WriteLine("2.Cadastrar Médico");
                Console.WriteLine("3.Cadastrar Paciente ");
                Console.WriteLine("4.Associar paciente ao médico ");
                Console.WriteLine("5.Listar pacientes por médico ");
                Console.WriteLine("6.Sair");
                Console.WriteLine();
                Console.Write("Sua opção: ");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        Fu = new Funcionario();
                        Console.WriteLine("Cadastrando Funcionário...");
                        Console.Write("Nome: ");
                        Fu.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a data de nascimento: ");
                        Console.Write("Dia: ");
                        d = int.Parse(Console.ReadLine());
                        Console.Write("Mes: ");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("Ano: ");
                        a = int.Parse(Console.ReadLine());
                        Fu.SetDataNasc(d, m, a);
                        Console.Write("Turno: ");
                        Fu.Profissão = Console.ReadLine();
                        Console.WriteLine("Profissão: ");
                        Fu.Turno = Console.ReadLine();
                        F.Add(Fu);
                        break;
                    case 2:
                        Me = new Medico();
                        Console.WriteLine("Cadastrando Médico...");
                        Console.Write("Nome: ");
                        Me.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a data de nascimento: ");
                        Console.Write("Dia: ");
                        d = int.Parse(Console.ReadLine());
                        Console.Write("Mes: ");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("Ano: ");
                        a = int.Parse(Console.ReadLine());
                        Me.SetDataNasc(d, m, a);
                        Console.Write("Graduação: ");
                        Me.Graduação = Console.ReadLine();
                        
                        M.Add(Me);
                        break;
                    case 3:
                        Pa = new Paciente();
                        Console.WriteLine("Cadastrar Paciente...");
                        Console.Write("Nome: ");
                        Pa.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a data de nascimento: ");
                        Console.Write("Dia: ");
                        d = int.Parse(Console.ReadLine());
                        Console.Write("Mes: ");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("Ano: ");
                        a = int.Parse(Console.ReadLine());
                        Pa.SetDataNasc(d, m, a);
                        Console.Write("Numero Ficha: ");
                        Pa.Nunfic = int.Parse(Console.ReadLine());
                        P.Add(Pa);
                        break;
                    case 4:
                        Console.Write("Informe o paciente: ");
                        string nome_auxP = Console.ReadLine();

                        foreach (Paciente itemP in P)
                        {
                            if (itemP.Nome == nome_auxP)
                            {

                                Console.Write("Informe o médico: ");
                                string nome_auxM = Console.ReadLine();

                                foreach (Medico itemM in M)
                                {
                                    if (itemM.Nome == nome_auxM)
                                    {
                                        itemM.AddPaciente(itemP);
                                        Console.WriteLine(itemP.Nome + " é paciente do médico " + itemM.Nome);
                                        aux = true;

                                    }
                                }
                            }
                        }
                        if (aux == false)
                        {
                            Console.WriteLine("Paciente ainda não cadastrado!!!");
                            Console.ReadLine();
                        }


                        break;
                    case 5:

                        foreach (Medico medico in M)
                        {
                            Console.WriteLine("Nome do Médico: " + medico.Nome + "\nPacientes:");
                            foreach (Paciente p in medico.Pacientes)
                            {
                                Console.WriteLine(p.MostraPaciente());
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op != 6);
            Console.ReadKey();

        }
    }
}
