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
        public List<Employee> Employees = new List<Employee>()
        {
            new Employee("Вова",20,40000,"frontend"),
            new Employee("Петя",35,44000,"frontend"),
            new Employee("Степа",25,50000,"backend"),
            new Employee("Андрей",30,64000,"fullstack"),

        };

        public void AddEmployee(string name, int age, int salary, string position)
        {
            Employees.Add(new Employee(name,age,salary,position));
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

        public int GetAvgAge()
        {
            return Employees.Select(em => em.Age).Sum() / Employees.Count;
        }
    }
}
