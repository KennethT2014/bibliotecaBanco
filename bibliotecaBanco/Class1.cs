using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaBanco
{
    public class Class1
    {
        public class Registro
        {
            private int cuenta;
            private string primernombre;
            private string apellidoPaterno;
            private decimal saldo;


            public Registro() : this(0, "", "", 0.0M)
            {

            }
            // el contructor sobrecargado, establece los miembros a los valores de los parametros 
            public Registro(int valorcuenta, string valorPrimerNombrem, String valorApellidoPaterno, decimal valorSaldo)
            {
                cuenta = valorcuenta;
                primernombre = valorPrimerNombrem;
                apellidoPaterno = valorApellidoPaterno;
                saldo = valorSaldo;
            }
            public int Cuenta { get => cuenta; set => cuenta = value; }
            public string PrimerNombre { get => primernombre; set => primernombre = value; }
            public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
            public decimal Saldo { get => saldo; set => saldo = value; }
        }
    }
}
