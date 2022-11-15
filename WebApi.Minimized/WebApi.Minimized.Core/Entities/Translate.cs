using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Translate
    {
        public decimal TranslateId { get; set; }
        public string TranslateEn { get; set; }
        public string TranslateFr { get; set; }
        public string TranslateIt { get; set; }
        public string TranslateEs { get; set; }
        public string TranslateDe { get; set; }
        public string TranslateEl { get; set; }
        public string TranslateRu { get; set; }
        public string TranslateUk { get; set; }
        public DateTime TranslateAdded { get; set; }
        public string TranslateGr { get; set; }
    }
}
