
using System;

namespace Covid19.Entities
{
    public class Paciente : Pessoa
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string DataNascimento { get; set; }   
        public int Idade { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
