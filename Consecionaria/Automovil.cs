using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionaria
{
    internal class Automovil
    {
        public string matricula {get; set;}
        public int kilometraje { get; set;}
        public string modelo { get; set; }
        public string color {  get; set; }

        public Automovil(string matricula, int kilometraje, string modelo, string color)
        {
            this.matricula = matricula;
            this.kilometraje = kilometraje;
            this.modelo = modelo;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Automovil con matricula {matricula}, modelo {modelo}, color {color} y kilometraje {kilometraje}";
        }
    }
}
