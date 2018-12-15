using System;
using System.Linq;

namespace DatosEmpleado
{
    public class Empleado : Persona
    {
        #region Declaración de propiedades
        public int Codigo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SalarioBasico { get; set; }
        public string CargoEmpleado { get; set; }
        #endregion

        public Empleado()
        {
            this.Codigo = 0;
            
        }

        public Empleado(int codigo, DateTime fechaIngreso, double salarioBasico, string cargoEmpleado, 
                        string primerNombre, string segundoNombre, string primerApellido, 
                        string segundoApellido, DateTime fechaNacimiento, int edad, string cedula, string direccion)
        {
            this.Codigo = codigo;
            this.FechaIngreso = fechaIngreso;
            this.SalarioBasico = salarioBasico;
            this.CargoEmpleado = cargoEmpleado;
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Edad = edad;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }

        /// <summary>
        /// Calculando la edad de la persona a partir de su fecha de nacimiento.
        /// </summary>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona.</param>
        public static int calcularEdad(DateTime fechaNacimiento)
        {
            int edad = 0;
            edad = (DateTime.Now.Year - fechaNacimiento.Year);

            if (DateTime.Now.Month < fechaNacimiento.Month) {
                edad--;
            }
            else if ((DateTime.Now.Month == fechaNacimiento.Month) && (DateTime.Now.Day < fechaNacimiento.Day)) {
                edad--;
            }

            return edad;
        }

        /// <summary>
        /// Obtiene la información del empleado en una cadena. 
        /// </summary>
        /// <returns>Cadena completa con información del empleado.</returns>
        public string getInfoEmpleado()
        {
            return string.Format("Código de empleado: {0}\n Nombre: {1} {2} {3} {4}\n Fecha de Ingreso: {5}\n Salario básico: {6}", 
                this.Codigo, this.PrimerNombre, this.SegundoNombre, this.PrimerApellido, this.SegundoApellido,
                this.FechaIngreso.ToShortDateString(), this.SalarioBasico);
        }
    }
}
