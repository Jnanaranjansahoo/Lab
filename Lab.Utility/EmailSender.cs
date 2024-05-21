using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Utility
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret {  get; set; }
        public EmailSender(IConfiguration _config) 
        {
            SendGridSecret = _config.GetValue<string>("");
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // To Send Email

           return Task.CompletedTask ;
        }
    }
}
