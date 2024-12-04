using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OparinReact.Backend.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }

        public int AssignedTo { get; set; }
        public Project Project { get; set; }

        public string Status { get; set; }
    }
}
