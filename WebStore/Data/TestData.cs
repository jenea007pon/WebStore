using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Employee> Emplyees { get; } = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Surname = "Ivanov",
                FirstName = "Ivan",
                Patronymic = "Ivanovich",
                Age = 50
            },
            new Employee
            {
                Id = 2,
                Surname = "Petrov",
                FirstName = "Petr",
                Patronymic = "Petrovich",
                Age = 25
            },
            new Employee
            {
                Id = 3,
                Surname = "Sidorov",
                FirstName = "Sidor",
                Patronymic = "Sidorovich",
                Age = 25
            }


        };
    }
}
