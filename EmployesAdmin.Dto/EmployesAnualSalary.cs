using System;
using System.Collections.Generic;
using System.Text;

namespace EmployesAdmin.Dto
{
    public class EmployesAnualSalary
    {
        public EmployesAnualSalary(long id, string name, string contractTypeName, decimal anualSalay)
        {
            Id = id;
            this.name = name;
            this.contractTypeName = contractTypeName;
            this.anualSalay = anualSalay;
        }

        public long Id { get; private set; }
        public string name { get; private set; }
        public string contractTypeName { get; private set; }
        public decimal anualSalay { get; private set; }
    }
}
