﻿using Banco_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_App.Clases
{
    class CuentaEmpresarial : DatosCuentas
    {
        private List<CuentaBancaria> cuentaBanco;
        private double saldo_cuenta;
        private double porcentaje_interes;

        public CuentaEmpresarial()
        {
            this.cuentaBanco = new List<CuentaBancaria>();
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.setNumeroCuenta(4839);
            cuenta.setTipoCuenta("Ahorros");
            cuenta.setTitularCuenta("Martin Caceres");
            this.cuentaBanco.Add(cuenta);
        }

        public double CalculodeValor(double saldo)
        {
            try
            {
                if(saldo > 1000)
                {
                    porcentaje_interes = 0.10;
                    double interes = saldo * porcentaje_interes;
                    saldo_cuenta = saldo + interes;
                } else
                {
                    porcentaje_interes = 0.05;
                    double interes = saldo * porcentaje_interes;
                    saldo_cuenta = saldo + interes;
                }
            }catch(Exception ex)
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
