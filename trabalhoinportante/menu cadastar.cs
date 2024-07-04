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
        cadastrarcliente C = new cadastrarcliente();        
        public void escolherAcao()
        {
            Console.WriteLine("-------------CADASTRAR---------------\n" +
                                         "O QUE Voce\n" +
                                         "1-CLIENTE\n" +
                                         "2-ADMINISTRADOR");

            int acao = int.Parse(Console.ReadLine());
            switch (acao)
            {
                case 1:
                    C.cadastrarclientes();
                    break;
                case 2:
                  
                    break;
            }


        }









    }
}
