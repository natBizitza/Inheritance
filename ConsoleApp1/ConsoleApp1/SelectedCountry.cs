using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SelectedCountry
    {
        private string countryName;
        private List<SeleccionFutbol>particapants;
        private int actualNumberPlayers;
        private static int numeroEntrenador, numeroMasajista;

        //constructor
        public SelectedCountry(string countryName, List<SeleccionFutbol> participants, int actualNumberPlayers)
        {
            this.countryName = countryName;
            particapants = new List<SeleccionFutbol>();
            this.actualNumberPlayers = actualNumberPlayers;
        }

        //Get & Set
        public string GetCountryName()
        {
           return this.countryName;
        }

        public void SetCountryName(string countryName)
        {
           this.countryName = countryName;
        }

        public int GetActualNumberPlayers()
        {
           return  this.actualNumberPlayers;
        }

        public void SetActualNumberPlayers(int actualNumberPlayers)
        {
            this.actualNumberPlayers = actualNumberPlayers;
        }

        //Es un getter para que te devuelva la lista de CocheSimple
        public List<SeleccionFutbol> GetParticipants()
        {
            return particapants;
        }

        //MostrarDatosSelección(): Displays the name of the country, the number of members and their data.

        public string MostrarDatos()
        {
            string result = "";

            if (this.GetCountryName() != "")
            {
                result += "COUNTRY NAME: " + this.GetCountryName() + " ";
            }
            if (this.GetActualNumberPlayers() != 0)
            {
                result += "YEARS OF EXPERIENCE " + this.GetActualNumberPlayers() + " ";
            }
            return result;
        }

        //Este metodo recibe un objeto del tipo CocheSimple(puede ser: taxi, autobus o cochesimple) y lo añade a la lista
        public void AddParticipant(SeleccionFutbol participant)
        {
            if (MaximumParticipant(participant))
            {
                if (participant.GetType().Name == "Entrenador")
                {
                    numeroEntrenador++;
                }
                else if (participant.GetType().Name == "Masajista")
                {
                    numeroMasajista++;
                }

                particapants.Add(participant);
            }
        }

        //boolean AltaSeleccion ( ) Allowed if there is room , to enlist a new member and
        public Boolean MaximumParticipant(SeleccionFutbol participant)
        {
            if (particapants.Count < 10)
            {
                if (participant.GetType().Name == "Masajista" && numeroMasajista < 4)
                {
                    Console.WriteLine("One more masseur is in the team");
                    return true;
                }
                else if (participant.GetType().Name == "Entrenador" && numeroEntrenador < 2)
                {
                    Console.WriteLine("One more trainer is in the team");
                    return true;
                }
                else if (participant.GetType().Name == "Futbolista")
                {
                    Console.WriteLine("One more player is in the team");
                    return true;
                }
            }
            return false;
        }
    }
}
