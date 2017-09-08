using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "demircan.yasemin@hotmail.com";
        public string MailFromAddress = "demircan.yasemin@hotmail.com";
        public bool UseSsl = true;
        public string Username = "demircan.yasemin@hotmail.com";
        public string Password = "";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
        
    }
}
