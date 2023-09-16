using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class CommissionEmployee : Employee
    {
        #region Propiedades
        public float? CommisionPorcentaje { get; set; }
        public int? Sales { get; set; }

        #endregion

        #region Metodos

        public override decimal GetValueToPay()
        {
            return Convert.ToDecimal((CommisionPorcentaje / 100) * Sales);
        }


        public override string ToString()
        {
            return $" {base.ToString()} " +
                $"Comision de porcentaje:{CommisionPorcentaje}\n"+
                $"Ventas:{Sales}\n"+
                $"Valor a pagar por comisiones:{GetValueToPay()}\n";
        }
        #endregion
    }
}