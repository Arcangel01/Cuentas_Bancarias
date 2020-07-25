using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_App.Clases
{
    class CuentaBancaria
    {
        private int numero_cuenta;
        private string tipo_cuenta;
        private string titular_cuenta;

        public int getNumeroCuenta()
        {
            return numero_cuenta;
        }

        public void setNumeroCuenta(int numero_cuenta)
        {
            this.numero_cuenta = numero_cuenta;
        }

        public string getTipoCuenta()
        {
            return tipo_cuenta;
        }

        public void setTipoCuenta(string tipo_cuenta)
        {
            this.tipo_cuenta = tipo_cuenta;
        }

        public string getTitularCuenta()
        {
            return titular_cuenta;
        }

        public void setTitularCuenta(string titular_cuenta)
        {
            this.titular_cuenta = titular_cuenta;
        }

        public void muestraCuentas()
        {
            Console.WriteLine("Numero de cuenta: " + this.numero_cuenta + ".");
            Console.WriteLine("Tipo de cuenta: " + this.tipo_cuenta + ".");
            Console.WriteLine("Titular de la cuenta: " + this.titular_cuenta + ".");
        }
    }
}
