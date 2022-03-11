using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecaBanco
{
    public partial class bancoUIForm : Form
    {
        protected int CuentaTextBox = 4; // numero de controles

        //  las constantes de la enumeracion especifican los indeices de los controles texbox
        public enum IndicesTextBox
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO, 
        }// FIN DE ENUM

        // construsctor sin parametros 
        public bancoUIForm()
        {
            InitializeComponent();
        }// fin del constructor

        // limpia todos los contrles textbox
        public void LimpiarControlesText()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i]; // obtiene el control 
                //determina si el control es TextBox
                if (miControl is TextBox)
                    miControl.Text = "";
            }// fin de for


        } //fin del metodo limpiar controles 

        // establece los valores de los controles textBox con el arreglo  string valores 
        public void EstablecerValoresControles(String[] valores)
        {
            //determinar si el arreglo string tiene la longitud correcta 
            if( valores .Length != CuentaTextBox)
            {
                throw (new ArgumentException("Debe haber " + (CuentaTextBox + 1) + "Objetos string en el arreglo "));
            }
            else
            {
                //establece el arreglo con los valores de los controles  TexBox
                txtCuenta.Text = valores[(int)IndicesTextBox.CUENTA];
                txtPrimerNombre.Text = valores[(int)IndicesTextBox.NOMBRE];
                txtNombrePaterno.Text = valores[(int)IndicesTextBox.APELLIDO];
                TxtSaldo.Text = valores[(int)IndicesTextBox.SALDO];

            }
        }// fin del metodo establecer valores controles text box 
        // devuelve los valores de los controles de texbox como un arreglo 

        public string[] IbtenerValoresControlesTextBox()
        {
            string[] valores = new string[CuentaTextBox];
            //copia  los campos de los controles

            valores[(int)IndicesTextBox.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTextBox.NOMBRE] = txtPrimerNombre.Text;

            valores[(int)IndicesTextBox.APELLIDO] = txtNombrePaterno.Text;
            valores[(int)IndicesTextBox.SALDO] = TxtSaldo.Text;
            
            return valores;
        }
        private void bancoUIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
