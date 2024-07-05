using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal;

namespace trabalhoinportante
{
    public class menu_administrador
    {
        cadastrarcliente c = new cadastrarcliente();
        public void chamaradm()
        {
            Console.WriteLine($"------------menu do adm ola{c.usuarioCliente}-----------------\n" +
                "1-editar reserva" +
              "\n2-cancelar reserva" +
              "\n3-data e hora" +
              "\n4-fechar estacionamento e abrir estacionamento" +
              "\n5-gerar cupom" +
              "\n9-olhar se cupom e valido" +
              "\n7-gerar cupom vip" +
              "\n8-administrar suporte" +
              "\n9-cadastrar vagas disponíveis" +
             "\n10-fechar\r\n");
            int acao = -1;
            while (acao > 11 || acao < 0)
            {
                Console.WriteLine("qual ação voce deseja reaizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 2 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");
                }
            }
        }
        public void acao (int acao){

            switch (acao)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
