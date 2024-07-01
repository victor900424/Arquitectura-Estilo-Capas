using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.model
{
    public class User
    {
        private string id;
        private string name;
        private string email;

        public User(string id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        // Getters and Setters
        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }


    }
}
