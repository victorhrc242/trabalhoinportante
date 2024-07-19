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
        recebercupom r = new recebercupom();
        public string acao { get; set; }
        double numerocar=60;
        double numeromoto=30;
        public void MenuReser()
        {

            Console.WriteLine("qual o seu veiculo,carro ou moto?");
            acao = Console.ReadLine();
            if (acao=="carro")
            {
                Console.WriteLine("qual a sua placa");
                string placa = Console.ReadLine();
                Console.WriteLine("qual o seu cpf?");
                double cpf = double.Parse(Console.ReadLine()); Console.WriteLine("vc quer usar o seu cupon?s/n");

                if (acao == "s")
                {

                }
                else if (acao == "n")
                {
                    Console.WriteLine($"vc ira pagar{numerocar}");
                }
            }
            else if (acao=="moto")
            {
                DateTime houra;
                string veiculo = Console.ReadLine();
                Console.WriteLine("qual a sua placa");
                string placa = Console.ReadLine();
                Console.WriteLine("qual o seu cpf");
                double cpf =double.Parse( Console.ReadLine());
                Console.WriteLine("vc quer usar o seu cupon?s/n");
                
                if (acao=="s")
                {
              
                }
                else if (acao == "n")
                {
                    Console.WriteLine($"vc ira pagar{numeromoto}");
                }
            }
    }
    }
}

