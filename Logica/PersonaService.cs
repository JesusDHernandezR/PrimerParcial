using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class PersonaService
    {
        PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public string Guardar(Persona persona)
        {
            try
            {
                personaRepository.Guardar(persona);
                return "SE HA GUARDADO CORRECTAMENTE";
            }
            catch (Exception e)
            {
                return "error " + e.Message;
            }
        }
    }
}
