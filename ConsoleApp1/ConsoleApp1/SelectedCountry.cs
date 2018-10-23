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
        private List<SeleccionFutbol>participants;
        private int actualNumberPlayers;
        private static int numeroEntrenador, numeroMasajista;

        //constructon
        public SelectedCountry(string countryName, List<SeleccionFutbol> participants, int actualNumberPlayers)
        {
            this.countryName = countryName;
            this.participants = participants;
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
            return participants;
        }
    
        //MostrarDatosSelección(): Displays the name of the country, the number of members and their data.

        public string MostrarDatos(List<SeleccionFutbol> participants)
        {
            string result = "";

            if (this.GetCountryName() != "")
            {
                result += "COUNTRY NAME: " + this.GetCountryName() + " ";
            }
            if (this.GetActualNumberPlayers() != 0)
            {
                result += "NUMBER OF PLAYERS " + SeleccionFutbol.GetCount() + " ";
            }
            Console.WriteLine(result);

            foreach (SeleccionFutbol person in participants)
            {
                //to get the name of the person in the beginning
                Console.WriteLine(person.GetType().Name.ToUpper());
                Console.WriteLine(person.ToString());
                Console.WriteLine("**************************");
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

                participants.Add(participant);
            }
        }

        //boolean AltaSeleccion ( ) Allowed if there is room , to enlist a new member and
        public Boolean MaximumParticipant(SeleccionFutbol participant)
        {
            if (participants.Count < 30)
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

        //boolean BajaSeleccion( ) calls for the id of the member to terminate, if it exists is removed by moving 
        //the list of participants and updating counters. Returns true if it has been unable to complete operation, 
        //false otherwise.

        public Boolean MinimumParticipant(SeleccionFutbol participant)
        {
            int id;
            Console.WriteLine("Introduce ID.");
            id = Convert.ToInt32(Console.ReadLine());

            foreach (SeleccionFutbol x in participants)
            {
                if (participants.Count() != 0)
                {
                    if (participant.GetId() ==id)
                    {
                        Console.WriteLine("\n***********Participant was successfully removed**********");
                        return true;
                    }
                }
            }
            Console.WriteLine("There is no participant with that ID");
            return false;
        }

        //to remove participant
        public void RemoveParticipant(SeleccionFutbol participant)
        {
            if (MinimumParticipant(participant))
            {
                if ((participant.GetId()).GetType().Name == "Entrenador")
                {
                    numeroEntrenador--;
                }
                else if ((participant.GetId()).GetType().Name == "Masajista")
                {
                    numeroMasajista--;
                }

                participants.Remove(participant);
            }
        }
    }
}
