using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Concrete
{
    public class SmsSender:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sms: {message}");
        }
    }
}
