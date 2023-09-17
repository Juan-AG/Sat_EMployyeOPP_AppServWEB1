using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class HourlyEmployee:Employee
    {
        #region Propiedades
        public int? Hours { get; set; }
        public decimal? HourValue { get; set; }
        #endregion

        #region Metodos
        public HourlyEmployee()
        {
                
        }

        public override decimal GetValueToPay()
        {
            return Convert.ToDecimal(Hours * HourValue);
        }

        public override string ToString()
        {
            return $" {base.ToString()} "+
                $"Salario por horas:{GetValueToPay():C2}";
        }
        #endregion
    }
}
