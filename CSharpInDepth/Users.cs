using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth
{
    class User
    {
        public int Id;
        public string Name;
        public string Details;
    }
    class Users
    {
        private readonly List<User> _users;
        public List<User> UsersList { get { return _users; } }
        public Users()
        {
            _users = new List<User> {
                new User()
                {
                    Id = 0, Name =  "Eu", Details = "Jane Son\\12.41.11\\Labor'm"
                }
            };
        }

    }
}
