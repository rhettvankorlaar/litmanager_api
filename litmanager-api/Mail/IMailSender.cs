using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Mail
{
    public interface IMailSender
    {
        public void SendMail(Receiver receiver, string subject, string content);
    }
}
