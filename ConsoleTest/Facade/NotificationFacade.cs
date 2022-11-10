using ConsoleTest.Factory;
using ConsoleTest.Model;
using ConsoleTest.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Facade
{
    public class NotificationFacade : INotificationFacade
    {
        private readonly INotificationSender notificationSender;

        public NotificationFacade(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        } 

        public void SendNotification(NotificationModel model)
        {
            notificationSender.Send(model);
        }
    }
}
