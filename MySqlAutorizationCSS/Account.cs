using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlAutorizationCSS
{
    public class Account
    {
        [Key]
        public int user_id { get; set; }
        public  string user_name { get; set; }
        public  string user_password { get; set; }

        public Account(string user_name, string user_password)
        {
            this.user_name = user_name; 
            this.user_password = user_password;
        }
    }
        
}
