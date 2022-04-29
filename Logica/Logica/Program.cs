using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

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
                Console.WriteLine($"La cantidad de letras que tiene el nuevo nombre que el anterior no tiene son {cont}");
            }
        }

        public class Logger
        {
            public static void ImprimirEnConsola(object? sender, NombresEventArgs nombres)
            {
                Console.WriteLine($"El nombre fue modificado de {nombres.NombreAntiguo} a {nombres.NombreModificado}");
            }
        }

        public class Persona
        {
            public EventHandler<NombresEventArgs> NombreModificado;
            private string Nombre { get; set; }

            public Persona() { }
            public Persona(string Nombre)
            {
                this.Nombre = Nombre;
            }
            public bool ActualizarNombre(string nuevoNombre)
            {
                string nombreAnterior = Nombre;
                Nombre = nuevoNombre;
                if (this.NombreModificado != null)
                {
                    this.NombreModificado(this, new NombresEventArgs { NombreAntiguo = nombreAnterior, NombreModificado = nuevoNombre });
                }
                return true;
            }
        }
        public class NombresEventArgs : EventArgs
        {
            public string NombreAntiguo { get; set; }
            public string NombreModificado { get; set; }
        }
    
}
