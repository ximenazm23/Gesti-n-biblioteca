using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tallersgb_Ximena_zamudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            Console.WriteLine("Bienvenidos a la biblioteca:\n");

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:\n");
                Console.WriteLine("1. Mostrar catálogo");
                Console.WriteLine("2. Prestar libro");
                Console.WriteLine("3. Devolver libro");
                Console.WriteLine("4. Agregar usuario");
                Console.WriteLine("5. Salir\n");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("**********************\nMostrar catálogo:\n");
                        biblioteca.MostrarCatalogo();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el título del libro que desea prestar:");
                        string tituloPrestamo = Console.ReadLine();
                        biblioteca.PrestarLibro(tituloPrestamo);
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el título del libro que desea devolver:");
                        string tituloDevolucion = Console.ReadLine();
                        biblioteca.DevolverLibro(tituloDevolucion);
                        break;
                    case "4":
                        Console.WriteLine("**********************\nIngrese el nombre del usuario que desea agregar:");
                        string nombreUsuario = Console.ReadLine();
                        biblioteca.AgregarUsuario(nombreUsuario);
                        break;
                    case "5":
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}