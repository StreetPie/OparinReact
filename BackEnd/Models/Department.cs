using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OparinReact.Backend.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
