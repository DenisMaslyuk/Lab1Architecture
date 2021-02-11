using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BL
{
    public class BusinessLogical
    {
        public List<Employee> Employees = new List<Employee>();

        public void AddEmployee(string name, int age, int salary, string position)
        {
            Employee employee = new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary,
                Position = position
            };

            Employees.Add(employee);
        }


        public void InfoEmp()
        {
            Console.WriteLine("Список сотрудников:");
            foreach (var emp in Employees)
            {
                Console.WriteLine("Имя: " + emp.Name + " " + "Возраст: " + emp.Age + " " + "Зарплата: " + emp.Salary + " " + "Должность: " + emp.Position);
                Console.WriteLine();
            }
        }

        public void DeleteEmployee(Employee employees)
        {
            Employees.Remove(employees);
        }

        public void RaiseSalary(Employee employee, int sum)
        {
            employee.Salary += sum;
        }

        public void ChangePosition(Employee employee, string NewPosition)
        {
            employee.Position = NewPosition;
        }

        public void DeleteEmpForm(int id)
        {
            Employees.RemoveAt(id);
        }
    }
}
