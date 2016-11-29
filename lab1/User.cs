using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class User
    {
        private int _id;

        public string email;

        public Group group;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public static bool login(string email)
        {
            foreach(User user in Database.getInstance().users)
            {
                if (user.email.Equals(email))
                    return true;
            }

            return false;
        }
    }
}
