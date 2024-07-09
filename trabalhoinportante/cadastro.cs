using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal;

namespace trabalhoinportante
{
    public class cadastro
    {
        
        primeiro_Menu p=new primeiro_Menu();

        public string usuarioCliente { get; set; }
        public string senhacliente { get; set; }
        public string email { get; set; }
        public string senha2 { get; set; }
        public int idade { get; set; }
        public int telefone { get; set; }
        public string cidade { get; set; }
        public double cpf { get; set; }
        public string sexo { get; set; }
      
        public void cadastrarclientes()
        {
            MenuCliente m=new MenuCliente();
            Console.WriteLine("digite un nome");
            usuarioCliente = Console.ReadLine();
            Console.WriteLine("digite sua idade");
            idade= int.Parse(Console.ReadLine());
            Console.WriteLine("digite seu telefone");
            telefone =int.Parse(Console.ReadLine());
            Console.WriteLine("qual cidade");
            cidade=Console.ReadLine();
            Console.WriteLine("Vc e homen ou mulher?");
                sexo= Console.ReadLine();
            Console.WriteLine("qual o seu  e-mail?");
            email = Console.ReadLine();
            Console.WriteLine($"1-confirmar\n"+
                               "2-Voltar Ao inicio");
            int acao=int.Parse(Console.ReadLine());
            switch(acao)
            {
                case 1:
                    m.Menu();
                    break;
                    case 2:
                    p.chamarprimeiromenu();
                    break;
            }
        }
    }
}
