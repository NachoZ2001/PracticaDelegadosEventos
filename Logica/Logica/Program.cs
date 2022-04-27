using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Program
    {
        static void Main(string [] args)
        {
            Persona persona = new Persona("Pedro");
            persona.ActualizarNombre("Ignacio");
            persona.NombreModificado += Logger.ImprimirEnConsola;
            persona.NombreModificado += CalculoLetras.CalcularLetras;
            Console.Read();
        }
 
    }
}
