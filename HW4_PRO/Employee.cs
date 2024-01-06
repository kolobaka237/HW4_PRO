using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_PRO
{
     internal class Employee
    {
        public int salary { get; set; }
        public static Employee operator +(Employee salary1, Employee salary2)
        {
            return new Employee { salary = salary1.salary + salary2.salary };
        }
        public static Employee operator -(Employee salary1, Employee salary2)
        {
            return new Employee { salary = salary1.salary - salary2.salary };
        }
        public static bool operator ==(Employee salary1, Employee salary2) => salary1.salary == salary2.salary;
        public static bool operator !=(Employee salary1, Employee salary2) => salary1.salary != salary2.salary;
        public static bool operator >(Employee salary1, Employee salary2) => salary1.salary > salary2.salary;
        public static bool operator <(Employee salary1, Employee salary2) => salary1.salary < salary2.salary;
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Employee other = (Employee)obj;
            return salary == other.salary;
        }

        public static void TestEmployee()
        {
            Employee employee = new Employee() { salary = 2500 };
            Employee employee2 = new Employee() { salary = 250 };
            Employee employee3 = employee + employee2;
            Console.WriteLine($"Test overload for class Employee. \nStart value for class:\nFirst salary = 2500$\nSecond salary 250$");
            Console.WriteLine($"Result {employee.salary} + {employee2.salary} = {employee3.salary}");
            employee3 = employee - employee2;
            Console.WriteLine($"Result {employee.salary} - {employee2.salary} = {employee3.salary}");
            bool info = employee == employee2;
            Console.WriteLine($"Result {employee.salary} == {employee2.salary} is a {info}");
            info = employee > employee2;
            Console.WriteLine($"Result {employee.salary} > {employee2.salary} is a {info}");
            info = employee < employee2;
            Console.WriteLine($"Result {employee.salary} < {employee2.salary} is a {info}");
            info = employee != employee2;
            Console.WriteLine($"Result {employee.salary} != {employee2.salary} is a {info}");
            info = employee.Equals( employee2);
            Console.WriteLine($"Result method Equals for class Employee = {info}");
        }
    }
}
