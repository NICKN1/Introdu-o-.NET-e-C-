using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
        

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: ADCIONAR ALUNO
                        break;
                    case "2":
                        //TODO: LISTAR ALUNOS
                        break;
                    case "3":
                        //TODO: CALCULAR MEDIA GERAL
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine();
            Console.WriteLine("X - Sair");

            Console.ReadLine();
        }
    }
}
