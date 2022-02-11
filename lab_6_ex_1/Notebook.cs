using System;

namespace lab_6_ex_1
{
    public class Notebook : IComparable
    {

        private string lastname;
        private string firstname;
        private string postAdress;
        private int phoneNumber;
        private string email;

        public override string ToString()
        {
            return $"Прiзвище: {lastname}, Iм'я: {firstname}, Поштова адреса: {postAdress}, Номер телефону: {phoneNumber}, " +
                   $"Електронна пошта: {email}";
        }

        public int CompareTo(object? obj)
        {
            Notebook other = (Notebook) obj;
            return Lastname.CompareTo(other.Lastname);
        }

        public Notebook()
        {
            Lastname = "lastname";
            Firstname = "firstname";
            PostAdress = "adress";
            PhoneNumber = 0981231231;
            Email = "email@gmail.com";
        }
        public Notebook(string lastname, string firstname, string postAdress, int phoneNumber, string email)
        {
            Lastname = lastname;
            Firstname = firstname;
            PostAdress = postAdress;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        
        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }

        public string PostAdress
        {
            get => postAdress;
            set => postAdress = value;
        }

        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}