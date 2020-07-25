using Banco_App.Clases;
using Banco_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CuentaBancaria> cuentaBanco = new List<CuentaBancaria>();
            DatosCuentas DataEmpresarial = new CuentaEmpresarial();
            DatosCuentas DataJoven = new CuentaJoven();
            DatosCuentas DataTienda = new CuentaTienda();

            Console.WriteLine("**** Mostramos todas los cuentas ****");

            cuentaBanco = DataEmpresarial.getAllCuentas();
            foreach (CuentaBancaria cuenta in cuentaBanco)
            {
                Console.WriteLine("************* Cuenta Empresarial ***********************");
                cuenta.muestraCuentas();
                double result = DataEmpresarial.CalculodeValor(1000);
                Console.WriteLine("Saldo: " + result);
            }

            cuentaBanco = DataJoven.getAllCuentas();
            foreach (CuentaBancaria cuenta in cuentaBanco)
            {
                Console.WriteLine("************* Cuenta Joven ***********************");
                cuenta.muestraCuentas();
                double result = DataJoven.CalculodeValor(800);
                Console.WriteLine("Saldo: " + result);
            }

            cuentaBanco = DataTienda.getAllCuentas();
            foreach (CuentaBancaria cuenta in cuentaBanco)
            {
                Console.WriteLine("************* Cuenta Tienda ***********************");
                cuenta.muestraCuentas();
                double result = DataTienda.CalculodeValor(500);
                Console.WriteLine("Saldo: " + result);
            }
            Console.ReadKey();
        }
    }
}
