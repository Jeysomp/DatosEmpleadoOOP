namespace DatosEmpleado
{
    partial class frmDatosEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloLabel = new System.Windows.Forms.Label();
            this.datosPersonaleGroupBox = new System.Windows.Forms.GroupBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.numeroCedulaMTB = new System.Windows.Forms.MaskedTextBox();
            this.numeroCedulaLabel = new System.Windows.Forms.Label();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.edadLabel = new System.Windows.Forms.Label();
            this.fechaNacimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.fechaNacimientoLabel = new System.Windows.Forms.Label();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoLabel = new System.Windows.Forms.Label();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoLabel = new System.Windows.Forms.Label();
            this.segundoNombreTextBox = new System.Windows.Forms.TextBox();
            this.segundoNombreLabel = new System.Windows.Forms.Label();
            this.primerNombreTextBox = new System.Windows.Forms.TextBox();
            this.primerNombreLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.fechaIngresoDTP = new System.Windows.Forms.DateTimePicker();
            this.salarioBasicoLabel = new System.Windows.Forms.Label();
            this.salarioBasicoTextBox = new System.Windows.Forms.TextBox();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.verDetalleButton = new System.Windows.Forms.Button();
            this.datosPersonaleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(120, 31);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(207, 24);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Datos de empleados:";
            // 
            // datosPersonaleGroupBox
            // 
            this.datosPersonaleGroupBox.Controls.Add(this.direccionTextBox);
            this.datosPersonaleGroupBox.Controls.Add(this.direccionLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.numeroCedulaMTB);
            this.datosPersonaleGroupBox.Controls.Add(this.numeroCedulaLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.edadTextBox);
            this.datosPersonaleGroupBox.Controls.Add(this.edadLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.fechaNacimientoDTP);
            this.datosPersonaleGroupBox.Controls.Add(this.fechaNacimientoLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.segundoApellidoTextBox);
            this.datosPersonaleGroupBox.Controls.Add(this.segundoApellidoLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.primerApellidoTextBox);
            this.datosPersonaleGroupBox.Controls.Add(this.primerApellidoLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.segundoNombreTextBox);
            this.datosPersonaleGroupBox.Controls.Add(this.segundoNombreLabel);
            this.datosPersonaleGroupBox.Controls.Add(this.primerNombreTextBox);
            this.datosPersonaleGroupBox.Controls.Add(this.primerNombreLabel);
            this.datosPersonaleGroupBox.Location = new System.Drawing.Point(28, 80);
            this.datosPersonaleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.datosPersonaleGroupBox.Name = "datosPersonaleGroupBox";
            this.datosPersonaleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.datosPersonaleGroupBox.Size = new System.Drawing.Size(786, 240);
            this.datosPersonaleGroupBox.TabIndex = 1;
            this.datosPersonaleGroupBox.TabStop = false;
            this.datosPersonaleGroupBox.Text = "Datos personales:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(135, 175);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(633, 52);
            this.direccionTextBox.TabIndex = 15;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(23, 196);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(67, 17);
            this.direccionLabel.TabIndex = 14;
            this.direccionLabel.Text = "Dirección";
            // 
            // numeroCedulaMTB
            // 
            this.numeroCedulaMTB.Location = new System.Drawing.Point(172, 139);
            this.numeroCedulaMTB.Mask = "000-000000-0000A";
            this.numeroCedulaMTB.Name = "numeroCedulaMTB";
            this.numeroCedulaMTB.Size = new System.Drawing.Size(183, 23);
            this.numeroCedulaMTB.TabIndex = 13;
            // 
            // numeroCedulaLabel
            // 
            this.numeroCedulaLabel.AutoSize = true;
            this.numeroCedulaLabel.Location = new System.Drawing.Point(23, 142);
            this.numeroCedulaLabel.Name = "numeroCedulaLabel";
            this.numeroCedulaLabel.Size = new System.Drawing.Size(128, 17);
            this.numeroCedulaLabel.TabIndex = 12;
            this.numeroCedulaLabel.Text = "Número de cédula:";
            // 
            // edadTextBox
            // 
            this.edadTextBox.Location = new System.Drawing.Point(547, 101);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.ReadOnly = true;
            this.edadTextBox.Size = new System.Drawing.Size(99, 23);
            this.edadTextBox.TabIndex = 11;
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Location = new System.Drawing.Point(403, 107);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(45, 17);
            this.edadLabel.TabIndex = 10;
            this.edadLabel.Text = "Edad:";
            // 
            // fechaNacimientoDTP
            // 
            this.fechaNacimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimientoDTP.Location = new System.Drawing.Point(172, 102);
            this.fechaNacimientoDTP.Name = "fechaNacimientoDTP";
            this.fechaNacimientoDTP.Size = new System.Drawing.Size(183, 23);
            this.fechaNacimientoDTP.TabIndex = 9;
            this.fechaNacimientoDTP.ValueChanged += new System.EventHandler(this.fechaNacimientoDTP_ValueChanged);
            // 
            // fechaNacimientoLabel
            // 
            this.fechaNacimientoLabel.AutoSize = true;
            this.fechaNacimientoLabel.Location = new System.Drawing.Point(23, 104);
            this.fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            this.fechaNacimientoLabel.Size = new System.Drawing.Size(143, 17);
            this.fechaNacimientoLabel.TabIndex = 8;
            this.fechaNacimientoLabel.Text = "Fecha de nacimiento:";
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(547, 64);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(221, 23);
            this.segundoApellidoTextBox.TabIndex = 7;
            // 
            // segundoApellidoLabel
            // 
            this.segundoApellidoLabel.AutoSize = true;
            this.segundoApellidoLabel.Location = new System.Drawing.Point(403, 70);
            this.segundoApellidoLabel.Name = "segundoApellidoLabel";
            this.segundoApellidoLabel.Size = new System.Drawing.Size(122, 17);
            this.segundoApellidoLabel.TabIndex = 6;
            this.segundoApellidoLabel.Text = "Segundo apellido:";
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.Location = new System.Drawing.Point(135, 64);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(221, 23);
            this.primerApellidoTextBox.TabIndex = 5;
            // 
            // primerApellidoLabel
            // 
            this.primerApellidoLabel.AutoSize = true;
            this.primerApellidoLabel.Location = new System.Drawing.Point(23, 65);
            this.primerApellidoLabel.Name = "primerApellidoLabel";
            this.primerApellidoLabel.Size = new System.Drawing.Size(106, 17);
            this.primerApellidoLabel.TabIndex = 4;
            this.primerApellidoLabel.Text = "Primer apellido:";
            // 
            // segundoNombreTextBox
            // 
            this.segundoNombreTextBox.Location = new System.Drawing.Point(547, 25);
            this.segundoNombreTextBox.Name = "segundoNombreTextBox";
            this.segundoNombreTextBox.Size = new System.Drawing.Size(221, 23);
            this.segundoNombreTextBox.TabIndex = 3;
            // 
            // segundoNombreLabel
            // 
            this.segundoNombreLabel.AutoSize = true;
            this.segundoNombreLabel.Location = new System.Drawing.Point(403, 31);
            this.segundoNombreLabel.Name = "segundoNombreLabel";
            this.segundoNombreLabel.Size = new System.Drawing.Size(121, 17);
            this.segundoNombreLabel.TabIndex = 2;
            this.segundoNombreLabel.Text = "Segundo nombre:";
            // 
            // primerNombreTextBox
            // 
            this.primerNombreTextBox.Location = new System.Drawing.Point(135, 25);
            this.primerNombreTextBox.Name = "primerNombreTextBox";
            this.primerNombreTextBox.Size = new System.Drawing.Size(221, 23);
            this.primerNombreTextBox.TabIndex = 1;
            // 
            // primerNombreLabel
            // 
            this.primerNombreLabel.AutoSize = true;
            this.primerNombreLabel.Location = new System.Drawing.Point(23, 28);
            this.primerNombreLabel.Name = "primerNombreLabel";
            this.primerNombreLabel.Size = new System.Drawing.Size(105, 17);
            this.primerNombreLabel.TabIndex = 0;
            this.primerNombreLabel.Text = "Primer nombre:";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(51, 337);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(142, 17);
            this.codigoLabel.TabIndex = 16;
            this.codigoLabel.Text = "Código de empleado:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(199, 334);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(184, 23);
            this.codigoTextBox.TabIndex = 16;
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Location = new System.Drawing.Point(51, 376);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(122, 17);
            this.fechaIngresoLabel.TabIndex = 17;
            this.fechaIngresoLabel.Text = "Fecha de ingreso:";
            // 
            // fechaIngresoDTP
            // 
            this.fechaIngresoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngresoDTP.Location = new System.Drawing.Point(200, 370);
            this.fechaIngresoDTP.Name = "fechaIngresoDTP";
            this.fechaIngresoDTP.Size = new System.Drawing.Size(184, 23);
            this.fechaIngresoDTP.TabIndex = 18;
            // 
            // salarioBasicoLabel
            // 
            this.salarioBasicoLabel.AutoSize = true;
            this.salarioBasicoLabel.Location = new System.Drawing.Point(51, 410);
            this.salarioBasicoLabel.Name = "salarioBasicoLabel";
            this.salarioBasicoLabel.Size = new System.Drawing.Size(101, 17);
            this.salarioBasicoLabel.TabIndex = 19;
            this.salarioBasicoLabel.Text = "Salario básico:";
            // 
            // salarioBasicoTextBox
            // 
            this.salarioBasicoTextBox.Location = new System.Drawing.Point(200, 407);
            this.salarioBasicoTextBox.Name = "salarioBasicoTextBox";
            this.salarioBasicoTextBox.Size = new System.Drawing.Size(184, 23);
            this.salarioBasicoTextBox.TabIndex = 20;
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Location = new System.Drawing.Point(51, 450);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(135, 17);
            this.cargoLabel.TabIndex = 21;
            this.cargoLabel.Text = "Cargo del empleado";
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.Location = new System.Drawing.Point(200, 447);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(353, 23);
            this.cargoTextBox.TabIndex = 22;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(200, 504);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(112, 38);
            this.guardarButton.TabIndex = 23;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.Location = new System.Drawing.Point(364, 504);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(112, 38);
            this.cerrarButton.TabIndex = 24;
            this.cerrarButton.Text = "Cerrar";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // verDetalleButton
            // 
            this.verDetalleButton.Location = new System.Drawing.Point(575, 504);
            this.verDetalleButton.Name = "verDetalleButton";
            this.verDetalleButton.Size = new System.Drawing.Size(221, 38);
            this.verDetalleButton.TabIndex = 25;
            this.verDetalleButton.Text = "Visualizar detalle";
            this.verDetalleButton.UseVisualStyleBackColor = true;
            this.verDetalleButton.Click += new System.EventHandler(this.verDetalleButton_Click);
            // 
            // frmDatosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 554);
            this.Controls.Add(this.verDetalleButton);
            this.Controls.Add(this.cerrarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(this.cargoLabel);
            this.Controls.Add(this.salarioBasicoTextBox);
            this.Controls.Add(this.salarioBasicoLabel);
            this.Controls.Add(this.fechaIngresoDTP);
            this.Controls.Add(this.fechaIngresoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.datosPersonaleGroupBox);
            this.Controls.Add(this.tituloLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatosEmpleados";
            this.Text = "Empleado";
            this.datosPersonaleGroupBox.ResumeLayout(false);
            this.datosPersonaleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.GroupBox datosPersonaleGroupBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.Label primerApellidoLabel;
        private System.Windows.Forms.TextBox segundoNombreTextBox;
        private System.Windows.Forms.Label segundoNombreLabel;
        private System.Windows.Forms.TextBox primerNombreTextBox;
        private System.Windows.Forms.Label primerNombreLabel;
        private System.Windows.Forms.Label fechaNacimientoLabel;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.Label segundoApellidoLabel;
        private System.Windows.Forms.Label numeroCedulaLabel;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDTP;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.MaskedTextBox numeroCedulaMTB;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.DateTimePicker fechaIngresoDTP;
        private System.Windows.Forms.Label salarioBasicoLabel;
        private System.Windows.Forms.TextBox salarioBasicoTextBox;
        private System.Windows.Forms.Label cargoLabel;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.Button verDetalleButton;
    }
}

