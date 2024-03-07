using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionaria
{
    internal class Consecionaria
    {
        public List<Automovil> Catalogo {  get; set; }
        public int CantidadAutos {  get; set; }
        public int MaxAutos {  get; set; }

        public Consecionaria()
        {
            Catalogo = new List<Automovil>();
            CantidadAutos = 0;
            MaxAutos = 10;
        }

        public void agregarAuto(Automovil auto)
        {
            if(CantidadAutos < MaxAutos)
            {
                CantidadAutos++;
                Catalogo.Add(auto);
            }
            else
            {
                Console.WriteLine("La consecionaria esta llena");
            }
            
        }
        public void eliminarAuto(string matricula)
        {
            Automovil? autoencontrado = Catalogo.Find((auto)=> auto.matricula == matricula);
            
            if(autoencontrado != null)
            {
                Catalogo.Remove(autoencontrado);
                Console.WriteLine("Auto eliminado correctamente.");
                CantidadAutos--;
            }
            else
            {
                Console.WriteLine("Auto no encontrado.");
            }
            
        }
        public void mostrarAutos()
        {
            foreach(Automovil auto in Catalogo)
            {
                Console.WriteLine(auto.ToString());
            }
        }
    }
}
