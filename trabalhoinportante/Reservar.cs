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
        public string acao { get; set; }
        public void MenuReser()
        {

            Console.WriteLine("qual o seu veiculo,carro ou moto?");
            if (acao=="carro")
            {
                string veiculo = Console.ReadLine();
                Console.WriteLine("qual a sua placa");
                string placa = Console.ReadLine();
                Console.WriteLine("");
            }
            else if (acao=="moto")
            {
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

                }

                
            }

           


    }


    }
}

