using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logger
    {
        public static void ImprimirEnConsola(object? sender, NombresEventArgs nombres)
        {
            Console.WriteLine($"El nombre fue modificado de {nombres.NombreAntiguo} a {nombres.NombreModificado}");
        }
    }
}
