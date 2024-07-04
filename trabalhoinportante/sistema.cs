using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal;
using trabalhoinportante;

namespace TrabalhoFinal
{

    public class primeiro_Menu
    {
        // primeira parte do menu
  
      

        public int chamarprimeiromenu()
        {
            int acaoselecionada = -1;
            while (acaoselecionada != 0)
            {
                exibirmenu1();
                acaoselecionada = solicitaracaousuario();
                realizaracaoselecionada(acaoselecionada);
            }

            return acaoselecionada;
        }
        public int solicitaracaousuario()
        {
            int acao = -1;
            while (acao > 2 || acao < 0)
            {
                Console.WriteLine("qual ação voce deseja reaizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 2 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");

                }

            }


            return acao;
        }


        public void exibirmenu1()
        {
            Console.WriteLine("-------------MENU INICIAR---------------\n" +
                                           "1-CADSTRAR\n" +
                                           "2-ENTRAR");
        }
        public int acaoselecionada { get; set; }

        public int realizaracaoselecionada(int acaoselecionada)
        {
          cadastrar c=new cadastrar();
            switch (acaoselecionada)
            {
                case 1:
                    c.escolherAcao();
                  

                    break;
                case 2:
                

                    break;
            }


            return acaoselecionada;
        }
        
        // final primeira parte do menu




    }
}
