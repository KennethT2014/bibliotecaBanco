
namespace bibliotecaBanco
{
    partial class bancoUIForm
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
            if (disposing && (components != null))
            {
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
            this.lblcuenta = new System.Windows.Forms.Label();
            this.lblprimernombre = new System.Windows.Forms.Label();
            this.lblapellidopaterno = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtNombrePaterno = new System.Windows.Forms.TextBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Location = new System.Drawing.Point(66, 29);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(41, 13);
            this.lblcuenta.TabIndex = 0;
            this.lblcuenta.Text = "Cuenta";
            // 
            // lblprimernombre
            // 
            this.lblprimernombre.AutoSize = true;
            this.lblprimernombre.Location = new System.Drawing.Point(66, 67);
            this.lblprimernombre.Name = "lblprimernombre";
            this.lblprimernombre.Size = new System.Drawing.Size(73, 13);
            this.lblprimernombre.TabIndex = 1;
            this.lblprimernombre.Text = "primer nombre";
            // 
            // lblapellidopaterno
            // 
            this.lblapellidopaterno.AutoSize = true;
            this.lblapellidopaterno.Location = new System.Drawing.Point(66, 97);
            this.lblapellidopaterno.Name = "lblapellidopaterno";
            this.lblapellidopaterno.Size = new System.Drawing.Size(84, 13);
            this.lblapellidopaterno.TabIndex = 2;
            this.lblapellidopaterno.Text = "Apellido Paterno";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(66, 169);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(34, 13);
            this.lblsaldo.TabIndex = 3;
            this.lblsaldo.Text = "Saldo";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(182, 29);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtCuenta.TabIndex = 4;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(182, 67);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // txtNombrePaterno
            // 
            this.txtNombrePaterno.Location = new System.Drawing.Point(182, 97);
            this.txtNombrePaterno.Name = "txtNombrePaterno";
            this.txtNombrePaterno.Size = new System.Drawing.Size(124, 20);
            this.txtNombrePaterno.TabIndex = 6;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(182, 162);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(116, 20);
            this.TxtSaldo.TabIndex = 7;
            // 
            // bancoUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 296);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.txtNombrePaterno);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.lblapellidopaterno);
            this.Controls.Add(this.lblprimernombre);
            this.Controls.Add(this.lblcuenta);
            this.Name = "bancoUIForm";
            this.Text = "bancoUIForm";
            this.Load += new System.EventHandler(this.bancoUIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.Label lblprimernombre;
        private System.Windows.Forms.Label lblapellidopaterno;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtNombrePaterno;
        private System.Windows.Forms.TextBox TxtSaldo;
    }
}