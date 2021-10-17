using System;

namespace OTUS_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и зарплату. Для окончания ввода введите пустое имя");
            Console.WriteLine();

            Employee employee = null;
            int flag = 0;

            while (flag == 0)
            {
                while (true)
                {
                    string employeeName = Console.ReadLine();

                    if (string.IsNullOrEmpty(employeeName))
                    {
                        break;
                    }

                    int employeeSalary = CheckedInput();

                    if (employee == null)
                    {
                        employee = new Employee { Name = employeeName, Salary = employeeSalary };
                    }

                    else
                    {
                        Employee.Add(employee, new Employee { Name = employeeName, Salary = employeeSalary });
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Имя - сотрудник");
                Employee.Traverse(employee);

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Интересующий размер зарплаты");
                    Console.WriteLine();

                    int toSearch = CheckedInput();

                    Employee foundEmployee = Employee.Search(employee, toSearch);

                    if (foundEmployee == null)
                    {
                        Console.WriteLine("Такой сотрудник не найден");
                    }

                    else
                    {
                        Console.WriteLine(foundEmployee);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Введите:\n" +
                                        "0 - для перехода в начало программы;\n" +
                                        "1 - для продолжения поиска по зарплате;\n" +
                                        "2 - для выхода.");
                    Console.WriteLine();

                    int inputNum = CheckedInput();

                    if (inputNum == 0)
                    {
                        employee = null;
                        break;
                    }

                    if (inputNum == 1)
                    {
                        continue;
                    }

                    if (inputNum == 2)
                    {
                        flag = 1;
                        break;
                    }
                }

            }

            Console.ReadKey();
        }

        static int CheckedInput()
        {
            while (true)
            {
                bool inputNum = int.TryParse(Console.ReadLine(), out int outputNum);

                if (inputNum)
                {
                    return outputNum;
                }

                Console.WriteLine("Некорректный ввод. Повторите.");
                Console.WriteLine();
            }
        }
    }
}
