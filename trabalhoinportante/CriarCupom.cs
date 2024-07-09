﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class CriarCupom
    {
        public List<CriarCupom> cupons { get; set; }
        
        public void AdicionarCupom(ReceberCupom cupom)
        {

            cupons.Add(cupom);

        } 
        
        public void ExcluirCupom(ReceberCupom cupom)
        {
            cupons.Remove(cupom);
        }

        public void ListarCupom()
        {
            Console.WriteLine("------------------ Listar Cliente ---------------------");
            foreach (CriarCupom cupom in cupons)
            {
                cupom.ExibirCupom();
            }
        }
    }
}