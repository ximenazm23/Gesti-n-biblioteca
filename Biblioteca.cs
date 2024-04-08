using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallersgb_Ximena_zamudio
{
    public class Biblioteca
    {
        public Dictionary<string, Libro> Catalogo { get; private set; }
        public Dictionary<string, Usuario> Usuarios { get; private set; }

        public Biblioteca()
        {
            Catalogo = new Dictionary<string, Libro>();
            Usuarios = new Dictionary<string, Usuario>();


            AgregarLibro(new Libro("la liebre", "Carlos", "01/08/2010"));
            AgregarLibro(new Libro("el conejo", "Victor", "01/01/1990"));
            AgregarLibro(new Libro("la hoja", "Karina", "01/01/2018"));
        }

        public void AgregarLibro(Libro libro)
        {
            Catalogo.Add(libro.Titulo, libro);
        }

        public void MostrarCatalogo()
        {
            foreach (var libro in Catalogo.Values)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}");
                Console.WriteLine($"Autor: {libro.Autor}");
                Console.WriteLine($"Fecha: {libro.AñoPublicacion}");
                Console.WriteLine($"Disponible: {(libro.EstaDisponible() ? "Sí" : "No")}");
                Console.WriteLine();
            }
        }

        public bool PrestarLibro(string titulo)
        {
            if (Catalogo.ContainsKey(titulo))
            {
                Libro libro = Catalogo[titulo];
                if (libro.EstaDisponible())
                {
                    libro.Prestar();
                    return true;
                }
                else
                {
                    Console.WriteLine("El libro no está disponible para ser prestado.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("El libro no está en el catálogo.");
                return false;
            }
        }

        public void DevolverLibro(string titulo)
        {
            if (Catalogo.ContainsKey(titulo))
            {
                Libro libro = Catalogo[titulo];
                libro.Devolver();
            }
            else
            {
                Console.WriteLine("El libro no está en el catálogo.");
            }
        }

        public void AgregarUsuario(string nombreUsuario)
        {
            if (!Usuarios.ContainsKey(nombreUsuario))
            {
                Usuarios.Add(nombreUsuario, new Usuario(nombreUsuario));
                Console.WriteLine($"**********************\nUsuario '{nombreUsuario}' agregado exitosamente.\n**********************");
            }
            else
            {
                Console.WriteLine($"El usuario '{nombreUsuario}' ya existe en el sistema.");
            }
        }
    }
}
