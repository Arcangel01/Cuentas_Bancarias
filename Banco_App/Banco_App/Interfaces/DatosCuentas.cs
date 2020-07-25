using Banco_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_App.Interfaces
{
    interface DatosCuentas
    {
        List<CuentaBancaria> getAllCuentas();
        double CalculodeValor(double saldo);
    }
}
