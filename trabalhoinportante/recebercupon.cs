using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                exibirmenu();
                acaoselecionada = solicitaracaousuario();
                realizaracao(acaoselecionada);
            }
        }
        private void exibirmenu()
        {
            Console.WriteLine($"----------------- Cupon -------------\n" +
                                          $"\n 1 -carro " +
                                         $"\n 2 -Moto" +
                                         $"\n 0-voltar"+
                                  $"\n -------------------------------------");
        }
        private int solicitaracaousuario()
        {
            int acao = -1;
            while (acao > 2 || acao < 0)
            {
                Console.WriteLine("qual ação voce deseja realizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 6 || acao <= 0)
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
             double total =  valorestacionamento-cuponcar;
            Console.WriteLine($"seu cupon sera de{total}");
        }
        public void recebercuponmoto()
        {
            double total=valorestacionamento-cuponmoto;
            Console.WriteLine($"o seu cupon sera de {total}");
        }
    }
}
