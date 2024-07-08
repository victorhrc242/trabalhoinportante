using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal;

namespace trabalhoinportante
{
    public class MenuCliente
    {
        Reservar a = new Reservar();
        primeiro_Menu b = new primeiro_Menu();
        public int Menu()
        {
            Console.WriteLine($"----------- Menu Cliente ---------" +
        $"\n 1 -Reservar " +
        $"\n 2 -Receber Cupom" +
        $"\n 3 -Frequencia" +
        $"\n 4 -Editar Vaga" +
        $"\n 5 -Suporte" +
        $"\n 6 -Sair da conta" +
        $"\n 0 -Fechar Programa" +
        $"\n Digite qual ação deseja Realizar" +
        $"\n -------------------------------------");
            int acao = int.Parse(Console.ReadLine());
            if (acao > 6 || acao < 0)
            {
                Console.WriteLine("Error");
            }
         
            switch(acao)
            {
                case 1:
                    a.MenuReser();
                    break;

                case 6:
                    b.exibirmenu1();
                break;

            }
            return acao;
        }
        
    }
}
