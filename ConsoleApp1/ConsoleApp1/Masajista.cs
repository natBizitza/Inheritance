using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Masajista : SeleccionFutbol
    {
        private string titulacion;
        private int yearsOfExperience;
        private bool massage;

        //constructor
        public Masajista(int id, string nombre, string apellidos, int edad, string titulacion, int yearsOfExperience) : base(id, nombre, apellidos, edad)
        {
            this.titulacion = titulacion;
            this.yearsOfExperience = yearsOfExperience;

        }

        //Get & Set methods
        public string GetTitulacion()
        {
            return this.titulacion;
        }

        public void SetTitulacion(string titulacion)
        {
            this.titulacion = titulacion;
        }

        public int GetYearsOfExperience()
        {
            return this.yearsOfExperience;
        }

        public void SetYearsOfExperience(int yearsOfExperience)
        {
            this.yearsOfExperience = yearsOfExperience;
        }

        //methods
        public void GiveMassage()
        {
            Console.WriteLine("Masseur is giving massage");
            this.massage = true;
        }

        public void EndMassage()
        {
            Console.WriteLine("Masseur is not giving massage");
            this.massage = false;
        }

        //public string MostrarDatos()
        //{
        //    string result = "";

        //    if (this.GetTitulacion() != "")
        //    {
        //        result += "TITULACION " + this.GetTitulacion() + " ";
        //    }
        //    if (this.GetYearsOfExperience() != 0)
        //    {
        //        result += "YEARS OF EXPERIENCE " + this.GetYearsOfExperience() + " ";
        //    }
        //    return "MASAJISTA " + base.MostrarDatos() + result;
        //}

        public override string ToString()
        {
            return base.ToString() + "\nTitel: " + titulacion + "\nYears of experience:" + yearsOfExperience;
        }
    }
}
