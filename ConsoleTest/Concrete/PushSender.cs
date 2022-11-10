using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Concrete
{
    public class PushSender: INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push: {message}");
        }
    }
}
