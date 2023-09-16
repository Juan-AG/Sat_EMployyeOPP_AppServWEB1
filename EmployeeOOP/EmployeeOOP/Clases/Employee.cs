using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public abstract class Employee
    {
        #region Propiedades
        //Prop + tab = propiedades
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? BirthDate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsActive { get; set; }
        #endregion

        #region Metodos
        public Employee()
        {
                
        }
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
             return $"INFORMACION DEl EMPLEADO\n\t" +
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de Nacimiento: {BirthDate}\n\t" +
                $"Fecha de Firma de contrato: {HiringDate}\n\t" +
                $"¿Empleado Activo?: {IsActive}\n\t";
        }
        #endregion
    }
}
