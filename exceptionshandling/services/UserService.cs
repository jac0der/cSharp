using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exceptionshandling.services
{
    public class UserService
    {
        // define a private list of users
        private readonly List<User> _users = new()
        {
            new User{Id = 1, Name = "Code Maze"},
            new User{Id = 2, Name = "John Doe"}
        };

        // get a user by provided user id
        public User GetById(int id)
        {
            ValidateID(id);

            var user = _users.First(x => x.Id == id);
            return user;
        }

        public void Clear() => _users.Clear();

        private static void ValidateID(int id)
        {
            if(id <= 0 || id > 1000)
                throw new InvalidUserIdException();
        }
    }
}