using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Content
    {
        public decimal ContentId { get; set; }
        public int ContentStatus { get; set; }
        public int ContentType { get; set; }
        public string ContentTag { get; set; }
        public string ContentTagValue { get; set; }
        public string ContentScriptName { get; set; }
        public string ContentQueryString { get; set; }
        public string ContentUrl { get; set; }
        public string ContentTitle { get; set; }
        public string ContentText { get; set; }
        public string ContentKeywords { get; set; }
        public string ContentHtml { get; set; }
        public DateTime ContentPublished { get; set; }
        public DateTime ContentAdded { get; set; }
        public string ContentServerName { get; set; }
        public DateTime? ContentUpdated { get; set; }
        public decimal? ContentUpdatedById { get; set; }
        public decimal? ContentAddedById { get; set; }
        public int ContentViewed { get; set; }
        public string ContentLang { get; set; }
        public string ContentTextInit { get; set; }
        public string ContentSeourl { get; set; }
    }
}
