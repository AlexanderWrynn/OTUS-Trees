using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Trees
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee Left { get; set; }
        public Employee Right { get; set; }

        public static void Add(Employee current, Employee toAdd)
        {
            if (toAdd.Salary < current.Salary)
            {
                if (current.Left != null)
                {
                    Add(current.Left, toAdd);
                }

                else
                {
                    current.Left = toAdd;
                }
            }

            else
            {
                if (current.Right != null)
                {
                    Add(current.Right, toAdd);
                }

                else
                {
                    current.Right = toAdd;
                }
            }
        }

        public static void Traverse(Employee employee)
        {
            if (employee.Left != null)
            {
                Traverse(employee.Left);
            }

            Console.WriteLine(employee);

            if (employee.Right != null)
            {
                Traverse(employee.Right);
            }

        }

        public static Employee Search(Employee current, int value)
        {
            if (value < current.Salary)
            {
                if (current.Left != null)
                {
                    return Search(current.Left, value);
                }

                else
                {
                    return null;
                }
            }

            else if (value > current.Salary)
            {
                if (current.Right != null)
                {
                    return Search(current.Right, value);
                }

                else
                {
                    return null;
                }
            }
            else
            {
                return current;
            }
        }

        public override string ToString()
        {
            return Name + " - " + Salary.ToString();
        }
    }
}
