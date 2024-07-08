using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Qual seu veiculo?");
            Veiculo = Console.ReadLine();
            Console.WriteLine("Quando vai ser sua data de Entrada?");
            DataEntra = double.Parse(Console.ReadLine());
            Console.WriteLine("Quando vai ser sua data de Saida?");
            DataSaida = double.Parse(Console.ReadLine());
        }
    }
}
