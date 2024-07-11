using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viv
{
    public class sistemas
    {
        public gerenciadorespecial gerenciador { get; set; }
        public sistemas()
        {
            gerenciador = new gerenciadorespecial();
        }
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
        private void calcularbonificacao()
        {
            Console.WriteLine("deseja realizar o calculo de:");
            Console.WriteLine("1- todos os funcionarios:");
            Console.WriteLine("2-funcionarios por id:");
            int opcaoSelecionada = int.Parse(Console.ReadLine());
            if (opcaoSelecionada == 1)
            {
                gerenciador.ListarBonificacaoAnualTodaempresa();
            }
            else if (opcaoSelecionada == 2)
            {
                calcularbonificacaoporidfuncionario();
            }
            else
            {
                Console.WriteLine("erro opção invalida");
                Console.WriteLine("digite uma opção valida");
            }
        }
        private void calcularbonificacaoporidfuncionario()
        {
            Console.WriteLine("---------------profissoes-----------");
            Console.WriteLine("1-gerente");
            Console.WriteLine("2-caixa");
            Console.WriteLine("3-marketing");
            Console.WriteLine("4-desenvolvedor");
            Console.WriteLine("digite qual porfissão deseja alterar");
            int profissaoselecionada = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o id do funcionario que deseja calcular:");
            int idfuncionario = int.Parse(Console.ReadLine());
            gerenciador.calcularbonificacopeloidfuncionario(profissaoselecionada, idfuncionario);
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
            Console.WriteLine(
                $"____________menu inicial____________" +
                $"\n1-Listar funcionarios" +
                $"\n2-calcular bonificação" +
                $"\n3-adicionar"
                + $"\n4-remover" +
                $"\n5-editar" +
                $"\n6-colocar aumento" +
                $"____________________________________" + $"");



        }
        private void RealizarAcaorealizada(int acaoselecionada)
        {
            switch (acaoselecionada)
            {
                case 1:
                    gerenciador.listaFuncionarios();
                    break;
                case 2:
                    calcularbonificacao();
                    break;
                case 3:
                    adicionarfuncionario();
                    break;
                case 4:
                    removerfuncionario();
                    break;
                case 5:
                    editarfuncionario();
                    break;
                case 6:
                    colocaraumento();
                    break;
            }
            //if (acaoselecionada == 1)
            //{

            //    gerenciador.listaFuncionarios();
            //}
            //else if (acaoselecionada == 2)
            //{

            //}
            //else if (acaoselecionada == 3)
            //{

            //}
            //else if (acaoselecionada == 4)
            //{

            //}
            //else if (acaoselecionada == 5)
            //{

            //}





        }
        private void adicionarfuncionario()
        {
            Console.WriteLine("--digite qual profissão deseja adicionar--");
            Console.WriteLine("1-gerente");
            Console.WriteLine("2-caixa");
            Console.WriteLine("3-marketing");
            Console.WriteLine("4-desenvolvedor");
            Console.WriteLine("digite qual porfissão deseja alterar");
            int profissaoselecionada = int.Parse(Console.ReadLine());
            gerenciador.adicionarfuncionarios(profissaoselecionada);
        }

        public void removerfuncionario()
        {

            Console.WriteLine("--digite qual profissão deseja adicionar--");
            Console.WriteLine("1-gerente");
            Console.WriteLine("2-caixa");
            Console.WriteLine("3-marketing");
            Console.WriteLine("4-desenvolvedor");
            Console.WriteLine("digite qual porfissão deseja alterar");
            int profissaoselecionada = int.Parse(Console.ReadLine());
            gerenciador.listarfuncionariosporseleçãoselecionada(profissaoselecionada);
            Console.WriteLine("qual id funcionario deseja remover");
            int idfuncionario = int.Parse(Console.ReadLine());

            gerenciador.excluirfuncionario(profissaoselecionada, idfuncionario);
        }
        public void editarfuncionario()
        {
            Console.WriteLine("--digite qual profissão deseja editar--");
            Console.WriteLine("1-gerente");
            Console.WriteLine("2-caixa");
            Console.WriteLine("3-marketing");
            Console.WriteLine("4-desenvolvedor");
            Console.WriteLine("digite qual porfissão deseja alterar");
            int profissaoselecionada = int.Parse(Console.ReadLine());
            gerenciador.listarfuncionariosporseleçãoselecionada(profissaoselecionada);
            Console.WriteLine("qual id funcionario deseja remover");
            int idfuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("1-nome");
            Console.WriteLine("2-idade");
            Console.WriteLine("qual campo deseja atualizar");
            int campo = int.Parse(Console.ReadLine());
            Console.WriteLine("novo valor para o campo");
            string resposta = Console.ReadLine();

            gerenciador.editafuncionario(profissaoselecionada, idfuncionario, campo, resposta);

        }
        public void colocaraumento()
        {
            Console.WriteLine("--digite qual profissão deseja aumentar o seu salario--");
            Console.WriteLine("1-gerente");
            Console.WriteLine("2-caixa");
            Console.WriteLine("3-marketing");
            Console.WriteLine("4-desenvolvedor");
            Console.WriteLine("digite qual porfissão deseja alterar o salario");
            int profissaoselecionada = int.Parse(Console.ReadLine());
            gerenciador.listarfuncionariosporseleçãoselecionada(profissaoselecionada);
            Console.WriteLine("qual id funcionario deseja aumentar salario");
            int idfuncionario = int.Parse(Console.ReadLine());
            gerenciador.aumentodesalario(profissaoselecionada, idfuncionario);
        }
    }
}



