using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example.model;
using example.repository;

namespace example.service
{
    public class UserService
    {
        private UserRepository userRepository = new UserRepository();

        public UserService()
        {
            this.userRepository = new UserRepository();
        }

        public User getUserById(String id)
        {
            return userRepository.getUserById(id);
        }

        public void saveUser(User user)
        {
            userRepository.saveUser(user);
        }


    }
}
