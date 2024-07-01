using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example.model;
using example.service;

namespace example.controller
{
    public class UserController
    {
        private UserService userService = new UserService();

        public UserController()
        {
            this.userService = new UserService();
        }

        public User getUserById(String id)
        {
            return userService.getUserById(id);
        }

        public void saveUser(User user)
        {
            userService.saveUser(user);
        }

    }
}
