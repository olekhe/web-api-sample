using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Doc
    {
        public decimal DocId { get; set; }
        public decimal? RequestId { get; set; }
        public decimal AddedById { get; set; }
        public int DocType { get; set; }
        public string DocDoc { get; set; }
        public string DocTitle { get; set; }
        public string DocTags { get; set; }
        public string DocPath { get; set; }
        public int? DocPathType { get; set; }
        public decimal? DocFileSize { get; set; }
        public string DocText { get; set; }
        public string DocHtml { get; set; }
        public string DocNote { get; set; }
        public int DocRank { get; set; }
        public Guid DocGuid { get; set; }
        public DateTime DocAdded { get; set; }
        public decimal? AgreementId { get; set; }
        public string DocSubject { get; set; }
        public DateTime? DocSent { get; set; }
        public DateTime? DocDocAgreed { get; set; }
        public string DocDocAgreedIp { get; set; }
        public string DocDocAgreedHttp { get; set; }

        public virtual Person AddedBy { get; set; }
        public virtual Request Request { get; set; }
    }
}
