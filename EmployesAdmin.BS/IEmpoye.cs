using EmployesAdmin.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployesAdmin.Business
{
    public interface IEmpoye
    {
        IEnumerable<EmployesAnualSalary> GetEmployes();
        IEnumerable<EmployesAnualSalary> GetEmployes(string employeName);

    }
}
