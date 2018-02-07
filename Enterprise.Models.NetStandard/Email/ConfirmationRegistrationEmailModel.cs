using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Models.NetStandard.Email
{
    public class ConfirmationRegistrationEmailModel:EmailModel
    {
        public string Link { get; set; }
    }
}
