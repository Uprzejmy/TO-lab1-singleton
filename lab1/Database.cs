using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Database
    {
        public List<User> users;
        public List<Group> groups;

        private static Database _database = null;
	
	    //important!
	    private Database()
        {
            users = new List<User>();
            groups = new List<Group>();
        }
	
	    public static Database getInstance()
	    {
		    if(_database == null)
		    {
			    _database = new Database();
		    }
		
		    return _database;
	    }
    }
}
