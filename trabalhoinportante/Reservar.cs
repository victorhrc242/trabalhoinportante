using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class Reservar
    {
        public string Veiculo { get; set; }
        public double DataEntra { get; set; }
        public double DataSaida { get; set; }

        public void MenuReser()
        {
            int acao = -1;
            while (acao > 2 || acao < 0)
            {
                Console.WriteLine($"----------- Reservar ---------\n" +
                                        $"\n 1 -Listar vagas disponiveis " +
                                        $"\n 2 - reservar vagas" +
                                  $"\n -------------------------------------");
                Console.WriteLine("qual ação voce deseja reaizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 2 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");

                }

            }
            switch (acao)
            {
                case 1:
                       
                    break;
                case 2:

                    break;
            }

          

        }
       
     
    }
}

