using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal;

namespace trabalhoinportante
{
    public class MenuCliente
    {
        cadastro c=new cadastro();
        primeiro_Menu b = new primeiro_Menu();
        public int Menu()
        {
            
            int acao = -1;
            while (acao > 8 || acao < 0)
            {
                Console.WriteLine($"----------- Menu Cliente ---------\n" +
                                             $"seja bem vido " +
                                            $"\n 1 -Reservar " +
                                            $"\n 2 -Receber Cupom" +
                                            $"\n 3 -Frequencia" +
                                            $"\n 4 -Editar Vaga" +
                                            $"\n 5 -Suporte" +
                                            $"\n 6 -Sair da conta" +
                                            $"\n 0 -Fechar Programa" +
                                            $"\n Digite qual ação deseja Realizar" +
                                            $"\n qual ação deseja utilizar" +
                                  $"\n -------------------------------------");
                Console.WriteLine("qual ação voce deseja reaizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 8 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");

                }

            }
            switch (acao)
            {
                case 1:
                    Reservar r=new Reservar();
                    r.MenuReser();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                    case 4:

                    break;
                    case 5:

                    break;
                    case 6:

                    break;
            
            }

           return acao;
         
        }
               
         
        
        }
        
    }

