using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Models.NetStandard.Email
{
    public class EmailModel
    {
        public string EmailTo { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
