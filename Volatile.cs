﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Volatile : Animale,IVolante
    {
      public void Vola()
      {
            Console.WriteLine("Vola");
      }
    }
}
