using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class MessageBody
    {
        public decimal MessageBodyId { get; set; }
        public string MessageBodySender { get; set; }
        public string MessageBodySenderCompany { get; set; }
        public int MessageBodyPriority { get; set; }
        public int MessageBodyStatus { get; set; }
        public DateTime? MessageBodyDeadline { get; set; }
        public DateTime MessageBodyCreated { get; set; }
        public string MessageBodyText { get; set; }
        public decimal? MessageBodyMessageId { get; set; }
        public decimal? MessageBodySenderId { get; set; }
        public decimal? MessageBodySenderCompanyId { get; set; }
        public string MessageBodyAttachment1 { get; set; }
        public string MessageBodyAttachment2 { get; set; }
        public string MessageBodyAttachment3 { get; set; }

        public virtual Message MessageBodyMessage { get; set; }
        public virtual Company MessageBodySenderCompanyNavigation { get; set; }
        public virtual Person MessageBodySenderNavigation { get; set; }
    }
}
