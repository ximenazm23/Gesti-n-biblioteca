using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallersgb_Ximena_zamudio
{
    public class Libro
    {
        public Libro(string titulo, string autor, string añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Disponible = true;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string AñoPublicacion { get; set; }
        public bool Disponible { get; private set; }

        // Método para prestar el libro
        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false; // Marcar el libro como no disponible cuando se presta
                Console.WriteLine($"\nEl libro '{Titulo}' ha sido prestado.\n\n**********************");
            }
            else
            {
                Console.WriteLine($"\nEl libro '{Titulo}' no está disponible para ser prestado.");
            }
        }

        // Método para devolver el libro
        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine($"\nEl libro '{Titulo}' ha sido devuelto.\n****************");
            }
            else
            {
                Console.WriteLine($"\nEl libro '{Titulo}' ya está disponible.\n");
            }
        }

        // Método para verificar si el libro está disponible

        public bool EstaDisponible()
        {
            return Disponible;
        }
    }
}
