using System;

namespace Covid19
{
    public static class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Digite uma opção: ");
            Console.WriteLine("1 - Inserir um paciente");
            Console.WriteLine("2 - Listar pacientes");
            Console.WriteLine("3 - Inserir um teste");
            Console.WriteLine("4 - Inserir um óbito");
            Console.WriteLine("99 - Sair");
        }

    }
}
