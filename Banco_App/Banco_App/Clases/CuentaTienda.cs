using Banco_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_App.Clases
{
    class CuentaTienda : DatosCuentas
    {
        private List<CuentaBancaria> cuentaBanco;
        private double saldo_cuenta;
        private double porcentaje;
        private double nivel_tienda = 2;

        public CuentaTienda()
        {
            this.cuentaBanco = new List<CuentaBancaria>();
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.setNumeroCuenta(88299832);
            cuenta.setTipoCuenta("Ahorros");
            cuenta.setTitularCuenta("Celeste Santiago");
            this.cuentaBanco.Add(cuenta);
        }

        public double CalculodeValor(double saldo)
        {
            try
            {
                if(nivel_tienda == 1)
                {
                    porcentaje = 0.05;
                    double interes = saldo * porcentaje;
                    saldo_cuenta = saldo + interes;
                } else if(nivel_tienda == 2)
                {
                    porcentaje = 0.10;
                    double interes = saldo * porcentaje;
                    saldo_cuenta = saldo + interes;
                } else if(nivel_tienda == 3)
                {
                    porcentaje = 0.15;
                    double interes = saldo * porcentaje;
                    saldo_cuenta = saldo + interes;
                }
            } catch(Exception ex)
            {

            }
            return saldo_cuenta;
        }

        public List<CuentaBancaria> getAllCuentas()
        {
            return this.cuentaBanco;
        }
    }
}
