using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    
    abstract class Animale : ISalutatore
    {
        Fattoria f = new Fattoria();
        protected string nome;
        public string Nome { get; set; }
        
        public string Saluta()
        {
            return "Ciao";
        }
    }
}
