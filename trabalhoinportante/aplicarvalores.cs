﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class aplicarvalores
    {

        public List<editarecancelarreserva> cadastro { get; set; }
        public List<cadastro> c { get; set; }
        cadastro cc=new cadastro();
        public aplicarvalores()
        {
            cadastro = new List<editarecancelarreserva>();


        }
        private void inicializarDados()
        {
            c.Add(cc.usuarioCliente);

          
            

          




        }
        public void adicionarmarketing(editarecancelarreserva editarecancelarreserva)
        {

            int novoid = cadastro.Max(marketing => marketing.id) + 1;
            editarecancelarreserva.altearid(novoid);
            cadastro.Add(editarecancelarreserva);
        }
        public void listarmarketing()
        {
            Console.WriteLine("_______Lista markting______\n");
            foreach (editarecancelarreserva editarecancelarreserva in cadastro)
            {
                editarecancelarreserva.editarreservas();
            }
        }

        public void editafuncionario(int profissaoselecionada, int idfuncionario, int campo, string resposta)
        {
            if (profissaoselecionada == 1)
            {
                gerente ger = colaboradores.buscargerenteporid(idfuncionario);
                if (campo == 1)
                {
                    ger.nome = resposta;

                }
                else if (campo == 2)
                {
                    ger.idade = int.Parse(resposta);
                }
            }
        }

