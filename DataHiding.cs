using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Hiding
{
    class DataHiding
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Roll number cannot be negative.");
                }
                rollNo = value;
            }
        }

        public DataHiding(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
    }
}
