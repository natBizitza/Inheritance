using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Futbolista : SeleccionFutbol
    {
        private int dorsal;
        private string demarcacion;

        //constructor
        public Futbolista(int id, string nombre, string apellidos, int edad, int dorsal, string demarcacion) : base(id, nombre,apellidos, edad)
        {
            this.dorsal = dorsal;
            this.demarcacion = demarcacion;
        }

        //Get & Set methods
        public int GetDorsal()
        {
            return this.dorsal;
        }

        public void SetDorsal(int dorsal)
        {
            this.dorsal = dorsal;
        }

        public string GetDemarcacion()
        {
            return this.demarcacion;
        }

        public void SetDemarcacion(string demarcacion)
        {
            this.demarcacion = demarcacion;
        }

        //methods
        public void JugarPartido()
        {

        }

        public void Entrenar()
        {

        }

        public string MostrarDatos()
        {
            string result = "";

            if (this.GetDorsal() > 0)
            {
                result += "DORSAL " + this.GetDorsal() + " ";
            }
            if (this.GetDemarcacion()!= "")
            {
                result += "DEMARCACION " + this.GetDemarcacion() + " ";
            }
            return "FUTBOLISTA " + base.MostrarDatos() + result;
        }
    }
}
