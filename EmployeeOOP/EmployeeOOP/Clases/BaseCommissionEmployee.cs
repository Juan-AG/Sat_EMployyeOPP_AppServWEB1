using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class BaseCommissionEmployee:CommissionEmployee
    {
        #region Propiedades
        public decimal Base { get; set; }
        #endregion

        #region Metodos
        public override decimal GetValueToPay()
        {
            return Convert.ToDecimal((CommisionPorcentaje / 100) * Sales )+Base;
        }

        public override string ToString()
        {
            return $" {base.ToString()} " +
                $"Comision de porcentaje:{CommisionPorcentaje}\n" +
                $"Ventas:{Sales}";
        }
        #endregion
    }
}
