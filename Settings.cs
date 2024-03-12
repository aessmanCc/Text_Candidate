using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Canidates
{
    class Settings
    {
        public Settings()
        {

        }

        public Settings(string userEmail, string userPassword)
        {
            this.UserEmail = userEmail;
            this.userPassword = userPassword;
        }

        public string UserEmail { get; set; }
        
        public string userPassword { get; set; }
    }
}


