using PharmacyManager.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManager.Shared.Entities
{
    public class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public RoleType Role { get; set; }
    }
}
