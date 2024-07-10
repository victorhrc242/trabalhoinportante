using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using trabalhoinportante;

namespace TrabalhoFinal
{
    public class cadastrar
    {
        cadastro C = new cadastro();        
        primeiro_Menu p=new primeiro_Menu();
        public void escolherAcao()
        {
            Console.WriteLine("-------------CADASTRAR---------------\n"+
                                         "1-CLIENTE\n"+
                                         "2-Sair"
                                         );

            int acao = int.Parse(Console.ReadLine());
            switch (acao)
            {
                case 1:
                    C.cadastrarclientes();
                    break;
                case 2:
                    p.chamarprimeiromenu();
                    break;
               
            }


        }









    }
}
