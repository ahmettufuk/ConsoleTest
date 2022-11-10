using ConsoleTest.Concrete;
using ConsoleTest.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Factory
{
    public class NotificationFactory : INotificationFactory
    {
        public List<INotification> Create()
        {
            
            return new List<INotification>()
            {
                { new UpperDecorator(new MailSender()) },
                { new SmsSender() },
                { new UpperDecorator(new PushSender()) },
                
            };
        }
    }
}
