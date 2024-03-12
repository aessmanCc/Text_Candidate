using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Canidates
{
    class Email
    {
        public Email()
        {

        }

        public Email(string canidateName, long canidateNumber, string userMessage, string phoneProvider)
        {
            this.CanidateName = canidateName;
            this.CanidateNumber = canidateNumber;
            this.UserMessage = userMessage;
            this.PhoneProvider = phoneProvider;

        }

        public string CanidateName { get; set; }
        public long CanidateNumber { get; set; }
        public string UserMessage{ get; set; }
        public string PhoneProvider { get; set; }


    }
}

