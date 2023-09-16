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
        public float? Hours { get; set; }
        public float? HourValue { get; set; }
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
                $"Salario por horas:{GetValueToPay()}";
        }
        #endregion
    }
}
