using System;

namespace Covid19
{
    public static class Menu
    {
        public static void Show(int option)
        {
            switch(option)
            {
                case 1:
                    Console.WriteLine("Inserir um paciente");
                    break;
                case 2:
                    Console.WriteLine("Alterar dados de um paciente");
                    break;
                case 3:
                    Console.WriteLine("Remover um paciente");
                    break;
                case 4:
                    Console.WriteLine("Realizar teste do covid");
                    break;
                case 5:
                    Console.WriteLine("Inserir óbito");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("Importar pacientes de arquivo texto");
                    break;
                case 8:
                    Console.WriteLine("Importar testes de arquivo texto");
                    break;
                case 9:
                    Console.WriteLine("Importar óbitos de arquivo texto");
                    break;
                case 10:
                    Console.WriteLine("Exportar um CSV com os dados estatisticos " +
                        "de crescimento por mes qtd de pacientes total, " +
                        "qtd de pacientes testados, qtd de pacientes infectados, e qtd de obitos");
                    break;
                default:
                    Console.WriteLine("Digite um valor válido.");
                    break;

            }
        }
    }
}
