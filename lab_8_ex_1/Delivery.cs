using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_8_ex_1
{
    public class Delivery
    {
        private string name;
        private string address;
        private int employees;
        private int deliversInDay;
        private int averageSalary;

        public Delivery()
        {
        }

        public Delivery(string name, string address, int employees, int deliversInDay, int averageSalary)
        {
            this.Name = name;
            this.Address = address;
            this.Employees = employees;
            this.DeliversInDay = deliversInDay;
            this.AverageSalary = averageSalary;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Trim().Length < 1)
                    throw new Exception("Довжина назви не може бути меншою за 1");
                name = value;
            }
        }

        public string Address
        {
            get => address;
            set
            {
                if (value.Trim().Length < 1)
                    throw new Exception("Довжина адреси не може бути меншою за 1");
                address = value;
            }
        }

        public int Employees
        {
            get => employees;
            set
            {
                if (value < 1)
                    throw new Exception("В органiзацiї не може бути менше 1 людини!");
                employees = value;
            }
        }

        public int DeliversInDay
        {
            get => deliversInDay;
            set
            {
                if (deliversInDay < 0)
                    throw new Exception("Кiлькiсть заказiв в день не може бути меншою за 0");
                deliversInDay = value;
            }
        }

        public int AverageSalary
        {
            get => averageSalary;
            set
            {
                if (value < 1)
                    throw new Exception("Середня зарплата не може бути меншою за 1");
                averageSalary = value;
            }
        }
        
        public class SortByEmployees : IComparer<Delivery>
        {
            public int Compare(Delivery? x, Delivery? y)
            {
                if (x.Employees > y.Employees)
                    return 1;
                if (x.Employees < y.Employees)
                    return -1;
                return 0;
            }
        }
        
        public class SortByDeliversInDay : IComparer<Delivery>
        {
            public int Compare(Delivery? x, Delivery? y)
            {
                if (x.DeliversInDay > y.DeliversInDay)
                    return 1;
                if (x.DeliversInDay < y.DeliversInDay)
                    return -1;
                return 0;
            }
        }
        
        public class SortByAverageSalary : IComparer<Delivery>
        {
            public int Compare(Delivery? x, Delivery? y)
            {
                if (x.AverageSalary > y.AverageSalary)
                    return 1;
                if (x.AverageSalary < y.AverageSalary)
                    return -1;
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name}, {address}, {employees}, {deliversInDay}, {averageSalary}";
        }
    }
}