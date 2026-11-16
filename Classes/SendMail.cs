using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegIN_Shashin.Classes
{
    public class SendMail
    {
        public static void SendMessage(string Message, string To)
        {
            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("yandex@yandex.ru", "zbahldoablcghrjt"),
                EnableSsl = true,
            };
            smtpClient.Send("alexshashin.2023@gmail.com", To, "Проект Regin", Message);
        }
    }
}
