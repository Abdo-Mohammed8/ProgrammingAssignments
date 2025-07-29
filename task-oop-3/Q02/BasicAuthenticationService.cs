using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_oop_3.ClassesQ02;

namespace task_oop_3.Q02
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, (string Password, string Role)> users = new Dictionary<string, (string, string)>()
    {
        {"admin", ("1234", "Admin")},
        {"user", ("pass", "User")},
        {"guest", ("0000", "Guest")}
    };

        public bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username].Password == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return users.ContainsKey(username) && users[username].Role == role;
        }
    }

}
