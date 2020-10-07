using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {

        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public int DiasAfiliacion { get; set; }
        public double LiquidacionDeAfiliacion { get; set; }
        public string TipoAfiliacion { get; set; }
        public Persona(string nombre, string sexo, int edad, int diasAfiliacion,string tipoAfiliacion)
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
            DiasAfiliacion = diasAfiliacion;
            TipoAfiliacion = tipoAfiliacion;
        }

        public Persona()
        {
        }
    }
}
