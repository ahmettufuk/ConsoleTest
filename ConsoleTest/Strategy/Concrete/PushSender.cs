using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Strategy.Concrete
{
    public class PushSender : INotification
    {
        public bool Send(NotificationModel model)
        {
            Console.WriteLine($"{model.SenderTypeEnum}: {model.Message}");
            return true;
        }
    }
}
