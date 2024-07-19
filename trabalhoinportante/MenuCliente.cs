using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoinportante;

namespace viv
{
    public class sistemas
    {
        public void iniciarsistema()
        {
            int acaoselecionada = -1;

            while (acaoselecionada != 0)
            {
                exibirmenu();
                acaoselecionada = solicitaracaousuario();
                RealizarAcaorealizada(acaoselecionada);
            }
        }
        private int solicitaracaousuario()
        {
            int acao = -1;
            while (acao > 6 || acao < 0)
            {
                Console.WriteLine("qual ação voce deseja realizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 6 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");
                }
            }
            return acao;
        }
        private void exibirmenu()
        {
            Console.WriteLine($"----------- Menu Cliente ---------\n" +
                                             $"seja bem vido " +
                                            $"\n 1 -Reservar " +
                                            $"\n 2 -Receber Cupom" +
                                            $"\n 4 -Editar Vaga" +
                                            $"\n 0 -Fechar Programa" +
                                            $"\n qual ação deseja utilizar" +
                                  $"\n -------------------------------------");
        }
        private void RealizarAcaorealizada(int acaoselecionada)
        {
            switch (acaoselecionada)
            {
                case 1:
                  Reservar re=new Reservar();
                    re.MenuReser();
                    break;
                case 2:
                   recebercupom r=new recebercupom();
                    r.iniciarmenu();
                    break;
                case 3:
       
                    break;
                case 4:
                  
                    break;
               
            }
        }

    
    }
}



