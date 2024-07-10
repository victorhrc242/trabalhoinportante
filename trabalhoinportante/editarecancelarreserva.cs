using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{

    public class editarecancelarreserva
    {
    
        
        public string vagas { get; set; }
        public int id { get; set; }
        public editarecancelarreserva(string v,int i) { 
        
        vagas= v;
        id = i;
        
        }
        public void altearid(int im)
        {
            id = im;
        }
        public void editarreservas()
        {
            Console.WriteLine("----vagas disponiveis----\n"+
                             $"esse eo id da vaga{id}"+
                              $"essa ea vaga disponivel{vagas}");
        }

    }
}
