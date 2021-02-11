using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Salary { get; set;}

        public string Position { get; set; }

        public Employee(string Name,int Age,int Salary,string Position)
        {
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.Position = Position;
        }
    }
}
