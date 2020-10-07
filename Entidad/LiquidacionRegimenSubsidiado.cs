using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionRegimenSubsidiado
    {
        Persona persona = new Persona();
        double valorUpc = 2000;
        double primaAdicional;
        public void CalculoRangoEdadSubsiado(Persona persona)
        {
            if (persona.Edad < 1)
            {
                primaAdicional = 2.0;
                MensajeCalculoSubsidiado(persona);
            }
            else if (persona.Edad > 1 && persona.Edad < 15)
            {
                primaAdicional = 0.8;
                MensajeCalculoSubsidiado(persona);
            }
            else if (persona.Edad > 16 && persona.Edad < 18)
            {
                primaAdicional = 0.3;
                MensajeCalculoSubsidiado(persona);
            }
            else if (persona.Edad > 19 && persona.Edad < 44)
            {
                primaAdicional = 1.0;
                MensajeCalculoSubsidiado(persona);
            }
            else if (persona.Edad > 45 && persona.Edad < 69)
            {
                primaAdicional = 2.5;
                MensajeCalculoSubsidiado(persona);
            }
            else
            {
                primaAdicional = 3.0;
                MensajeCalculoSubsidiado(persona);
            }
        }
        private void MensajeCalculoSubsidiado(Persona persona)
        {
            double liquidacionAfiliacion = persona.DiasAfiliacion * valorUpc * primaAdicional;
            Console.WriteLine($"Liquidacion contributiva: " + liquidacionAfiliacion);
        }
    }
}
