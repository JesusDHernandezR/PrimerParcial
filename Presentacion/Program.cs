using Entidad;
using Logica;
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
            string nombre;
            string sexo;
            int edad;
            int diasAfiliacion;
            string tipoAfiliacion ;

            var OP = "s";

            while (OP == "s")
            {
                int opcion;
                Console.WriteLine(" ____________________MENU___________________________________");
                Console.WriteLine("|1. REGISTRAR DATOS                                         |");
                Console.WriteLine("|2.                                                         |");
                Console.WriteLine("|3.                                                         |");
                Console.WriteLine("|4.                                                         | ");
                Console.WriteLine("|5.                                                         | ");
                Console.WriteLine("|6.                                                         | ");
                Console.WriteLine("|7. SALIR___________________________________________________| ");
                Console.WriteLine("DIGITE SU OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresar nombre: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingresar sexo: ");
                        sexo = Console.ReadLine();
                        Console.WriteLine("Ingresar edad: ");
                        edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar dias de afiliacion: ");
                        diasAfiliacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar tipo de afiliacion: ");
                        tipoAfiliacion = Console.ReadLine();


                        Persona persona = new Persona(nombre, sexo, edad, diasAfiliacion, tipoAfiliacion);
                        LiquidacionRegimenContributivo regimenContributivo = new LiquidacionRegimenContributivo();
                        LiquidacionRegimenSubsidiado regimenSubsidiado = new LiquidacionRegimenSubsidiado();
                        PersonaService personaService = new PersonaService();
                        string mensaje = personaService.Guardar(persona);
                        if (tipoAfiliacion.ToUpper().Equals("CONTRIBUTIVO"))
                        {
                            regimenContributivo.CalculoRangoEdadContributivo(persona);
                        }
                        else if (tipoAfiliacion.ToUpper().Equals("SUBSIDIADO"))
                        {
                            regimenSubsidiado.CalculoRangoEdadSubsiado(persona);
                        }
                        Console.WriteLine(mensaje);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
                do
                {
                    Console.WriteLine("desea seguir? s(si)/n(no): ");
                    OP = Console.ReadLine();
                } while (OP == "s" && OP != "s");
                if (OP == "s")
                {
                    Console.WriteLine("Presione ENTER para continuar");
                }
                else
                {
                    Console.WriteLine("Presione ENTER para Salir");
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("PRESIONE ENTER PARA SALIR");
            Console.ReadKey();
        }
    }
}
