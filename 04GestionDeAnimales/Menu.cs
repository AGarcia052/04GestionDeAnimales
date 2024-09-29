using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    public class Menu
    {

        public static void mostrarMenu()
        {
            int eleccion;
            bool continuar = true;
            do
            {
                System.Console.WriteLine("Elige una de las siguientes opciones:");
                System.Console.WriteLine("1. Añadir perro a la colección");
                System.Console.WriteLine("2. Añadir gato a la colección");
                System.Console.WriteLine("3. Mostrar todos los animales");
                System.Console.WriteLine("4. Buscar animal por su nombre");
                System.Console.WriteLine("5. Eliminar animal por su nombre");
                System.Console.WriteLine("6. Salir");

                int.TryParse(System.Console.ReadLine(), out eleccion);

                switch(eleccion)
                {
                    case 1:
                        opcionUno();
                        break;
                    case 2:
                        opcionDos();
                        break;
                    case 3:
                        Almacen.mostrarAnimales();
                        break;
                    case 4:
                        opcionCuatro();
                        break;
                    case 5:
                        opcionCinco();
                        break;
                    case 6:
                        continuar = false;
                        break;
                }

            } while (continuar);


            
        }

        public static void opcionUno()
        {
            string nombre;
            int edad;
            Color color;
            string colorAux;
            string raza;

            System.Console.WriteLine("Nombre: ");
            nombre = System.Console.ReadLine();

            do
            {
                System.Console.WriteLine("Edad: ");
                int.TryParse(System.Console.ReadLine(), out edad);
            } while (edad < 0 || edad > 30);
            

            System.Console.WriteLine("Color: ");
            colorAux = System.Console.ReadLine().ToUpper();

            if (!Enum.TryParse(colorAux, out color))
                color = Color.NEGRO;

            System.Console.WriteLine("Raza: ");
            raza = System.Console.ReadLine();


            Almacen.agregarAnimal(new Perro(nombre, edad, color, raza));

        }
        public static void opcionDos()
        {
            string nombre;
            int edad;
            Color color;
            string colorAux;
            bool tieneManchas;
            int tieneManchasAux;

            System.Console.WriteLine("Nombre: ");
            nombre = System.Console.ReadLine();

            do
            {
                System.Console.WriteLine("Edad: ");
                int.TryParse(System.Console.ReadLine(), out edad);
            } while (edad < 0 || edad > 30);


            System.Console.WriteLine("Color: ");
            colorAux = System.Console.ReadLine().ToUpper();

            if (!Enum.TryParse(colorAux, out color))
                color = Color.NEGRO;

            do
            {
                System.Console.WriteLine("Tiene manchas: (si tiene manchas: 1, si no tiene manchas: 2)");
                int.TryParse(System.Console.ReadLine(), out tieneManchasAux);
            } while (tieneManchasAux < 0 || tieneManchasAux > 2);

            if (tieneManchasAux == 1)
            {
                tieneManchas = true;
            }
            else tieneManchas = false;


            Almacen.agregarAnimal(new Gato(nombre, edad, color, tieneManchas));
        }
        public static void opcionCuatro()
        {
            string nombre;
            System.Console.WriteLine("Nombre del animal: ");
            nombre = System.Console.ReadLine();
            Almacen.mostrarAnimalPorNombre(nombre);
        }
        public static void opcionCinco()
        {
            string nombre;
            System.Console.WriteLine("Nombre del animal: ");
            nombre = System.Console.ReadLine();
            Almacen.eliminarAnimalPorNombre(nombre);
        }

    }
}
