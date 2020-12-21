using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Pesce : Animale,INutatore
    {
        public void Nuota()
        {
            Console.WriteLine("Nuota");
        }
    }
}
