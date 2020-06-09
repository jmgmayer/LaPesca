using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaPesca.Tools.Services
{
    public interface IEmailSender
    {
        Task SenderEMailAsync(string email, string subject, string message);
    }
}
