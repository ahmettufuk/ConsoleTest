using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Concrete
{
    public class MailSender : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Mail: {message}");
        }
    }
}
