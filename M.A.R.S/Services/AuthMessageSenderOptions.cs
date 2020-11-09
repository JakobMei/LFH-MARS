using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }

        public void setStandardMARSAuthentication()
        {
            SendGridUser = Environment.GetEnvironmentVariable("SendGridUser");
            SendGridKey = Environment.GetEnvironmentVariable("SendGridKey");
            if (SendGridKey == null && SendGridUser == null)
            {
                Console.WriteLine("Keine Env Variablen Verfügbar, MailService deaktiviert ");
                SendGridUser = "error";
                SendGridKey = "error";
            }
        }
    }
}
