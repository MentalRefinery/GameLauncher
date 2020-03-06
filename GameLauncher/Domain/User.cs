using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GameLauncher.Domain
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public DateTime TimeCreated { get; set; }
        public ObservableCollection<Message> UserMessages { get; set; }
    }

    public class Message
    {
        public DateTime TimeSent { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string MessageSent { get; set; }
    }
}
