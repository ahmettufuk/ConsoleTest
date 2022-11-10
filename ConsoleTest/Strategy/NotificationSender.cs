using ConsoleTest.Facade;
using ConsoleTest.Factory;
using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Strategy
{
    public class NotificationSender : INotificationSender 
    {
        private readonly INotificationFactory notificationFactory;

        public NotificationSender(INotificationFactory notificationFactory)
        {
            this.notificationFactory = notificationFactory;
        }

        public void Send(NotificationModel model)
        {
            notificationFactory.Create()[model.SenderTypeEnum].Send(model);
        }
    }
}
