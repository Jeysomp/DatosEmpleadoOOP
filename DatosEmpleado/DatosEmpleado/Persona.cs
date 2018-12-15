using System;

namespace DatosEmpleado
{
    public class Persona
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
    }
}
