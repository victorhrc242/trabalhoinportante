using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class Reservar
    {
        DateTime tempodereserva = DateTime.Now;
        List<Reservar> Vagas = new List<Reservar>();
        public string Veiculo { get; set; }
        public string Nome { get; set; }
        public double Valor = 10.00;
        public string Vaga { get; set; }
        ReceberCupom l {get; set;}


        public int MenuReser()
        {
            Console.WriteLine($"----------- Reserva ---------" +
        $"\n 1 -Vaga Disponiveis " +
        $"\n 2 -Reservar" +
        $"\n Digite qual ação deseja Realizar" +
        $"\n -------------------------------------");
            int acao = int.Parse(Console.ReadLine());
            if (acao > 5 || acao < 0)
            {
                Console.WriteLine("Error");
            }

            switch (acao)
            {
                case 1:

                    break;

                case 2:
                    reservar();
                    break;

            }
            return acao;
        }

        public void reservar()
        {
            Console.WriteLine("Qual seu veiculo?");
            Veiculo = Console.ReadLine();
            Console.WriteLine("Qual seu nome?");
            Nome = (Console.ReadLine());
            Console.WriteLine("Qual vaga você vai ocupar?");
            Vaga = (Console.ReadLine());
            Console.WriteLine($"Voçê vai resevar por quanto tempo?");
            tempodereserva=DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Vai usar cupom?" +
                $"\n(Escreva sim ou nao)");
            string acao = (Console.ReadLine());
            if (acao == "sim")
            {
                l.ExibirCupom();
            }
            Console.WriteLine($"O valor do estacionamento: {Valor}");
        }
    }
}

