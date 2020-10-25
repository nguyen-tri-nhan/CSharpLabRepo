using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class EmployeeDTO
    {
        private string id, password;
        private bool role;

        public EmployeeDTO(string id, string password, bool role)
        {
            this.id = id;
            this.password = password;
            this.role = role;
        }

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public bool Role { get => role; set => role = value; }
    }
}
