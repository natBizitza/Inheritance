using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrenador entrenador1 = new Entrenador(1, "JUAN", "BILBAO", 45, "A");

            Masajista masajista1 = new Masajista(2, "JULIA", "CASTRO", 29, "JUNIOR", 5);
            Masajista masajista2 = new Masajista(3, "MARIA", "RODRIGUEZ", 40, "EXPERTA", 15);

            Futbolista futbolista1 = new Futbolista(4, "Álex", "Remiro", 30, 11,"DEFENSA" );
            Futbolista futbolista2 = new Futbolista(5, "Cristian", "Ganea", 27, 12, "DELANTERO");
            Futbolista futbolista3 = new Futbolista(6, "Unai", "Núñez", 25, 13, "PORTERO");
            Futbolista futbolista4 = new Futbolista(7, "Iñigo", "Martínez", 26, 14, "CENTRO CAMPISTA");

            //List<SeleccionFutbol> selecion = new List<SeleccionFutbol>();
            //{

            //};
            List<Entrenador> entrenadores = new List<Entrenador>()
            {
                entrenador1
            };
            List<Futbolista> futbolistas = new List<Futbolista>()
            {
                futbolista1, futbolista2, futbolista3, futbolista4
            };
            List<Masajista> masajistas = new List<Masajista>()
            {
                masajista1, masajista2
            };

            // to show all of them
            foreach (Entrenador entrenador in entrenadores)
            {
                Console.WriteLine(entrenador.MostrarDatos());
            }

            foreach (Masajista masajista in masajistas)
            {
                Console.WriteLine(masajista.MostrarDatos());
            }

            foreach (Futbolista futbolista in futbolistas)
            {
                Console.WriteLine(futbolista.MostrarDatos());
            }
            Console.ReadLine();

        }
    }
}
