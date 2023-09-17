using EmployeeOOP.Clases;

try
{
    //Declaración de variables
    int day, month, year, id,hour,sale;
    string FirstName, LastName;
    Date BirthDate, HiringDate;
    bool IsActivo;
    float Comision;
    decimal salary,hourValue,_base;

    Console.WriteLine("APLICACION EMPLEADO");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    //pedimos datos por consola
    Console.Write("Ingrese el nombre:");
    FirstName = Console.ReadLine();

    Console.Write("Ingrese el apellido:");
    LastName = Console.ReadLine();

    Console.Write("Ingresar salario: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 1036518878,
        FirstName = FirstName,
        LastName = LastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };
    Console.WriteLine("Empleado Salariado");
    Console.WriteLine(salaryEmployee.ToString());

    //Hourly Employee

    Console.Write("Ingrse las horas trabajadas:");
    hour = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el valor de la hora:");
    hourValue = Convert.ToDecimal(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 1036518878,
        FirstName = FirstName,
        LastName = LastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,

    };
    hourlyEmployee.Hours = hour;
    hourlyEmployee.HourValue= hourValue;

    Console.WriteLine(hourlyEmployee.ToString());
    Console.WriteLine("\n");

    //CommisionEmployee

    Console.WriteLine("Empleado por comision");
    Console.WriteLine("Ingrese el numero de ventas:");
    sale = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ingrese el valor de porcentaje de comsion:");
    Comision = Convert.ToSingle(Console.ReadLine());
    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 1036518878,
        FirstName = FirstName,
        LastName = LastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,

    };
    commissionEmployee.CommisionPorcentaje = Comision;
    commissionEmployee.Sales = sale;

    Console.WriteLine(commissionEmployee.ToString());
    Console.WriteLine("\n");

    //BaseCommisionEmployee

    Console.WriteLine("Base de  comision");
    Console.WriteLine("Ingrese el valor de la base:");
    _base = Convert.ToDecimal(Console.ReadLine());
    BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
    {
        Id = 1036518878,
        FirstName = FirstName,
        LastName = LastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,

    };
    baseCommissionEmployee.Base = _base;

    Console.WriteLine(baseCommissionEmployee.ToString());
    Console.WriteLine("\n");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}