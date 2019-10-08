using System;

namespace EmployesAdmin.Dto
{
    public class Employe
    {
        public long id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public long roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
    }
}
