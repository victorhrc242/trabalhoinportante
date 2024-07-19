using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using viv;

namespace trabalhoinportante
{
    public class recebercupom
    {
        private double valorestacionamento;
        public double cuponcar { get; set; }
        public double cuponmoto { get; set; }
        
        public recebercupom()
        {
            cuponcar = new Random().Next(10,50);
            cuponmoto = new Random().Next(5, 30);
            valorestacionamento = 60;
        }
        public void iniciarmenu()
        {
            int acaoselecionada=-1;

            while (acaoselecionada != 0)
            {
               
                acaoselecionada = solicitaracaousuario();
                realizaracao(acaoselecionada);
            }
        }
        public int solicitaracaousuario()
        {
         
            int acao = -1;
            while (acao > 2 || acao < 0)
            {
                Console.WriteLine($"----------------- Cupon -------------\n" +
                                       $"\n 1 -carro " +
                                      $"\n 2 -Moto" +
                                      $"\n 0-voltar" +
                               $"\n -------------------------------------");
                Console.WriteLine("qual ação voce deseja realizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 2 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");

                }
            }
            return acao;
        }
        public void realizaracao(int acao)
        {
            switch (acao)
            {
                case 1:recebercuponmoto();

                    break; 
                case 2:
                   recebercuponseforcarro();
                    break; 
            }
        }
        public void recebercuponseforcarro()
        {
            int acao;
            double total =  valorestacionamento-cuponcar;
            Console.WriteLine($"seu cupon sera de{total}");
            Console.WriteLine("vc que aplicar o sseu desconto na reserva?");
            acao=int.Parse(Console.ReadLine());
            if (acao==1)
            {
                Reservar r=new Reservar();
                r.MenuReser();
            }
            else if (acao == 2)
            {
                sistemas s=new sistemas();
                s.iniciarsistema();
            }
        }
        public void recebercuponmoto()
        {
            string acao;
            double total=valorestacionamento-cuponmoto;
            Console.WriteLine($"o seu cupon sera de {total}");
            Console.WriteLine("vc que aplicar o sseu desconto na reserva?s/n");

            acao = Console.ReadLine();
            if (acao == "s")
            {
                Reservar r = new Reservar();
                r.MenuReser();
            }
            else if (acao == "n")
            {
                sistemas s = new sistemas();
                s.iniciarsistema();
            }
        }
    }
}
