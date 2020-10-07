using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre = "jesus";
            string sexo = "m";
            int edad = 56;
            int diasAfiliacion = 5;
            string tipoAfiliacion = "Subsidiado";
            Persona persona = new Persona(nombre,sexo,edad,diasAfiliacion,tipoAfiliacion);
            LiquidacionRegimenContributivo regimenContributivo = new LiquidacionRegimenContributivo();
            LiquidacionRegimenSubsidiado regimenSubsidiado = new LiquidacionRegimenSubsidiado();
            if (tipoAfiliacion.ToUpper().Equals("CONTRIBUTIVO"))
            {
                regimenContributivo.CalculoRangoEdadContributivo(persona);
            }
            else if(tipoAfiliacion.ToUpper().Equals("SUBSIDIADO"))
            {
                regimenSubsidiado.CalculoRangoEdadSubsiado(persona);
            }
            
            
            Console.ReadKey();
        }
    }
}
