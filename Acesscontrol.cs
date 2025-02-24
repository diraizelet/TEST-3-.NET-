using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public virtual void AccessControl()
        {
            Console.WriteLine("Access control for user.");
        }
    }

    public class Admin : User
    {
        public Admin()
        {
            Role = "Admin";
        }

        public override void AccessControl()
        {
            Console.WriteLine("Admin has access to all features.");
        }
    }

    public class Customer : User
    {
        public Customer()
        {
            Role = "Customer";
        }

        public override void AccessControl()
        {
            Console.WriteLine("Customer has limited access.");
        }
    }
}
