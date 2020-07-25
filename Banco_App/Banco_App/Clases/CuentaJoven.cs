using Banco_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_App.Clases
{
    class CuentaJoven : DatosCuentas
    {
        private List<CuentaBancaria> cuentaBanco;
        private double saldo_cuenta;
        private double porcentaje_interes = 0.10;

        public CuentaJoven()
        {
            this.cuentaBanco = new List<CuentaBancaria>();
            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.setNumeroCuenta(0092832);
            cuenta.setTipoCuenta("Corriente");
            cuenta.setTitularCuenta("Mario Cimarro");
            this.cuentaBanco.Add(cuenta);

        }

        public double CalculodeValor(double saldo)
        {
            double interes = saldo * porcentaje_interes;
            saldo_cuenta = saldo + interes;
            return saldo_cuenta;
        }

        public List<CuentaBancaria> getAllCuentas()
        {
            return this.cuentaBanco;
        }
    }
}
