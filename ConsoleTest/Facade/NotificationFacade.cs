using ConsoleTest.Concrete;
using ConsoleTest.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Facade
{
    public class NotificationFacade : INotificationFacade
    {
        private readonly INotificationFactory notificationFactory;

        public NotificationFacade(INotificationFactory notificationFactory)
        {
            this.notificationFactory = notificationFactory;
        }

        public void SendNotification(string message)
        {
            var results = notificationFactory.Create();
            
            foreach (var result in results)
            {
                result.Send(message);
            }
        }
    }
}
