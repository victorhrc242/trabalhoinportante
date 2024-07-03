using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoinportante
{
    public class cadastrarcliente
    {
        public string usuarioCliente { get; set; }
        public string senhacliente { get; set; }
        public string senha2 { get; set; }
        public int idade { get; set; }
        public int telefone { get; set; }

    public cadastrarcliente(string u,string s,string s2,int i,int t) { 
        
            usuarioCliente= u;
            senhacliente= s;
            senha2 = s2;
            idade= i;
            telefone= t;
        
        }
       



    }
}
