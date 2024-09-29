using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04GestionDeAnimales
{
    public static class Almacen
    {
        static List<Animal> ListaAnimales = new List<Animal>();

        public static void agregarAnimal(Animal animal)
        {
            ListaAnimales.Add(animal);
        }

        public static void mostrarAnimalPorNombre(string nombre)
        {
            bool encontrado = false;

            foreach (Animal anim in ListaAnimales)
            {
                if (anim.Nombre == nombre)
                {
                    System.Console.WriteLine(anim);
                    encontrado = true;
                }
            }
            if (!encontrado) 
            {
                System.Console.WriteLine($"No se ha encontrado el animal llamado: {nombre}");
            }
            
        }
        public static void mostrarAnimales()
        {
            foreach (Animal anim in ListaAnimales)
            {

                System.Console.WriteLine(anim);

            }
        }
        public static void eliminarAnimalPorNombre(string nombre)
        {

            for (int i = 0; i < ListaAnimales.Count; i++)
            {
                {
                    if (ListaAnimales[i].Nombre == nombre)
                    {
                        System.Console.WriteLine($"Se a eliminado a {nombre} de forma permanente");
                        ListaAnimales.RemoveAt(i);
                    }
                }

            }
        }
    }
}
