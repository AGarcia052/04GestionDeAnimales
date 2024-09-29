using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04GestionDeAnimales
{
    public class Perro: Animal
    {
        
        string Raza {  get; set; }

        public Perro(string nombre, int edad, Color color, string raza) : base(nombre, edad, color)
        {
            this.Raza = raza;
        }

        public override void dormir()
        {
            System.Console.WriteLine("El perro está durmiendo");
        }

        public override void hacerSonido()
        {
            System.Console.WriteLine($"{Nombre}, está ladrando");
        }
    }
}
