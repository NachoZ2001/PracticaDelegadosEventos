using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CalculoLetras
    {
        public static void CalcularLetras(object? sender, NombresEventArgs nombres)
        {
            int cont = 0;
            foreach (char letraNombreModificado in nombres.NombreModificado)
            {
                int ban = 0;
                foreach (char letraNombreAntiguo in nombres.NombreAntiguo)
                {
                    if (letraNombreModificado == letraNombreAntiguo)
                    {
                        ban = 1;
                    }
                }
                if (ban == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
        }
    }
}
