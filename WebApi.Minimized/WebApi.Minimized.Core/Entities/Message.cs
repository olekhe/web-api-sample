using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Message
    {
        public Message()
        {
            MessageBody = new HashSet<MessageBody>();
        }

        public decimal MessageId { get; set; }
        public string MessageNumber { get; set; }
        public string MessageSubject { get; set; }
        public string MessageSender { get; set; }
        public int MessagePriority { get; set; }
        public string MessageSenderCompany { get; set; }
        public int MessageStatus { get; set; }
        public DateTime? MessageDeadline { get; set; }
        public DateTime? MessageModified { get; set; }
        public decimal? MessageSenderId { get; set; }
        public DateTime MessageCreated { get; set; }
        public decimal? MessageSenderCompanyId { get; set; }

        public virtual Company MessageSenderCompanyNavigation { get; set; }
        public virtual Person MessageSenderNavigation { get; set; }
        public virtual ICollection<MessageBody> MessageBody { get; set; }
    }
}
