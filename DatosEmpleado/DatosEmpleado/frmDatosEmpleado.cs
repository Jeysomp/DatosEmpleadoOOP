using System;
using System.Windows.Forms;

namespace DatosEmpleado
{
    public partial class frmDatosEmpleados : Form
    {
        Empleado empleado;

        public frmDatosEmpleados()
        {
            InitializeComponent();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (this.Validate()) {
                empleado = new Empleado(Convert.ToInt32(codigoTextBox.Text), fechaIngresoDTP.Value, Double.Parse(salarioBasicoTextBox.Text), cargoTextBox.Text, primerNombreTextBox.Text, segundoNombreTextBox.Text,
                                        primerApellidoTextBox.Text, segundoApellidoTextBox.Text, fechaNacimientoDTP.Value, Int32.Parse(edadTextBox.Text), numeroCedulaMTB.Text, direccionTextBox.Text);
            }
        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Datos de empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void verDetalleButton_Click(object sender, EventArgs e)
        {
            if (empleado != null) {
                MessageBox.Show(empleado.getInfoEmpleado(), "Datos de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("No se encontraron datos de empleados, favor presionar el boton de \"Guardar\"", "Datos de empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fechaNacimientoDTP_ValueChanged(object sender, EventArgs e)
        {
            edadTextBox.Text = Empleado.calcularEdad(fechaNacimientoDTP.Value).ToString();
        }
    }
}
