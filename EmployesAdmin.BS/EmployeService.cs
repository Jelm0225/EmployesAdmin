using EmployesAdmin.DT;
using EmployesAdmin.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployesAdmin.Business
{
    public class EmployeService : IEmpoye
    {
        private const int hoursPerMonth = 120;
        private const int monthOfYear = 12;
        private const string HourySalaryContract = "HourlySalaryEmployee";

        public IEnumerable<EmployesAnualSalary> GetEmployes()
        {
            IEnumerable<Employe> employes = EmployesServiceClient.GetAllEmployes();

            IEnumerable<EmployesAnualSalary> employesResult = (from e in employes
                                                               select new EmployesAnualSalary(e.id, e.name, e.contractTypeName,
                                                               MapAnualSalaryTotal(e.contractTypeName, (e.contractTypeName == HourySalaryContract ? e.hourlySalary : e.monthlySalary))));

            return employesResult;
        }

        public IEnumerable<EmployesAnualSalary> GetEmployes(string employeName)
        {

            IEnumerable<Employe> employes = EmployesServiceClient.GetAllEmployes();
            IEnumerable<EmployesAnualSalary> employesResult = (from e in employes
                                                               where e.name.ToLower().Contains(employeName.ToLower())
                                                               select new EmployesAnualSalary(e.id, e.name, e.contractTypeName,
                                                               MapAnualSalaryTotal(e.contractTypeName, (e.contractTypeName == HourySalaryContract ? e.hourlySalary : e.monthlySalary))));


            return employesResult;
        }

        private decimal MapAnualSalaryTotal(string contractTypeName, decimal salary = 0)
        {
            decimal anualSalary = 0;

            switch (contractTypeName)
            {
                case HourySalaryContract:
                    {
                        anualSalary = (hoursPerMonth * salary * monthOfYear);
                        break;
                    }
                default:
                    {
                        anualSalary = (salary * monthOfYear);
                        break;
                    }
            }

            return anualSalary;
        }

    }
}
