using System;

namespace lab_4_ex_2
{
    public class Notebook : IComparable<Notebook>
    {

        private string lastname;
        private string firstname;
        private string adress;
        private int phoneNumber;
        private string email;
        
        public Notebook()
        {
            Lastname = "lastname";
            Firstname = "firstname";
            Adress = "adress";
            PhoneNumber = 0981231231;
            Email = "email@gmail.com";
        }
        public Notebook(string lastname, string firstname, string adress, int phoneNumber, string email)
        {
            Lastname = lastname;
            Firstname = firstname;
            Adress = adress;
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

        public string Adress
        {
            get => adress;
            set => adress = value;
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
    
        public int CompareTo(Notebook? other)
        {
            return lastname.CompareTo(other.lastname);
        }
    }
}