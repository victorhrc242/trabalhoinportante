using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class recebercupom
    {
        private double valorestacionamento { get; set; }
        public double cupon { get; set; }
        public recebercupom()
        {
            cupon = new Random().Next(5, 30);
            valorestacionamento = 30;
        }

        public void recebercupon()
        {
            double total =  (valorestacionamento-cupon);
            Console.WriteLine($"seu cupon sera de{total}");

        }

    }
}
