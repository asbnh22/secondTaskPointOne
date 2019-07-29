using System;
using System.Collections.Generic;
using System.Text;

namespace SecondTaskPartOne
{
    public class User
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        private string name;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return String.Format("Name\t\t{0}\nEmail\t\t{1}", this.Name, this.Email);
        }
    }
}
