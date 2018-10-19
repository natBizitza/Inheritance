using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SeleccionFutbol
    {
        private int id;
        private string nombre;
        private string apellidos;
        private int edad;
        private static int count = 0;

        //constructor
        public SeleccionFutbol(int id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            count++;
        }

        //Get & Set()
        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetApellidos()
        {
            return this.apellidos;
        }

        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public int GetEdad()
        {
            return this.edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        //methods
        public void Concentrarse()
        {

        }

        public void Viajar()
        {

        }

        public string MostrarDatos()
        {
            string result = "";

            if (this.GetId() > 0)
            {
               result += "ID " + this.GetId() + " ";
            }
            if (this.GetNombre() !="")
            {
                result += "NOMBRE " + this.GetNombre() + " ";
            }
            if (this.GetApellidos() != "")
            {
                result += "APELLIDOS " + this.GetApellidos() + " ";
            }
            if (this.GetEdad() > 0)
            {
                result += "EDAD " + this.GetEdad() + " ";
            }

            return result;
        }

        public void contador()
        {
            GetId();
            int result = count++;
            Console.WriteLine("NUMBER OF PEOPLE " + result);
        }
    }
}
