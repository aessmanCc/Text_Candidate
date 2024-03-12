using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Canidates
{
    class Message
    {
        public Message()
        {

        }

        public Message(string store, DateTime date, string timeStamp, string message)
        {
            this.StoreNumber = store;
            this.DateOccur = date;
            this.TimeStamp = timeStamp;
            this.MessageContent = message;
        }

        public string StoreNumber { get; set; }
        public DateTime DateOccur { get; set; }
        public string TimeStamp { get; set; }
        public string MessageContent { get; set; }
    }
}
