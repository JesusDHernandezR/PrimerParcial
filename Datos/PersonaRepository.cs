using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class PersonaRepository
    {
        private string fileName = "Persona.txt";
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($" {persona.Nombre}; {persona.Sexo}; {persona.Edad}; {persona.DiasAfiliacion}; {persona.TipoAfiliacion}; {persona.LiquidacionDeAfiliacion}");
            writer.Close();
            file.Close();
        }

        //public List<Persona> ConsultarTodo()
        //{
        //    List<Persona> personas = new List<Persona>();
        //    string linea = string.Empty;
        //    FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
        //    StreamReader reader = new StreamReader(file);
        //    while ((linea = reader.ReadLine()) != null)
        //    {
        //        Map(personas, linea);
        //    }
        //    reader.Close();
        //    file.Close();
        //    return personas;
        //}
        //private static void Map(List<Persona> personas, string linea)
        //{
        //    Persona persona = new Persona();
        //    char delimitador = ';';
        //    string[] datos = linea.Split(delimitador);
        //    persona.Nombre = datos[0];
        //    persona.Identificacion = datos[1];
        //    persona.Sexo = datos[2];
        //    persona.Edad = int.Parse(datos[3]);
        //    persona.Pulsacion = Convert.ToDecimal(datos[4]);
        //    personas.Add(persona);
        //}
    }
}
