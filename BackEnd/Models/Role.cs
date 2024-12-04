using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace OparinReact.Backend.Models
    {
        public class Role
        {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public ICollection<User> User { get; set; }

    }
}

