using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public Manager ShallowCopy()
        {
            return (Manager)this.MemberwiseClone();
        }

        public Manager DeepCopy()
        {
            return new Manager(this.Name);
        }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string departmentName, Manager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        public Department DeepCopy()
        {
            Department deepCopyDepartment = (Department)this.MemberwiseClone();
            deepCopyDepartment.Manager = new Manager(this.Manager.Name);
            return deepCopyDepartment;
        }
    }
}
