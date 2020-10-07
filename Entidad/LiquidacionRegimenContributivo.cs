using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionRegimenContributivo
    {
        
        double valorUpc = 2400;
        double primaAdicional;
        public void CalculoRangoEdadContributivo(Persona persona)
        {
            if (persona.Edad<1)
            {
                primaAdicional = 2.5;
                MensajeCalculoContributivo(persona);
            }
            else if (persona.Edad >= 1 && persona.Edad <= 15)
            {
                primaAdicional = 0.9;
                MensajeCalculoContributivo(persona);
            }
            else if (persona.Edad >= 16 && persona.Edad <= 18)
            {               
                primaAdicional = 0.3;
                MensajeCalculoContributivo(persona);
            }
            else if (persona.Edad >= 19 && persona.Edad <= 44)
            {
                primaAdicional = 1.5;
                MensajeCalculoContributivo(persona);
            }
            else if (persona.Edad > 45 && persona.Edad < 69)
            {
                primaAdicional = 3.0;
                MensajeCalculoContributivo(persona);
            }
            else
            {
                primaAdicional = 3.5;
                MensajeCalculoContributivo(persona);

            }
        }

        private void MensajeCalculoContributivo(Persona persona)
        {
            double liquidacionAfiliacion = persona.DiasAfiliacion * valorUpc * primaAdicional;
            Console.WriteLine($"Liquidacion contributiva: " + liquidacionAfiliacion);
        }


        //public void CalcularLiquidacionAfiliacion(Persona persona)
        //{
        //    double liquidacionAfiliacion = persona.DiasAfiliacion * valorUpc * primaAdicional;
        //    Console.WriteLine($"Liquidacion contributiva: " + liquidacionAfiliacion);
        //}
    }
}
