using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.ChainOfResponsibility
{
    internal class NotificationChainDecorator : INotification
    {
        private readonly INotification notification;
        private readonly INotification notificationNext;

        public NotificationChainDecorator(INotification notification, INotification notificationNext)
        {
            this.notification = notification;
            this.notificationNext = notificationNext;
        }
        public bool Send(NotificationModel model)
        {
            if (notification.Send(model))
            {
                return true;
            }

            return notificationNext.Send(model);


        }
    }
}
