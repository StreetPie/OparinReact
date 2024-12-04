using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OparinReact.Backend.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }

        public ICollection<Task> Task { get; set; }

        public ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
