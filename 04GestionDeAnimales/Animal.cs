using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    public abstract class Animal
    {

       

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Color Color { get; set; }

        public Animal(string nombre, int edad, Color color)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Color = color;
        }

        public abstract void hacerSonido();
        public abstract void dormir();
       

    }
}
