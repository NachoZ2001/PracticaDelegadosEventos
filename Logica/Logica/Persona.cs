namespace Logica
{
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
                this.NombreModificado(this, new NombresEventArgs { NombreAntiguo = nombreAnterior, NombreModificado = nuevoNombre});
            }
            return true;
        }
    }
    public class NombresEventArgs : EventArgs
    {
        public string NombreAntiguo { get; set;}
        public string NombreModificado { get; set; }
    }
}