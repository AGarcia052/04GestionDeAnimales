using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    public class Gato : Animal
    {

        bool TieneManchas {  get; set; }

        public Gato(string nombre, int edad, Color color, bool tieneManchas) : base(nombre, edad, color)
        { 
            this.TieneManchas = tieneManchas;
        }

        public override void dormir()
        {
            System.Console.WriteLine("El gato está durmiendo");
        }

        public override void hacerSonido()
        {
            System.Console.WriteLine($"{Nombre}, está maullando");
        }

        public override string ToString()
        {
            if (TieneManchas)
            {
                return $"Gato(nombre: {Nombre}, edad: {Edad}, color: {Color}, tiene manchas: si)";
            }
            else 
            {
                return $"Gato(nombre: {Nombre}, edad: {Edad}, color: {Color}, tiene manchas: no)";

            }

        }
    }
}
