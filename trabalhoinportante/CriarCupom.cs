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
        
        public void AdicionarCupom(ReceberCupom Cupom)
        {

            cupons.Add(Cupom);

        } 
    }
}
