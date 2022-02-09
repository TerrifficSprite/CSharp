using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_7_ex_1
{
    public class Organization : IComparable<Organization>
    {
        public Organization(string name, int employees, float successRate, int averageSalary)
        {
            Name = name;
            Employees = employees;
            SuccessRate = successRate;
            AverageSalary = averageSalary;
        }

        public Organization()
        {
        }

        private int employees;
        private float successRate;
        public enum positions
        {
            Headmaster,
            Manager, 
            Senior,
            Middle,
            Junior
        }
        private int averageSalary;
        private string name;

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

        public float SuccessRate
        {
            get => successRate;
            set
            {
                if (value > 100)
                    throw new Exception("Рiвень успiшностi не може бути бiльшим за 100!");
                if(value <= 0)
                    throw new Exception("Рiвень успiшностi не може бути меншим або рiвним за 0!");
                successRate = value;
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

        public int CompareTo(Organization? other)
        {

            try
            {
                return employees.CompareTo(other.Employees);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return 0;
        }
        
        
    }
}