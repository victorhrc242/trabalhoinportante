using System;
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
        public bool Cupom { get; set; }


        public void AdicionarCupom(CriarCupom cupom)
        {

            cupons.Add(cupom);

        } 
        
        public void ExcluirCupom(CriarCupom Cupom)
        {
            cupons.Remove(Cupom);
        }

        public void ListarCupom()
        {
            
            Console.WriteLine("------------------ Listar Cupom ---------------------");
            foreach (CriarCupom cupom in cupons)
            {
                cupom.AdicionarCupom();
            }
        }

    }
}
