using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OparinReact.Backend.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public int Position { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
