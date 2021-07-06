using System;
using System.Collections.Generic;
using Covid19.Entities;

namespace Covid19
{
    public static class Program
    {
        private static List<Paciente> _pacientes = new List<Paciente>();
        private static List<Obito> _obitos = new List<Obito>();
        private static List<Teste> _testes = new List<Teste>();

        public static void AdicionarPaciente()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Sexo: ");
            char sexo = Console.ReadLine()[0];
            Console.Write("Data de Nascimento: ");
            string dataNascimento = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Estado: ");
            string estado = Console.ReadLine();
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Paciente paciente = new Paciente();
            paciente.Nome = nome;
            paciente.CPF = cpf;
            paciente.Sexo = sexo;
            paciente.DataNascimento = dataNascimento;
            paciente.Idade = idade;
            paciente.Estado = estado;
            paciente.Cidade = cidade;

            _pacientes.Add(paciente);
        }

        public static void PacientesCadastrados()
        {
            foreach (var paciente in _pacientes)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine(paciente.Nome);
                Console.WriteLine(paciente.Sexo);
                Console.WriteLine(paciente.DataNascimento);
                Console.WriteLine(paciente.Idade);
                Console.WriteLine(paciente.Estado);
                Console.WriteLine(paciente.Cidade);
                Console.WriteLine("---------------------");
            }
        }

        public static void AdicionarTeste()
        {
            Console.Write("CPF do paciente: ");
            string cpf = Console.ReadLine();
            Console.Write("Data do teste: ");
            string dataTeste = Console.ReadLine();
            Console.Write("Resultado: ");
            int resultado = int.Parse(Console.ReadLine());

            Teste teste = new Teste();
            teste.CPF = cpf;
            teste.DataTeste = dataTeste;
            
            if(resultado == 0)
                teste.Resultado = false;
            else 
                teste.Resultado = true;

            _testes.Add(teste);
        }

        public static void AdicionarObito()
        {
            Console.Write("CPF do óbito: ");
            string cpf = Console.ReadLine();
            Console.Write("Data do óbito: ");
            string dataObito = Console.ReadLine();

            Obito obito = new Obito();
            obito.CPF = cpf;
            obito.DataObito = dataObito;

            _obitos.Add(obito);

        }


        static void Main(string[] args)
        {
            while (true)
            {
                Menu.Show();
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Program.AdicionarPaciente();
                        break;
                    case 2:
                        Program.PacientesCadastrados();
                        break;
                    case 3:
                        Program.AdicionarTeste();
                        break;
                    case 4:
                        Program.AdicionarObito();
                        break;
                    case 99:
                        Environment.Exit(1);
                        break;
                    default:
                        Menu.Show();
                        break;
                }
            }

        }
    }
}
