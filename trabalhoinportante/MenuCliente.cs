﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class MenuCliente
    {
        cadastro c=new cadastro();
        Reservar a = new Reservar();
        public int Menu()
        {
            
            int acao = -1;
            while (acao > 0 || acao < 0)
            {
                Console.WriteLine($"----------- Menu Cliente ---------\n" +
                                $"seja ben vido {c.usuarioCliente}" +
        $"\n 1 -Reservar " +
        $"\n 2 -Receber Cupom" +
        $"\n 3 -Frequencia" +
        $"\n 4 -Editar Vaga" +
        $"\n 5 -Suporte" +
        $"\n 6 -Sair da conta" +
        $"\n 0 -Fechar Programa" +
        $"\n Digite qual ação deseja Realizar" +
        $"\n qual ação deseja utilizar"+
        $"\n -------------------------------------");
                acao = int.Parse(Console.ReadLine());
                if (acao > 6 || acao < 0)
                {
                    Console.WriteLine("Error");
                }
            }
               
         
            switch(acao)
            {
                case 1:
                    a.MenuReser();
                    break;

            }
            return acao;
        }
        
    }
}
