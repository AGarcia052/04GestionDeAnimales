﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    abstract class Animal
    {

        string nombre;
        int edad;
        Color color;


        public abstract void hacerSonido();
        public abstract void dormir();
       

    }
}
