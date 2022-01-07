using System;

namespace elogio_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            Console.WriteLine("Digite o código do elogio:\n\n1- Elogio Profissional\n2- Elogio Físico\n3- Elogio Pessoal");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Você escolheu ELOGIO PROFISSIONAL");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu ELOGIO FÍSICO");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu ELOGIO PESSOAL");
                    break;
                default:
              
                    Console.WriteLine("Código Inválido");
                    break;



            }
        }
    }
}
