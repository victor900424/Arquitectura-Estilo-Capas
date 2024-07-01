using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example.model;
using System.Collections.Generic;

namespace example.repository
{
    internal class UserRepository
    {
        private Dictionary<string, User> userDatabase = new Dictionary<string, User>();

        public User getUserById(string id)
        {
            userDatabase.TryGetValue(id, out User user);
            return user;
        }

        public void saveUser(User user)
        {
            userDatabase[user.getId()] = user;
        }
    }
}
