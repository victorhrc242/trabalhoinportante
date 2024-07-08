using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class ReceberCupom
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ReceberCupom(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }

        public void ExibirCupom()
        {
            Console.WriteLine($"------------- Cupons -------------\n" +
        $"Id do cliente {Id}\n" +
        $"Nome do cliente{Nome}\n" +
        $"-----------------------------------\n");
        }
    }
}
