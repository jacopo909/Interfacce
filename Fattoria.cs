using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Fattoria
    {
        private List<Animale> animali = new List<Animale>();
        public void Adotta(Animale a)
        {
            animali.Add(a);
            if(a is INutatore)
            {
                Console.WriteLine("Hai addotatto un pesce");
            }
            if(a is IVolante)
            {
                Console.WriteLine("Hai adottato un volatile");
            }
        }
    }
}
