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

            //the list with all the team
            List<SeleccionFutbol> selecion = new List<SeleccionFutbol>()
            {
                entrenador1, masajista1, masajista2, futbolista1, futbolista2, futbolista3
            };

            foreach (SeleccionFutbol person in selecion)
            {
                //to get the name of the person in the beginning
                Console.WriteLine(person.GetType().Name.ToUpper());
                Console.WriteLine(person.ToString());
                Console.WriteLine("**************************");
            }
            Console.WriteLine("Number of people in the team :" + selecion.Count());

            List<Entrenador> entrenadores = new List<Entrenador>()
            {
                entrenador1
            };

            foreach (Entrenador entrenador in entrenadores)
            {
                entrenador.ManageTraining();
                entrenador.Travel();
                break;
            };

            List<Futbolista> futbolistas = new List<Futbolista>()
            {
                futbolista1, futbolista2, futbolista3, futbolista4
            };

            foreach (Futbolista futbolista in futbolistas)
            {
                futbolista.GeneralTraining();
                futbolista.Travel();
                break;
            };

            List<Masajista> masajistas = new List<Masajista>()
            {
                masajista1, masajista2
            };

            foreach (Masajista masajista in masajistas)
            {
                masajista.GiveMassage();
                masajista.Travel();
                break;
            };

            //to clear the console before
            //Console.Clear();

            SelectedCountry country = new SelectedCountry("Rusia", selecion, 10);
           
            //country.AddParticipant(futbolista1);
            country.MostrarDatos(selecion);
            country.RemoveParticipant(futbolista2);
            country.MostrarDatos(selecion);
            country.PrepareMatch();
            country.PlayGame();
            // to show all of them
            //foreach (Entrenador entrenador in entrenadores)
            //{
            //    Console.WriteLine(entrenador.MostrarDatos());
            //}

            //foreach (Masajista masajista in masajistas)
            //{
            //    Console.WriteLine(masajista.MostrarDatos());
            //}

            //foreach (Futbolista futbolista in futbolistas)
            //{
            //    Console.WriteLine(futbolista.MostrarDatos());
            //}

            //code below does the same, but the one above is better.
            //masajista1.SetTravelling(true);
            //masajista1.SetTravelling(false);

            //it counts with the method GetCount();
            //Console.WriteLine("NUMBER OF PEOPLE " + SeleccionFutbol.GetCount());
            //Console.Clear();

            const int ADD = 1, REMOVE = 2, SHOWALL = 3, TRAINING = 4, GAME = 5;
            int option;

            do
            {
                Console.WriteLine("Choose a number from the menu.");
                Console.WriteLine("1 - Add person");
                Console.WriteLine("2 - Remove person");
                Console.WriteLine("3 - Show all members of the team");
                Console.WriteLine("4 - Train the team");
                Console.WriteLine("5 - Manage the game");

                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (option)
                {
                    case ADD:
                        // TODO: change below. Ask for a data
                        country.AddParticipant(futbolista2);
                        break;
                    case REMOVE:
                        // TODO: change below. Ask for a data
                        country.RemoveParticipant(futbolista1);
                        break;
                    case SHOWALL:
                        country.MostrarDatos(selecion);
                        break;
                    case TRAINING:
                        country.PrepareMatch();
                        break;
                    case GAME:
                        country.PlayGame();
                        break;


                }
            } while (option == 1 || option == 2 || option == 3 || option == 4 || option == 5);

            Console.ReadLine();
        }
    }
}
