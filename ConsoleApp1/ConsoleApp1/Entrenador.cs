using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Entrenador: SeleccionFutbol
    {
        private string idFederacion;
        private static int count = 0;

        //constructor
        public Entrenador(int id, string nombre, string apellidos, int edad, string idFederacion) : base(id, nombre, apellidos, edad)
        {
            this.idFederacion = idFederacion;
        }

        //Get & Set methods
        public string GetIdFederacion()
        {
            return this.idFederacion;
            count++;
        }

        public void SetIdFederacion(string idFederacion)
        {
            this.idFederacion = idFederacion;
        }

        //methods
        public void DirigirPartido()
        {

        }

        public void DirigirEntrenamiento()
        {

        }

        //public string MostrarDatos()
        //{
        //    string result = "";

        //    if (this.GetIdFederacion() != "")
        //    {
        //        result += "ID FEDERACION " + this.GetIdFederacion() + " ";
        //    }
        //    return "ENTRENADOR " + base.MostrarDatos() + result;
        //}

        public override string ToString()
        {
            return base.ToString() + "\nID Federation: " + idFederacion;
        }
    }
}
